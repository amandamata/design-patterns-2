﻿using System.Collections.Generic;

namespace DesignPatterns2.command
{
    public class Queue
    {
        private IList<ICommand> Commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void Process()
        {
            foreach (ICommand command in Commands)
            {
                command.Execute();
            }
        }
    }
}
