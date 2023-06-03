using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Clase3
{
    internal class Program
    {
        public static float[] notas = new float[3];
        public static string[] estudiantes = new string[3];
        static void Main(string[] args)  // LOS METODOS UTILIZAN LA PALABRA RESERVADA VOID
        {
            menu();
        }

        private static void menu()
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("a-Ingresar notas");
                Console.WriteLine("b-Consultar notas");
                Console.WriteLine("c-modificar notas");
                Console.WriteLine("d-Reporte");
                Console.WriteLine("e-Salir");
                Console.Write("Digite una opcion: "); 
                //El metodo tolower es para convertir una cadena de caracteres a minuscula
                //El metodo toupper es para convertir una cadena de caracteres a mayuscula
                op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "a": Ingresarnotas(); break;
                    case "b": Consulta(); break;
                    case "c": Modificar(); break;
                    case "d": Reporte(); break;
                    case "e": break;
                    default:
                        Console.WriteLine("Opcion no es valida!!");
                        break;
                }
            } while (!op.Equals("e"));
        }

        public static void Reporte()
        {
            Console.Clear();
            Console.WriteLine("********** Reporte de Estudiantes*************");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Nombre: {estudiantes[i]} Nota: {notas[i]}");
            }
            Console.WriteLine("********** Fin del reporte*************");
            Console.ReadLine();
        }

        public static void Modificar()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de estudiante");
            nombEstudiante = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    Console.Clear();
                    Console.Write("Actualice el nombre:");
                    estudiantes[i] = Console.ReadLine();
                    Console.Write("Actualice la nota :");
                    notas[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe");
            }
        }

            public static void Consulta()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de estudiante");
            nombEstudiante= Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                { 
                    Console.Clear();
                    
                    Console.WriteLine("La nota de estudiante es: " + notas[i]);
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe");
            }

            Console.Read();

        }
        public static void Ingresarnotas()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite el nombre:");
                estudiantes[i] = Console.ReadLine();
                Console.Write("Digite la nota :");
                notas[i] = float.Parse(Console.ReadLine());           
            }
        }
        
    }
}
