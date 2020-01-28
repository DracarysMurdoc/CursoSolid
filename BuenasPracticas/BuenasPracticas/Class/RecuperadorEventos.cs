using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenasPracticas.Interfaces;
using BuenasPracticas.DTO;

namespace BuenasPracticas.Class
{
    public class RecuperadorEventos : ILectorArchivo
    {
        private string _rutaArchivo;
        

        //public RecuperadorEventos(string url)
        //{
            
        //}

        public EventosDTO ObtenerRegistros(string url)
        {
            _rutaArchivo = url ?? throw new ArgumentNullException(nameof(url));
            StreamReader buffer = new StreamReader(_rutaArchivo);
            EventosDTO eventosDTO = new EventosDTO();
            string[] eventos;
            while( buffer.ReadLine() != null )
            {
                eventos = buffer.ReadLine().Split(',');
                eventosDTO.titulo = eventos[0];
                eventosDTO.fecha = DateTime.Parse(eventos[1]);
            }
            
            return eventosDTO;
            
        }
    }
}
