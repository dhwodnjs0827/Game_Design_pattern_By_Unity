namespace CommandPattern
{
    public class ToggleTurbo : Command
    {
        private BikeController controller;

        public ToggleTurbo(BikeController controller)
        {
            this.controller = controller;
        }
        
        public override void Execute()
        {
            controller.ToggleTurbo();
        }
    }
}