using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPool
{
    public class DroneObjectPool : MonoBehaviour
    {
        public int maxPoolSize = 10;  // 풀에 보관할 인스턴스의 최대 개수
        public int stackDefaultCapacity = 10;  // 기본 스택 크기

        public IObjectPool<Drone> Pool
        {
            get
            {
                if (pool == null)
                {
                    pool = new ObjectPool<Drone>(
                        CreatedPooledItem,
                        OnTakeFromPool,
                        OnReturnedToPool,
                        OnDestroyPoolObject,
                        true,
                        stackDefaultCapacity,
                        maxPoolSize);
                }
                return pool;
            }
        }
        
        private IObjectPool<Drone> pool;

        /// <summary>
        /// 인스턴스를 초기화
        /// </summary>
        /// <returns></returns>
        private Drone CreatedPooledItem()
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            
            Drone drone = go.AddComponent<Drone>();
            
            go.name = "Drone";
            drone.Pool = Pool;
            
            return drone;
        }

        /// <summary>
        /// 씬에서 없애기 위해 게임 오브젝트를 비활성화
        /// </summary>
        private void OnReturnedToPool(Drone drone)
        {
            drone.gameObject.SetActive(false);
        }

        /// <summary>
        /// 클라이언트가 인스턴스를 요청할 때 호출됨(인스턴스가 반환되는 것이 아니라 게임 오브젝트가 활성화 됨)
        /// </summary>
        private void OnTakeFromPool(Drone drone)
        {
            drone.gameObject.SetActive(true);
        }

        /// <summary>
        /// 풀에 더 이상 공간이 없을 때 호출(반환된 인스턴스는 메모리를 확보하기 위해 파괴)
        /// </summary>
        /// <param name="drone"></param>
        private void OnDestroyPoolObject(Drone drone)
        {
            Destroy(drone.gameObject);
        }

        public void Spawn()
        {
            var amount = Random.Range(1, 10);

            for (int i = 0; i < amount; i++)
            {
                var drone = Pool.Get();
                
                drone.transform.position = Random.insideUnitSphere * 10;
            }
        }
    }
}