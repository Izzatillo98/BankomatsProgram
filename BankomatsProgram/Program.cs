using BankomatsProgram.BankomatsServices;

namespace BankomatsProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankomatService service = new BankomatService();
            service.UserInterfaceEnter();
        }
        
    }
}
