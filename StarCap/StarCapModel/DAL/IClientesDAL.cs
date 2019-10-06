using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IClientesDAL
    {
        List<Cliente> Obtener();
        void Agregar(Cliente cliente);
        //TODO: MAS ADLENTA SETO VA ELIMIANR DE LA bd
        //POR LO CUAL DEBERIA RECIBIR PK
        void Eliminar(string rut);
    }
}
