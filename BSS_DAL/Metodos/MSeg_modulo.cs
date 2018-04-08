using System.Collections.Generic;
using BSS_DATA;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_modulo : MConnection, ISeg_modulo
    {
        public void ActualizarSegModulo(Seg_modulo sg_modulo)
        {
            _db.Update(sg_modulo);
        }

        public Seg_modulo BuscarSegModulo(string sm_codigo)
        {
            return _db.Select<Seg_modulo>(x => x.sm_codigo == sm_codigo).FirstOrDefault();
        }

        public void EliminarSegModulo(string sm_codigo)
        {
            _db.Delete<Seg_modulo>(x => x.sm_codigo == sm_codigo);
        }

        public void InsertarSegModulo(Seg_modulo sg_modulo)
        {
            _db.Insert(sg_modulo);
        }

        public List<Seg_modulo> ListarSegModulo()
        {
            return _db.Select<Seg_modulo>();
        }
    }
}
