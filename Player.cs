using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Driven___Assignment
{

    // Subscriber 
    internal class Player
    {

        public string? Name  { get; set; }
        public string? Team  { get; set; }

        public void  Run(object? sender, CustomEventArgs e)
        {

            Ball ? ballSender = sender as Ball;  
            Console.WriteLine($"{this/*.ToString()*/} is Running ....... Towrard this Location : {ballSender?.Location} For This Ball :{ballSender} ");
        }
        public override string ToString()
        => $"Player {Name}  in Team :{Team}";
    }
}
