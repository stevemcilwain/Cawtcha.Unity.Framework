/*===============================================================
Game:       Cawtcha Framework
Developer:  Steve Mcilwain
Company:    Cawtcha LLC
================================================================*/

using UnityEngine;

namespace Cawtcha.Patterns
{
    public abstract class SingletonBehavior<T> : BaseBehavior where T : SingletonBehavior<T>
    {
        public static T Instance
        {
            get
            {
                var t = typeof(T);

                if (_instance.IsNull())
                {
                    _instance = FindObjectOfType<T>();

                    if (_instance.IsNull())
                    {
                        var go = new GameObject();
                        _instance = go.AddComponent<T>();
                        go.name = "Singleton " + t;
                        _instance.LogWarn("Created singleton instance for {0}", t);
                    }
                }

                return _instance;
            }
        }

        private static T _instance;

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                _instance = (T)this;
            }
            else if (Instance != this)
            {
                Debug.LogError("Destroying additional instance of singleton " + typeof(T));
                Destroy(gameObject);
            }
        }

    }
}
