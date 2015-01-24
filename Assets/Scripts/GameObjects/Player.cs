using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Resources.Scripts.GameObjects
{
    public class Player : MonoBehaviour
    {

        public float MovementSpeedPerFrame = 0.5f;
        public float MaximumDirectionLength = 1.5f;

        public Transform PreviouslyVisitedNavTransform = null;

        private enum PlayerState
        {
            Parked,
            Moving
        }

        public Road CurrentRoad;
        private PlayerState _state;
        private Vector3 _prevDirection;
        public GameObject targetNav;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
            if (CurrentRoad == null)
            {
                Debug.LogWarning("Warning, player's current road is empty.");
            }
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            CheckInputs();

            switch (_state)
            {
                case PlayerState.Parked:
                {
                    break;
                }

                case PlayerState.Moving:
                {
                    transform.position = Vector3.MoveTowards(transform.position,targetNav.transform.position,Time.fixedDeltaTime*MovementSpeedPerFrame);
                    break;
                }
            }


        }

        private void CheckInputs()
        {
            //make a vector out of the horizontal and vert axis.
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) //horiAxis == 0.0f && vertAxis == 0.0f)
            {
                return;
            }

            float horiAxis = Input.GetAxis("Horizontal");
            float vertAxis = Input.GetAxis("Vertical");
            Vector3 localDirection = new Vector3(horiAxis * MaximumDirectionLength, 0 ,vertAxis * MaximumDirectionLength);
            SetMovementDirection(localDirection);
            Debug.DrawLine(transform.position,localDirection + transform.position);

            

            //_prevDirection = new Vector3(horiAxis * MovementSpeedPerFrame, 0, vertAxis * MovementSpeedPerFrame);
            //newPos.x += horiAxis * MovementSpeedPerFrame;
            //newPos.z += vertAxis * MovementSpeedPerFrame;

            //transform.position = newPos;
        }

        private void SetMovementDirection(Vector3 newDirection)
        {
            if (!CurrentRoad)
            {
                return;
            }

            RaycastHit hit;
            if (Physics.Raycast(gameObject.transform.position, newDirection, out hit, MaximumDirectionLength))
            {
                GameObject hitGameObject = hit.collider.gameObject;
                if (hitGameObject.tag.Equals("RoadNav"))
                {
                    targetNav = hitGameObject;

                    if (_state == PlayerState.Parked)
                    {
                        _state = PlayerState.Moving;
                    }
                }
            }
        }
    }
}
