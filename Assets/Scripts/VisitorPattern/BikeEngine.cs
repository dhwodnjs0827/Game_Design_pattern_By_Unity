using UnityEngine;

namespace VisitorPattern
{
    public class BikeEngine : MonoBehaviour, IBikeElement
    {
        public float turboBoost = 25.0f;  // mph
        public float maxTurboBoost = 200.0f;

        private bool isTurboOn;
        private float defaultSpeed = 300.0f;  // mph

        public float CurrentSpeed
        {
            get
            {
                if (isTurboOn)
                {
                    return defaultSpeed + turboBoost;
                }
                return defaultSpeed;
            }
        }

        public void ToggleTurbo()
        {
            isTurboOn = !isTurboOn;
        }
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        private void OnGUI()
        {
            GUI.color = Color.green;
            
            GUI.Label(new Rect(125, 20, 200, 20), "Turbo Boost: " + turboBoost);
        }
    }
}