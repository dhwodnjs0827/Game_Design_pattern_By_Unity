namespace CommandPattern
{
    public class TurnRight : Command
    {
        private BikeController controller;

        public TurnRight(BikeController controller)
        {
            this.controller = controller;
        }
        
        public override void Execute()
        {
            controller.Turn(BikeController.Direction.Right);
        }
    }
}