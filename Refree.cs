using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Driven___Assignment
{
    // Subscriber
    internal class Refree
    {
        public string?  Name  { get; set; }

        public void Look(object? sender, CustomEventArgs e)
        {

            Ball? ballSender = sender as Ball;
            
            Console.WriteLine($"{this}  is Looking...... to  this Location :  {ballSender?.Location} For This Ball :{ballSender}  ");
        }

        public override string ToString()
        => $" Refree :  {Name}";
    }
}
