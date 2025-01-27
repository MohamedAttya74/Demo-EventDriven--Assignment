using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Driven___Assignment
{

    // Publisher
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location
        {
            get => location;
            set
            {
                if(!value.Equals(location))      //     Boxing   علشان ميحصلش  Implement to  IEquatable<Location>  عملت 
                    location = value;
                //LocationChanged?.Invoke(location);   // Fire Event
                on_LocationChanged(); // Fire Event
            }
        }
        public event EventHandler<CustomEventArgs>? LocationChanged;
        //public event Action<Location>? LocationChanged;   //Delegate Referance دا عباره عن   //  event : ممكن اشيلها وممكن احطها  
        protected void on_LocationChanged()
        {
            LocationChanged?.Invoke(this , new CustomEventArgs(){ Message = "Hello" });

        }
        public override string ToString()
        => $" Id :  {Id}";

    }


    
}


// Event Handler    اسمها  Event لل  Spicial Delegate   احنا بنستخد ال   Event   مع ال   Three Built-in Delegate  احنا مش بنستخدم اي حاجه من ال 
//    Publisher  لو كان عندي اكتر من   Publisher  هستفيد منه اني هعرف مين ال 

/*
 
 
 public int Id { get; set; }
        private Location location;
        public Location Location
        {
            get => location;
            set
            {
                if(!value.Equals(location))      //     Boxing   علشان ميحصلش  Implement to  IEquatable<Location>  عملت 
                    location = value;
                //LocationChanged?.Invoke(location);   // Fire Event
                on_LocationChanged(location);
            }
        }
        public event Action<Location>? LocationChanged;
        //public event Action<Location>? LocationChanged;   //Delegate Referance دا عباره عن   //  event : ممكن اشيلها وممكن احطها  
        protected void on_LocationChanged(Location NewLocation)
        {
            LocationChanged?.Invoke(NewLocation);

        }
 
 
 */