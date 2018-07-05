namespace CommandDesignPatternExample.Commands
{
    public class MoveCommand : ICommand
    {
        private Robot Robot { get; set; }
        private Direction Direction { get; set; }

        public MoveCommand(Robot robot, Direction direction)
        {
            Robot = robot;
            Direction = direction;
        }

        public void Execute()
        {
            if (Direction == Direction.Left)
            {
                Robot.X -= 1;
            }
            else if (Direction == Direction.Right)
            {
                Robot.X += 1;
            }
            else if (Direction == Direction.Front)
            {
                Robot.Y += 1;
            }
            else if (Direction == Direction.Back)
            {
                Robot.Y -= 1;
            }
        }
    }
}