using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        private static List<Bebida> bebidas = new List<Bebida>();
        public void agregarBebidas(Bebida bebida)
        {
            bebidas.Add(bebida);
        }

        public void eliminar(string codigo)
        {
            Bebida eliminado = bebidas.Find(b => b.Codigo == codigo);
            bebidas.Remove(eliminado);
        }

        public List<Bebida> ObtenerBebidas()
        {
            return bebidas;
        }
    }
}
