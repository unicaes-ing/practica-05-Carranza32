using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica5MC
{
    public class Program
    {
        #region atributos
        private static bool isNumber;
        #endregion

        static void Main(string[] args)
        {
            int opc = 0;
            bool isNumber;
            do
            {
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
                    isNumber = int.TryParse(Console.ReadLine(), out opc);
                } while (isNumber == false || opc < 0);
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
            int num = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero entero");
                isNumber = int.TryParse(Console.ReadLine(), out num);
            } while (isNumber == false);
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
            int num = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero para sacar el factorial");
                isNumber = int.TryParse(Console.ReadLine(), out num);
            } while (isNumber == false || num <= 0);
            
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
            string tel1, tel2, tel3, tel4;

            do
            {
                Console.WriteLine("Ingresa el telefono numero 1");
                tel1 = Console.ReadLine();
                Console.WriteLine("Ingresa el telefono numero 2");
                tel2 = Console.ReadLine();
                Console.WriteLine("Ingresa el telefono numero 3");
                tel3 = Console.ReadLine();
                Console.WriteLine("Ingresa el telefono numero 4");
                tel4 = Console.ReadLine();
            } while (string.IsNullOrEmpty(tel1) || string.IsNullOrEmpty(tel2) || string.IsNullOrEmpty(tel3) || string.IsNullOrEmpty(tel4));
            

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
            bool isDouble;
            double precio = 0.0, descuento = 0.0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el precio del producto");
                isNumber = double.TryParse(Console.ReadLine(), out precio);
                Console.WriteLine("Ingrese el descuento del producto");
                isDouble = double.TryParse(Console.ReadLine(), out descuento);
            } while (isNumber == false || isDouble == false);

            Console.WriteLine("Descuento: {0:N2}", Descuento(precio, descuento));
        }
        static double Descuento(double precio, double descuento)
        {
            return precio - (precio * descuento);
        }

        private static void Ejercicio6()
        {
            bool isNumber;
            int num;
            List<double> notas = new List<double>();
            double nota = 0.0;

            do
            {
                Console.WriteLine("Ingrese la cantidad de notas que ingresará");
                isNumber = int.TryParse(Console.ReadLine(), out num);
            } while (isNumber == false || num <= 0);

            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese la nota {0}", i+1);
                    isNumber = double.TryParse(Console.ReadLine(), out nota);
                } while (isNumber == false || nota < 0);
                notas.Add(nota);
            }
            Console.WriteLine("Promedio: {0}", PromedioNotas(notas));
        }
        static double PromedioNotas(List<double> notas)
        {
            double total = 0.0;
            foreach (var item in notas)
            {
                total += item;
            }
            return total / notas.Count;
        }
    }
}
