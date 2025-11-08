using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_De_Datos_T3
{
    public partial class Form1 : Form
    {
        ListaDoble lista = new ListaDoble();
        Cola cola = new Cola();
        Arbol arbol = new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            int prioridad = int.Parse(cmbPrioridad.SelectedItem.ToString());
            DateTime fecha = dtpFecha.Value;

            Tarea t = new Tarea(id, nombre, prioridad, fecha);

            // Insertar en estructuras
            lista.Insertar(t);
            cola.Encolar(t);
            arbol.Insertar(t);

            MessageBox.Show("Tarea agregada correctamente");

            MostrarLista();
            MostrarCola();
        }

        //BOTON EJECUTAR
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Tarea t = cola.Desencolar();
            if (t != null)
            {
                MessageBox.Show("Ejecutando: " + t.Nombre);

                // Marcar como completada en la lista
                t.Nombre = t.Nombre + " (Completada)";

                // Eliminar del árbol según prioridad
                arbol.Eliminar(t.Prioridad);

                MostrarLista();
                MostrarCola();
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes");
            }
        }

        //BOTON CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarLista();
            MostrarCola();
        }

        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            Nodo temp = lista.primero;
            while (temp != null)
            {
                if (temp.dato.ID == id)
                {
                    // Eliminar de lista
                    lista.eliminar(temp.dato);

                    // Eliminar del árbol
                    arbol.Eliminar(temp.dato.Prioridad);

                    // Reconstruir cola sin esa tarea
                    Cola nueva = new Cola();
                    Nodo c = cola.frente;
                    while (c != null)
                    {
                        if (c.dato.ID != id)
                        {
                            nueva.Encolar(c.dato);
                        }
                        c = c.sig;
                    }
                    cola = nueva;

                    MessageBox.Show("Tarea eliminada");
                    break;
                }
                temp = temp.sig;
            }
            MostrarLista();
            MostrarCola();
        }

        //METODOS AUXILIARES PARA REFRESCAR EL INTERFAZ
        private void MostrarLista()
        {
            lstLista.Items.Clear();
            Nodo temp = lista.primero;
            while (temp != null)
            {
                lstLista.Items.Add(temp.dato.ToString());
                temp = temp.sig;
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            Nodo temp = cola.frente;
            while (temp != null)
            {
                lstCola.Items.Add(temp.dato.ToString());
                temp = temp.sig;
            }
        }
    }
}
