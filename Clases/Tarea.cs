using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tarea
    {
        // Propiedades de la Tarea
        public int ID;
        public string Nombre;
        // 1=Alta, 2=Media, 3=Baja (La prioridad más alta tiene el valor más bajo)
        public int Prioridad;
        public DateTime FechaLimite;

        public Tarea(int id, string nombre, int prioridad, DateTime fechaLimite)
        {
            ID = id;
            Nombre = nombre;
            Prioridad = prioridad;
            FechaLimite = fechaLimite;
        }

        public override string ToString()
        {
            return $"[P{Prioridad}] ID:{ID} - {Nombre} (Límite: {FechaLimite:d})";
        }
    }
}
