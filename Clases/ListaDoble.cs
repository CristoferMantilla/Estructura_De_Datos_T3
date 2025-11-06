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

            public void Insertar(string d)
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
            public void eliminar(string elim)
            {
                Nodo temp = primero;
                while (temp != null)
                {
                    if (temp.dato == elim)
                    {
                        if (temp == primero)
                        {
                            primero = primero.sig;
                            primero.ant = null;
                        }
                        else if (temp == ultimo)
                        {
                            ultimo = ultimo.ant;
                            ultimo.sig = null;
                        }
                        else
                        {
                            temp.ant.sig = temp.sig;
                            temp.sig = temp.ant;
                        }
                        return;
                    }
                    temp = temp.sig;
                }
                Console.Write("ERROR");
            }
        }
    }

