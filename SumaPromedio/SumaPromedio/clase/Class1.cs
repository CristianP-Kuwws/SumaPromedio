namespace SumaPromedio
{
    internal class Class1
    {
        public class SumaPromedio
        {
            public void CalcularSumaPromedio()
            {
                int num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                decimal suma = 0;
                decimal promedio = 0;

                try
                {
                    Console.WriteLine("Ingrese su primer numero aqui: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su segundo numero aqui: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su tercer numero aqui: ");
                    num3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su cuarto numero aqui: ");
                    num4 = int.Parse(Console.ReadLine());

                    suma = (num1 + num2 + num3 + num4);
                    promedio = (suma / 4);

                    Console.WriteLine($"La suma de sus cuatro numeros es: {suma}");
                    Console.WriteLine($"El promedio de sus cuatro numeros es: {promedio}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
                }

            }
        }
    }
}
