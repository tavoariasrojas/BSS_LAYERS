using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSS_DATA;
using DAL.Interfaces;
using DAL.Metodos;
using ServiceStack.OrmLite;

namespace DAL.Metodos
{
    public class MUnidad_medida : MConnection, IUnidad_medida
    {
        public Unidad_medida BuscarUnidad(long codigo)
        {
            return _db.Select<Unidad_medida>(x => x.um_codigo == codigo).FirstOrDefault();
        }

        public List<Unidad_medida> ListarUnidadMedidas()
        {
            return _db.Select<Unidad_medida>();
        }
    }
}
