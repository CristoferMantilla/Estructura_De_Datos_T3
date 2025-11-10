using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaDoble
    {

        public Nodo primero = null;
        public Nodo ultimo = null;

        public void Insertar(Tarea d)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = d;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.sig = nuevo;
                nuevo.ant = ultimo;
                ultimo = nuevo;
            }
        }
        public void mostrar_PU()
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.Write(temp.dato + " ");
                temp = temp.sig;
            }
        }
        public void mostrar_UP()
        {
            Nodo temp = ultimo;
            while (temp != null)
            {
                Console.Write(temp.dato + " ");
                temp = temp.ant;
            }
        }
        public void eliminar(Tarea elim)
        {
            Nodo temp = primero;

            while (temp != null)
            {
                if (temp.dato == elim)
                {
                    // Caso 1: único elemento en la lista
                    if (temp == primero && temp == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                        return;
                    }

                    // Caso 2: eliminar el primero (hay más elementos)
                    if (temp == primero)
                    {
                        primero = primero.sig;
                        // validar que primero no sea null antes de acceder a ant
                        if (primero != null)
                        {
                            primero.ant = null;
                        }
                        return;
                    }

                    // Caso 3: eliminar el último (hay más elementos)
                    if (temp == ultimo)
                    {
                        ultimo = ultimo.ant;
                        // validar que último no sea null antes de acceder a sig
                        if (ultimo != null)
                        {
                            ultimo.sig = null;
                        }
                        return;
                    }

                    // Caso 4: eliminar en medio (enlaces cruzados correctos)
                    // enlazar el anterior con el siguiente
                    temp.ant.sig = temp.sig;
                    temp.sig.ant = temp.ant;
                    return;
                }

                temp = temp.sig;
            }

            // Si terminó el while y no encontró
            Console.WriteLine("No se encontró la tarea a eliminar.");
        }
    }
}

