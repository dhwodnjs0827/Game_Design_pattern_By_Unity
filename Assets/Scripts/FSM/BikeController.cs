using UnityEngine;

namespace FSM
{
    public class BikeController : MonoBehaviour
    {
        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;

        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection { get; private set; }

        private IBikeState startState, stopState, turnState;

        private BikeStateContext bikeStateContext;

        private void Start()
        {
            bikeStateContext = new BikeStateContext(this);

            startState = gameObject.AddComponent<BikeStartState>();
            stopState = gameObject.AddComponent<BikeStopState>();
            turnState = gameObject.AddComponent<BikeTurnState>();

            bikeStateContext.Transition(stopState);
        }

        public void StartBike()
        {
            bikeStateContext.Transition(startState);
        }

        public void StopBike()
        {
            bikeStateContext.Transition(stopState);
        }

        public void Turn(Direction direction)
        {
            CurrentTurnDirection = direction;
            bikeStateContext.Transition(turnState);
        }
    }

    public enum Direction
    {
        Left = -1,
        Right = 1,
    }
}