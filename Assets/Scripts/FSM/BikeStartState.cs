using UnityEngine;

public class BikeStartState : MonoBehaviour, IBikeState
{
    private BikeController bikeController;

    public void Handle(BikeController controller)
    {
        if (!bikeController)
        {
            bikeController = controller;
        }

        bikeController.CurrentSpeed = bikeController.maxSpeed;
    }

    private void Update()
    {
        if (bikeController)
        {
            if (bikeController.CurrentSpeed > 0)
            {
                bikeController.transform.Translate(Vector3.forward * (bikeController.CurrentSpeed * Time.deltaTime));
            }
        }
    }
}