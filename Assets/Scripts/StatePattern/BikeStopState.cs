using UnityEngine;

namespace FSM
{
    public class BikeStopState : MonoBehaviour, IBikeState
    {
        private BikeController bikeController;

        public void Handle(BikeController controller)
        {
            if (!bikeController)
            {
                bikeController = controller;
            }

            bikeController.CurrentSpeed = 0;
        }
    }
}