using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenasPracticas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, i = 0;
            string eventos;
            string src = @"C:\Users\juan.pech\source\repos\BuenasPracticas\Eventos.txt";
            string[] evento = { };
            DateTime fecha;
            StreamReader buffer = new StreamReader(src);

            while ((eventos = buffer.ReadLine()) != null)
            {
                evento = eventos.Split(',');

                fecha = DateTime.Parse(evento[1]);

                var result = fecha.CompareTo(DateTime.Today);

                Console.WriteLine();
                
                contador++; i=0;
            }
            buffer.Close();
            Console.Read();


        }
    }
}
