using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenasPracticas.Class;
using BuenasPracticas.Interfaces;

namespace BuenasPracticas
{
    public class Program
    {
        private readonly ILectorArchivo _lector;

        public Program(ILectorArchivo lector)
        {
            _lector = lector ?? throw new ArgumentNullException(nameof(lector));
        }
        
        static void Main(string[] args)
        {
            string url = @"C:\Users\juan.pech\Documents\GitHub\CursoSolid\BuenasPracticas\Eventos.txt";
            var dataset = _lector.ObtenerRegistros(url);

        }
    }
}
