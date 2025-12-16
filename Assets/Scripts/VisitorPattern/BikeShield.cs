using UnityEngine;

namespace VisitorPattern
{
    public class BikeShield : MonoBehaviour, IBikeElement
    {
        public float health = 50.0f;  // 퍼센트

        public float Damage(float amount)
        {
            health -= amount;
            return health;
        }
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        private void OnGUI()
        {
            GUI.color = Color.green;
            
            GUI.Label(new Rect(125, 0, 200, 20), "Shield Health: " + health);
        }
    }
}