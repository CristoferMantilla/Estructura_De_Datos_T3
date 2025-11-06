using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public NodoArbol raiz_principal = null;

        private void insertar(ref NodoArbol raiz, Tarea d)
        {
            if (raiz == null)
            {
                NodoArbol nuevo = new NodoArbol();
                nuevo.dato = d;

                raiz = nuevo;
                Console.WriteLine($"Vehiculo con placa nr {d.Prioridad} registrado correctamente!");
            }
            else
            {
                if (d.Prioridad < raiz.dato.Prioridad)
                {
                    insertar(ref raiz.izq, d);
                }
                else if (d.Prioridad > raiz.dato.Prioridad)
                {
                    insertar(ref raiz.der, d);
                }
                else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void Insertar(Tarea d)
        {
            insertar(ref raiz_principal, d);
        }

        private void dibujar(NodoArbol raiz, int nivel)
        {
            //D-R-I
            if (raiz != null)
            {
                dibujar(raiz.der, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(raiz.dato);
                dibujar(raiz.izq, nivel + 1);
            }
        }
        public void Dibujar()
        {
            dibujar(raiz_principal, 0);
        }
        private void inOrden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                inOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                Console.WriteLine("----------------------------------");
                inOrden(raiz.der);
            }
        }
        public void InOrden()
        {
            inOrden(raiz_principal);
        }

        private void buscar(NodoArbol raiz, int placa)
        {
            if (raiz == null)
            {
                Console.WriteLine("Vehiculo no existe en los registros");
            }
            else
            {
                if (placa < raiz.dato.Prioridad)
                {
                    buscar(raiz.izq, placa);
                }
                else if (placa > raiz.dato.Prioridad)
                {
                    buscar(raiz.der, placa);
                }
                else
                {
                    Console.WriteLine("Vehiculo encontrado");
                    Console.WriteLine(raiz.dato);
                }
            }
        }
        public void Buscar(int d)
        {
            buscar(raiz_principal, d);
        }
        private void eliminar(ref NodoArbol raiz, int placa)
        {
            if (raiz == null)
            {
                Console.WriteLine("Vehiculo no existe en los registros");
            }
            else
            {
                if (placa < raiz.dato.Prioridad)
                {
                    eliminar(ref raiz.izq, placa);
                }
                else if (placa > raiz.dato.Prioridad)
                {
                    eliminar(ref raiz.der, placa);
                }
                else
                {
                    if (raiz.izq == null && raiz.der == null)
                    {
                        raiz = null;
                    }
                    else
                    {
                        //des. izq
                        if (raiz.izq != null)
                        {
                            NodoArbol temp = BuscarMayor(raiz.izq);

                            Tarea aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.izq, placa);
                        }
                        else
                        {
                            //des. der
                            NodoArbol temp = BuscarMenor(raiz.der);

                            Tarea aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.der, placa);
                        }
                    }
                }
            }
        }
        public void Eliminar(int d)
        {
            eliminar(ref raiz_principal, d);
        }
        private NodoArbol BuscarMenor(NodoArbol raiz)
        {
            if (raiz.izq != null)
            {

                return BuscarMenor(raiz.izq);
            }
            else
            {
                return raiz;
            }
        }
        private NodoArbol BuscarMayor(NodoArbol raiz)
        {
            if (raiz.der != null)
            {

                return BuscarMayor(raiz.der);
            }
            else
            {
                return raiz;
            }
        }
    }
}
