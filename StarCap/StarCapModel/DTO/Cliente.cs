using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private int nivel;
        private Bebida bebidaFavorita;

        public string NivelTxt
        {
            get
            {
                string nivelTxt = "";
                switch (nivel)
                {
                    case 1 : nivelTxt = "Silver";
                        break;
                    case 2: nivelTxt = "Gold";
                        break;
                    case 3: nivelTxt = "Platinum";
                        break;
                    default:
                        break;
                }
                return nivelTxt;
            }
        }
        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public Bebida BebidaFavorita
        {
            get
            {
                return bebidaFavorita;
            }

            set
            {
                bebidaFavorita = value;
            }
        }
    }
}
