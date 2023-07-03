namespace ejerciciopseudcodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double radio = 1;
            Double altura = 0;
            Double generatriz = 0;
            #region Ridio ingresado
            do
            {
                Console.Write("Ingrese el radio del cono:");
                string strconsola = Console.ReadLine();
                if (double.TryParse(strconsola,out radio))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("el numero esta mal ingresado");
                }

            } while (true);
            #endregion
            #region Altura Ingresada
            do
            {
                Console.Write("Ingrese el la altura del cono:");
                string strconsola = Console.ReadLine();
                if (Double.TryParse(strconsola, out altura))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("el numero esta mal ingresado");
                }

            } while (true);
            #endregion
            #region Generatriz ingresada
            do
            {
                Console.Write("Ingrese la generatriz del cono:");
                string strconsola = Console.ReadLine();
                if (double.TryParse(strconsola, out generatriz))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("el numero esta mal ingresado");
                }

            } while (true);
            #endregion

           
            double pi = 3.14159265;
            Double Area = ValordelArea(radio, generatriz, pi);
            double volumen = ValordelVolumen(radio, altura, pi);

            Console.WriteLine($" El volumen del cono es: {volumen} ");
            Console.WriteLine($" El Area del cono es {Area }");
            Console.ReadKey();

        }

        private static double ValordelVolumen(double radio, double altura, double pi)
        {
            return (pi * Math.Pow(radio,2)  * altura) / 3;
            { }
        }

        private static double ValordelArea(double radio, double generatriz, double pi) => pi * radio * (radio + generatriz);

    }
}