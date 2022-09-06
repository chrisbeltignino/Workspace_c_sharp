using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int antiguedadAnios;
            string nombre = "";
            int cantidadHoras;
            float valorHoras;
            string respuesta;
            float importeBruto;
            float importeNeto;
            float descuentos;

            do
            {
                Console.WriteLine("Ingrese valor por hora: ");

                respuesta = Console.ReadLine();

                while (float.TryParse(respuesta, out valorHoras) == false)
                {
                    Console.WriteLine("ERROR, Ingrese un valor válido: ");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese el nombre del empleado: ");

                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad (AÑOS): ");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out antiguedadAnios) == false)
                {
                    Console.WriteLine("ERROR, Ingrese una cantidad válida de años de antiguedad: ");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out cantidadHoras) == false)
                {
                    Console.WriteLine("ERROR, Ingrese una cantidad válida de horas trabajadas: ");

                    respuesta = Console.ReadLine();
                }

                importeBruto = cantidadHoras * valorHoras;

                importeBruto = importeBruto + (antiguedadAnios * 150);

                descuentos = importeBruto * 13 / 100;

                importeNeto = importeBruto - descuentos;

                Console.WriteLine("---------------RECIBO DE SUELDO----------------");
                Console.WriteLine("|NOMBRE: {0}", nombre);
                Console.WriteLine("--------------------VALORES--------------------");
                Console.WriteLine("|ANTIGUEDAD: {0} AÑOS", antiguedadAnios);
                Console.WriteLine("|VALOR POR HORA: ${0}", valorHoras);
                Console.WriteLine("|TOTAL EN BRUTO: ${0}", importeBruto);
                Console.WriteLine("|TOTAL NETO: ${0}", importeNeto);
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("\nDesea volver a iterar señor usuario? 'si' para seguir");

                respuesta = Console.ReadLine();


            } while (respuesta == "si");
        }
    }
}
