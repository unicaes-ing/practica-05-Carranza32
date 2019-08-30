using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica5MC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Escoja una opcion");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("5 - Ejercicio 5");
                Console.WriteLine("6 - Ejercicio 6");
                Console.WriteLine("0 - Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Ejercicio6();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Faltan {0} dias para terminar el anio", 365 - FuncionDias());
        }
        static int FuncionDias()
        {
            return DateTime.Now.DayOfYear;
        }

        private static void Ejercicio2()
        {
            Console.WriteLine("Ingrese un numero entero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PositivoNegativo(num));
        }
        static string PositivoNegativo(int numero)
        {
            if (numero > 0)
            {
                return "Positivo";
            }
            else if(numero == 0)
            {
                return "Cero";
            }
            else
            {
                return "Negativo";
            }
        }

        private static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un numero para sacar el factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Factorial de {0} es {1}", num, Factorial(num));
        }
        static int Factorial(int num)
        {
            int resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("Ingresa el telefono numero 1");
            string tel1 = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono numero 2");
            string tel2 = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono numero 3");
            string tel3 = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono numero 4");
            string tel4 = Console.ReadLine();

            Console.WriteLine("Ganador: {0}", NumerosAleatorios(tel1, tel2, tel3, tel4));
        }
        static string NumerosAleatorios(string tel1, string tel2, string tel3, string tel4)
        {
            Random random = new Random();
            int num = random.Next(1, 4);
            if (num == 1) return tel1;
            if (num == 2) return tel2;
            if (num == 3) return tel3;
            if (num == 4) return tel4;
            return "";
        }

        private static void Ejercicio5()
        {
            Console.WriteLine("Ingrese el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el descuento del producto");
            double descuento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Descuento: {0:N2}", Descuento(precio, descuento));
        }
        static double Descuento(double precio, double descuento)
        {
            return precio - (precio * descuento);
        }

        private static void Ejercicio6()
        {
            Console.WriteLine("Promedio: {0}", PromedioNotas(5.5, 4.6, 8.0, 9.5, 10.0));
        }
        static double PromedioNotas(params double[] notas)
        {
            double total = 0.0;
            foreach (var item in notas)
            {
                total += item;
            }
            return total / notas.Length;
        }
    }
}
