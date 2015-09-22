using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PhoneApp1
{
    public class MyDataContext:DataContext
    {
        public static string cadena = "Data Source=isostore:/Eventos.sdf";
        public Table<Usuarios> listaUsuarios;
        public Table<Participantes> listaParticipantes;
        public MyDataContext(string cadenaConexion):
            base(cadenaConexion)
        {

        }
    }
}
