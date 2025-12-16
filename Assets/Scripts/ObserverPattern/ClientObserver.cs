using System;
using UnityEngine;

namespace ObserverPattern
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeController bikeController;

        [Obsolete("FindObjectOfType 호출로 인해 추후 변경해야 함.")]
        private void Start()
        {
            bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Damage Bike"))
            {
                if (bikeController)
                {
                    bikeController.TakeDamage(15.0f);
                }
            }
            
            if (GUILayout.Button("Toggle Turbo"))
            {
                if (bikeController)
                {
                    bikeController.ToggleTurboOn();
                }
            }
        }
    }
}