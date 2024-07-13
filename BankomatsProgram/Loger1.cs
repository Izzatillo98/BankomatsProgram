using System;

namespace BankomatsProgram
{
    class V1 : Loger
    {
        internal override void Login()
        {
            Login("Message");

            static void Login(string text)
            {
                Console.WriteLine(text);

            }
        }

    }
            
}
