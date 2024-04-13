using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_SOBRECARGA
{
    internal class Equipo
    {
        public Equipo(string nombre, DateTime fundacion, int campeonatos, int seguidores)
        {
            this.nombre = nombre;
            this.fundacion = fundacion;
            this.campeonatos = campeonatos;
            this.seguidores = seguidores;
        }

        public string nombre { get; set; }
        public DateTime fundacion { get; set; }
        public int campeonatos { get; set; }
        public int seguidores { get; set; }



        public static bool operator <(Equipo a, Equipo b) => a.seguidores < b.seguidores;

        public static bool operator >(Equipo a, Equipo b) => a.seguidores > b.seguidores;

        public override string ToString()
        {
            return String.Format($" {nombre} , fundacion {fundacion.Year} , campeonatos {campeonatos}, seguidores {seguidores}");
        }

        

      
    } 
    
}
