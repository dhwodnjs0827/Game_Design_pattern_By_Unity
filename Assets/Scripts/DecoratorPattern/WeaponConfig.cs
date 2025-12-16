using UnityEngine;

namespace DecoratorPattern
{
    [CreateAssetMenu(fileName = "NewWeaponConfig", menuName = "Weapon/Config", order = 1)]
    public class WeaponConfig : ScriptableObject, IWeapon
    {
        [Range(0, 60)] [Tooltip("Rate of firing per second")] [SerializeField]
        private float rate;

        [Range(0, 50)] [Tooltip("Weapon range")] [SerializeField]
        private float range;
        
        [Range(0, 100)] [Tooltip("Weapon strength")] [SerializeField]
        private float strength;
        
        [Range(0, 5)] [Tooltip("Cooldown duration")] [SerializeField]
        private float cooldown;

        public string weaponName;
        public GameObject weaponPrefab;
        public string weaponDescription;
        
        public float Range => range;
        public float Rate => rate;
        public float Strength => strength;
        public float Cooldown => cooldown;
    }
}