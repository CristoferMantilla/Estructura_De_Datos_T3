using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que el ID no esté vacío
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese un ID", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el ID solo tenga números
            int i = 0;
            while (i < txtID.Text.Length)
            {
                char c = txtID.Text[i];
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("El ID debe solo contener números", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                i = i + 1;
            }

            int id = int.Parse(txtID.Text);

            // Validar que el ID no se repita en la lista
            Nodo temp = lista.primero;
            while (temp != null)
            {
                if (temp.dato.ID == id)
                {
                    MessageBox.Show("El ID ya existe", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                temp = temp.sig;
            }

            // Validar que el Nombre no esté vacío
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de tarea", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el Nombre solo tenga letras
            int j = 0;
            while (j < txtNombre.Text.Length)
            {
                char c = txtNombre.Text[j];
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    MessageBox.Show("El Nombre solo debe contener letras", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                j = j + 1;
            }

            // Obtener los demás datos
            string nombre = txtNombre.Text;
            int prioridad = int.Parse(cmbPrioridad.SelectedItem.ToString());
            DateTime fecha = dtpFecha.Value;

            // Crear la tarea
            Tarea t = new Tarea(id, nombre, prioridad, fecha);

            // Insertar en estructuras
            lista.Insertar(t);
            cola.Encolar(t);
            arbol.Insertar(t);

            MessageBox.Show("Tarea agregada correctamente");

            // Refrescar visualización
            MostrarLista();

            // Limpiar campos
            txtID.Text = "";
            txtNombre.Text = "";
            txtID.Focus();

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
        }

        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar si la lista está vacía
            if (lista.primero == null)
            {
                MessageBox.Show("No hay tareas registradas. Primero ingrese una tarea.");
                return; // salir del método
            }
            // Validar que el ID no esté vacío
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID a eliminar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(txtID.Text);

            bool encontrado = false;

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
                    encontrado = true;
                    break;
                }
                temp = temp.sig;
            }
            MostrarLista();
            // 2. Si recorrió toda la lista y no encontró el ID
            if (encontrado == false)
            {
                MessageBox.Show("No se encontró ninguna tarea con ese ID.");
            }
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
            lstLista.Items.Clear();
            Nodo temp = cola.frente;
            while (temp != null)
            {
                lstLista.Items.Add(temp.dato.ToString());
                temp = temp.sig;
            }
        }
        // Mostrar tareas ordenadas por ID usando recorrido InOrden del árbol
        private void MostrarOrdenadoPorID()
        {
            lstLista.Items.Clear();
            MostrarInOrden(arbol.raiz_principal);
        }

        // Método recursivo auxiliar
        private void MostrarInOrden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                MostrarInOrden(raiz.izq);                  // primero izquierda
                lstLista.Items.Add(raiz.dato.ToString());  // luego el nodo actual
                MostrarInOrden(raiz.der);                  // finalmente derecha
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (arbol.raiz_principal == null)
                {
                    MessageBox.Show("No hay tareas registradas. Primero ingrese una tarea.");
                    return;
                }

                MostrarOrdenadoPorID();
            }
        }
    }
}
