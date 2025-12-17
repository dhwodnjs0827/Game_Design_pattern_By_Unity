using UnityEngine;

namespace ObjectPool
{
    public class ClientObjectPool : MonoBehaviour
    {
        private DroneObjectPool pool;

        private void Start()
        {
            pool = gameObject.AddComponent<DroneObjectPool>();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Spawn Drones"))
            {
                pool.Spawn();
            }
        }
    }
}