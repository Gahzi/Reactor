using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Resources.Scripts.Managers
{
    public class GameManagerScript : MonoBehaviour
    {
        public int MapRows = 0;
        public int MapCells = 0;

        // Use this for initialization
        [UsedImplicitly]
        void Start () 
        {
            GenerateLevel();
        }
	
        // Update is called once per frame
        [UsedImplicitly]
        void Update () {
	
        }

        protected void GenerateLevel()
        {
            for (int i = 0; i < MapCells; i++)
            {
                for (int j = 0; j < MapRows; j++)
                {
                    GameObject newGridItemGO = (GameObject)Instantiate(UnityEngine.Resources.Load(ObjectConstants.PrefabNames[ObjectConstants.Type.Floor]));
                    newGridItemGO.name = ObjectConstants.PrefabNames[ObjectConstants.Type.Floor] + "(" + i + "," + j + ")";
                    MeshFilter mf = newGridItemGO.GetComponent<MeshFilter>();
                    Debug.Log("Renderer Bound Size X : " + mf.renderer.bounds.size.x);
                    Debug.Log("Renderer Bound Size Y : " + mf.renderer.bounds.size.y);
                    Debug.Log("Renderer Bound Size Z : " + mf.renderer.bounds.size.z);
                    //newGridItemGO.transform.position = new Vector3(gridPosX*Match3Constants.GridItemBufferDistance,gridPosY*Match3Constants.GridItemBufferDistance,0);
                 

                }
            }
        }
    }
}
