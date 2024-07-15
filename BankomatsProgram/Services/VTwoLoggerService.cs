using BankomatsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatsProgram.Services
{
    internal class VTwoLoggerService : ILoggerService
    { 
        public void Log(string message) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine(message);
        }
    

    }
}
