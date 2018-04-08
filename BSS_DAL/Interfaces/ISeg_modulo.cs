using System.Collections.Generic;
using BSS_DATA;

namespace DAL
{
    public interface ISeg_modulo
    {
        List<Seg_modulo> ListarSegModulo();
        Seg_modulo BuscarSegModulo(string sm_codigo);
        void InsertarSegModulo(Seg_modulo sg_modulo);
        void ActualizarSegModulo(Seg_modulo sg_modulo);
        void EliminarSegModulo(string sm_codigo);
    }
}
