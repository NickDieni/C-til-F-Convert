namespace C_til_f
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[C] Celsius til Fahrenheit   [F] Fahrenheit til Celsius");
            string tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
            if (tast == "c")
            {
                Console.Clear();
                Console.Write("Indtast Celsius: ");
                int Cel = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                double Celresultat = Cel * 1.8 + 32;
                Console.WriteLine($"Dit resultat er {Celresultat}, tryk and tast for at starte om");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }
            else if (tast == "f")
            {
                Console.Clear();
                Console.Write("Indtast Fehrenheit: ");
                int Feh = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                    
                double Fehresultat = (Feh - 32) * .5556;
                string Bo = Fehresultat.ToString("N0");
                Console.WriteLine($"Dit resultat er {Bo}, tryk and tast for at starte om");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }
            else
            {
                Main(args);
            }
        }

    }
}
