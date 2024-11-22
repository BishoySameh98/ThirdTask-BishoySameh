namespace _3rd_session
{
    class Player
    {
        
        

        public string  Name { set; get; }
        public int Health { set; get; }

        public double Experience { set; get; }

        //public void Shoot() {

        //    Console.WriteLine("Experience raised by 0.01");
        //    this.experience =+ 0.01;

        
        //}

        //public void Run()
        //{
        //    Console.WriteLine("Health reduced by 1");
        //    this.health =- 1;

        //}

        //public void Pass(Player player) {

        //    Console.WriteLine($"{this.GetName()} passed the ball to {player.GetName()}");
            
        //}

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player { Name = "Marmosh", Health = 100, Experience = 5 };
           


        }
    }
}
