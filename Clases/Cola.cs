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

        public void Encolar(string p)
        {
            //1. Crear nuevo nodo
            Nodo nuevo = new Nodo();
            nuevo.dato = p;

            //2. Ubicarlo
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else//PRIORIDAD=1 NO PRIORIDAD=0
            {
                if (p.prioridad == 0)
                { //que se encole al final 
                    final.sig = nuevo;
                    final = nuevo;
                }
                else //PRIORIDAD=1
                {
                    //LA COLA AUN NO TIENE PERSONAS CON PRIORIDAD 
                    if (frente.dato.prioridad == 0)
                    {
                        nuevo.sig = frente;
                        frente = nuevo;
                    }
                    //LA COLA TIENE AL NEMOS 1 PERSONA CON PRIORIDAD YA ENCOLADA 
                    else
                    {
                        Nodo temp = frente;
                        while (temp != null && temp.sig.dato.prioridad == 1)
                        {
                            temp = temp.sig;
                        }
                        //insertar el nuevo nodo
                        nuevo.sig = temp.sig;
                        temp.sig = nuevo;
                        // validar 
                    }
                }
            }
        }
        public Persona Desencolar()
        {
            if (frente != null)
            {
                Persona p = frente.dato;
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
