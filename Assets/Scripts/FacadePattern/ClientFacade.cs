using UnityEngine;

namespace FacadePattern
{
    public class ClientFacade : MonoBehaviour
    {
        private BikeEngine bikeEngine;

        private void Start()
        {
            bikeEngine = gameObject.AddComponent<BikeEngine>();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Turn On"))
            {
                bikeEngine.TurnOn();
            }
            
            if (GUILayout.Button("Turn Off"))
            {
                bikeEngine.TurnOff();
            }
            
            if (GUILayout.Button("Toggle Turbo"))
            {
                bikeEngine.ToggleTurbo();
            }
        }
    }
}