using CommandDesignPatternExample.Commands;
using System;
using System.Collections.Generic;

namespace CommandDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            Robot robot = new Robot();

            robot.X = 5;
            robot.Y = 5;

            List<ICommand> commands = new List<ICommand>();

            commands.Add(new MoveCommand(robot, Direction.Back));
            commands.Add(new MoveCommand(robot, Direction.Back));
            commands.Add(new MoveCommand(robot, Direction.Left));
            commands.Add(new MoveCommand(robot, Direction.Left));
            commands.Add(new MoveCommand(robot, Direction.Left));
            commands.Add(new GrabCommand(area, robot));
            
            // długi ciąg rozbudowanego i skompliowanego kodu
            //
            //
            //
            // 

            commands.ForEach(command => command.Execute());

            Console.WriteLine("Przedmiot trzymany w rękach przez robota: {0}", robot.ObjectInHands);
            Console.ReadKey();
        }
    }
}