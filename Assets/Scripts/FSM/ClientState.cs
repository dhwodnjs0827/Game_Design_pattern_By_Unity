using System;
using UnityEngine;

public class ClientState : MonoBehaviour
{
    private BikeController bikeController;

    [Obsolete("FindObjectOfType 호출로 인해 추후 변경해야 함. ")]
    private void Start()
    {
        bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Start Bike"))
        {
            bikeController.StartBike();
        }

        if (GUILayout.Button("Turn Left"))
        {
            bikeController.Turn(Direction.Left);
        }
        
        if (GUILayout.Button("Turn Right"))
        {
            bikeController.Turn(Direction.Right);
        }
        
        if (GUILayout.Button("Stop Bike"))
        {
            bikeController.StopBike();
        }
    }
}
