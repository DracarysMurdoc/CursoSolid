using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenasPracticas.DTO;

namespace BuenasPracticas.Interfaces
{
    public interface ILectorArchivo
    {
        EventosDTO ObtenerRegistros(string url);

        
    }
}
