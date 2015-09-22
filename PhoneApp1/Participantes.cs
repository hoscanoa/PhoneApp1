using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PhoneApp1
{
    [Table]
    public class Participantes
    {
        [Column(IsPrimaryKey=true, IsDbGenerated=true)]
        public int idParticipante { get; set; }
        [Column]
        public string ApPaterno { get; set; }
        [Column]
        public string ApMaterno { get; set; }
        [Column]
        public string Nombres { get; set; }
        [Column]
        public string DNI { get; set; }
        [Column]
        public string Direccion { get; set; }
        [Column]
        public string Telefono { get; set; }
        [Column]
        public string Correo { get; set; }
        [Column]
        public string Genero { get; set; }
    }
}
