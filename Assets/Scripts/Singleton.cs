using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: Component
{
    private static T instance;
    
    [Obsolete("FindObjectOfType 호출로 인해 추후 변경해야 함.")]
    public static T Instance
    {
        get
        {
            // 새로운 인스턴스를 초기화하기 전에 다른 인스턴스가 없는지 확인
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    instance = obj.AddComponent<T>();
                }
            }
            
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
