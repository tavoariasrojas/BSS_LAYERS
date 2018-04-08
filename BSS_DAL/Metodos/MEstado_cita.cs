using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MEstado_cita : MConnection, IEstado_cita
    {
        public void ActualizarEstadoCita(Estado_cita estado)
        {
            _db.Update(estado);
        }

        public Estado_cita BuscarEstado(string cod_estado)
        {
            return _db.Select<Estado_cita>(x => x.cod_estado == cod_estado).FirstOrDefault();
        }

        public void EliminarEstadoCita(string cod_estado)
        {
            _db.Delete<Estado_cita>(x => x.cod_estado == cod_estado);
        }

        public void InsertarEstadoCita(Estado_cita estado)
        {
            _db.Insert(estado);
        }

        public List<Estado_cita> ListarEstadosCita()
        {
            return _db.Select<Estado_cita>();
        }
    }
}
