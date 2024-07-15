using BankomatsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatsProgram.Services
{
    internal class VOneLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.WriteLine(message);
        }
    }
}
