using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cola
    {
        public Nodo frente = null;
        public Nodo final = null;

        public void Encolar(Tarea p)
        {
            // 1. Crear el nuevo nodo
            Nodo nuevo = new Nodo();
            nuevo.dato = p;
            nuevo.sig = null; // Es buena práctica inicializarlo en null

            // -----------------------------------------------------------------
            // CASO 1: La cola está vacía
            // -----------------------------------------------------------------
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
                return; // Salir del método, ya terminamos
            }

            // -----------------------------------------------------------------
            // CASO 2: El nuevo nodo tiene MÁS prioridad (un número MENOR) que el 'frente'
            // Debe ir al inicio de la cola.
            // -----------------------------------------------------------------
            if (p.Prioridad < frente.dato.Prioridad)
            {
                nuevo.sig = frente; // El nuevo apunta al antiguo 'frente'
                frente = nuevo;     // El 'frente' ahora es el nuevo nodo
                return; // Salir del método
            }

            // -----------------------------------------------------------------
            // CASO 3: Insertar en el medio o al final
            // Buscamos el lugar correcto para insertar.
            // -----------------------------------------------------------------

            // 'temp' recorrerá la lista. Inicia en 'frente'.
            Nodo temp = frente;

            // Avanzamos 'temp' MIENTRAS el siguiente nodo exista Y
            // la prioridad del siguiente nodo sea MENOR O IGUAL a la del nuevo.
            // Esto asegura que nos detenemos JUSTO ANTES de un nodo con prioridad MAYOR
            // o al final de la lista.
            while (temp.sig != null && temp.sig.dato.Prioridad <= p.Prioridad)
            {
                temp = temp.sig;
            }

            // Ahora 'temp' es el nodo *anterior* al punto de inserción.

            // Insertamos el 'nuevo' nodo después de 'temp'
            nuevo.sig = temp.sig;
            temp.sig = nuevo;

            // -----------------------------------------------------------------
            // CASO 4: Actualizar el puntero 'final'
            // Si 'nuevo.sig' es null, significa que lo insertamos al final.
            // Por lo tanto, 'nuevo' es el nuevo 'final'.
            // -----------------------------------------------------------------
            if (nuevo.sig == null)
            {
                final = nuevo;
            }
        }
        public Tarea Desencolar()
        {
            if (frente != null)
            {
                Tarea p = frente.dato;
                frente = frente.sig;
                return p;
            }
            else
            {
                return null;
            }
        }

    }
}
