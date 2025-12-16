using UnityEngine;

public class BikeTurnState : MonoBehaviour, IBikeState
{
    private Vector3 turnDirection;
    private BikeController bikeController;
    
    public void Handle(BikeController controller)
    {
        if (!bikeController)
        {
            bikeController = controller;
        }

        turnDirection.x = (float)bikeController.CurrentTurnDirection;

        if (bikeController.CurrentSpeed > 0)
        {
            transform.Translate(turnDirection * bikeController.turnDistance);
        }
    }
}