namespace CommandDesignPatternExample.Commands
{
    public class GrabCommand : ICommand
    {
        private Robot Robot { get; set; }
        private Area Area { get; set; }

        public GrabCommand(Area area, Robot robot)
        {
            Area = area;
            Robot = robot;
        }

        public void Execute()
        {
            Robot.ObjectInHands = Area.Fields[Robot.X][Robot.Y];
        }
    }
}