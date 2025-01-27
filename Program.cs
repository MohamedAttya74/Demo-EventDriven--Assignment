namespace Demo_Event_Driven___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        Ball ball01 = new Ball() {  Id=11111};
        Ball ball02 = new Ball() { Id = 22222 };

            Player P11 = new Player() { Name="Pedri" , Team ="Barcaa" };
            Player P21 = new Player() { Name="Yamal" , Team ="Barcaa" };

            Player P12 = new Player() { Name="Vinii" , Team ="Madrid" };
            Player P22 = new Player() { Name="Rodri" , Team = "Madrid" };

            Refree refree = new Refree() {  Name= "Greshaa" };


            // Subscribtion [Regestration]
            ball01.LocationChanged += P11.Run;      /* "Pedri"   */   ball02.LocationChanged += P11.Run;    
            ball01.LocationChanged += P21.Run;      /* "Yamal"   */   ball02.LocationChanged += P21.Run;    
            ball01.LocationChanged += P12.Run;      /* "Vinii"   */   ball02.LocationChanged += P12.Run;    
            ball01.LocationChanged += P22.Run;      /* "Rodri"   */   ball02.LocationChanged += P22.Run;    
            ball01.LocationChanged += refree.Look;  /* "Greshaa" */   ball02.LocationChanged += refree.Look;

            //ball01.LocationChanged += (NewLocation) => Console.WriteLine("Extra Work "); 
            Console.WriteLine("******* Match Is Started Now *******");
            ball01.Location = new Location() { X = 10, Y = 20, Z = 30 };
           
            Console.WriteLine("--------  Vinii Is FIRED Now  :(  --------");
            // UnSubscribtion
            ball01.LocationChanged -= P12.Run;
            ball01.Location = new Location() { X = 90, Y = 20, Z = 30 };
            //ball02.Location = new Location() { X = 90, Y = 20, Z = 30 };

            //ball.LocationChanged.invok(new Location());  // Invalid 
        }
    }
}
