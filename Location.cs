using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Driven___Assignment
{
    struct Location : IEquatable<Location>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public override string ToString()
        {
            return  $" ({X} , {Y} ,  {Z} ) ";
        }
        public bool Equals(Location other)
        
            => this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z);
        
    }
}
