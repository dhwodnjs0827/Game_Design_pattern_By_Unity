using System;
using UnityEngine;

namespace DecoratorPattern
{
    public class ClientDecorator : MonoBehaviour
    {
        private BikeWeapon bikeWeapon;
        private bool isWeaponDecorated;

        [Obsolete("FindObjectOfType 호출로 인해 추후 변경해야 함.")]
        private void Start()
        {
            bikeWeapon = (BikeWeapon)FindObjectOfType(typeof(BikeWeapon));
        }

        private void OnGUI()
        {
            if (!isWeaponDecorated)
            {
                if (GUILayout.Button("Decorate Weapon"))
                {
                    bikeWeapon.Decorate();
                    isWeaponDecorated = !isWeaponDecorated;
                }
            }

            if (isWeaponDecorated)
            {
                if (GUILayout.Button("Reset Weapon"))
                {
                    bikeWeapon.Reset();
                    isWeaponDecorated = !isWeaponDecorated;
                }
            }
            
            if (GUILayout.Button("Toggle Fire"))
            {
                bikeWeapon.ToggleFire();
            }
        }
    }
}