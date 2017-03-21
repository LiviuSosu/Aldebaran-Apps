using RobotAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotQuiz.Helpers
{
    public static class CommandHelper
    {
        //private static RobotEntities db = new RobotEntities();
        public static string currentCommand;

        public static void SetCurrentCommand(string commandName)
        {
            currentCommand = commandName;
        }

        public static void UnsetCommands()
        {
            currentCommand = "unset";
        }
    }
}