using UnityEngine;

namespace VisitorPattern
{
    public class ClientVisitor : MonoBehaviour
    {
        public PowerUp enginePowerUp;
        public PowerUp shieldPowerUp;
        public PowerUp weaponPowerUp;
        
        private BikeController bikeController;

        private void Start()
        {
            bikeController = gameObject.AddComponent<BikeController>();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("PowerUp Shield"))
            {
                bikeController.Accept(shieldPowerUp);
            }
            
            if (GUILayout.Button("PowerUp Engine"))
            {
                bikeController.Accept(enginePowerUp);
            }
            
            if (GUILayout.Button("PowerUp Weapon"))
            {
                bikeController.Accept(weaponPowerUp);
            }
        }
    }
}