namespace POO3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Automovil automovil1 = new Automovil("Chevrolet", "Aveo", 2002, 5);
            Console.WriteLine(automovil1.ToString());

            Camioneta camioneta1 = new Camioneta("Great Wall", "Wingle S", 2020, 2000);
            Console.WriteLine(camioneta1.ToString());
        }
    }
}