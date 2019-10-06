﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IBebidasDAL
    {
        List<Bebida> ObtenerBebidas();
        void agregarBebidas(Bebida bebida);
        void eliminar(string codigo);
    }
}