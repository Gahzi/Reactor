using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : UnityEngine.Object
{
    private static T _instance;
    
    /// <summary>
    /// Gets or sets the _instance.
    /// </summary>
    /// <value>The _instance.</value>
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                Instance = FindObjectOfType<T>();
            }
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
}
