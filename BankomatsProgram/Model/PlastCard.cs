using System;

namespace BankomatsProgram.Model
{
    public class PlastCard
    {
       public Guid Id {  get; set; }
       public string PlastCardName { get; set; }
       public string PlastCardPassword { get; set; } = "0000";
       public decimal PlastCardBalance { get; set; } = 10000;
    }
}
