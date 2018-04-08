using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;
using System;

namespace DAL.Metodos
{
    public class MCitas_clientes : MConnection, ICitas_clientes
    {
        public void ActualizarCita(Citas_clientes citas_cliente)
        {
            _db.Update(citas_cliente);
        }

        public Citas_clientes BuscarCitas(int cc_id)
        {
            return _db.Select<Citas_clientes>(x => x.cc_id == cc_id).FirstOrDefault();
        }

        public void EliminarCita(int cc_id)
        {
            _db.Delete<Citas_clientes>(x => x.cc_id == cc_id);
        }

        public void InsertarCita(Citas_clientes citas_cliente)
        {
            _db.Insert(citas_cliente);
        }

        public List<Citas_clientes> ListarCitas()
        {
            return _db.Select<Citas_clientes>();
        }
    }
}
