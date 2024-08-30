using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroCliente : Form
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = clienteRepository.ObtenerPorID(txtBuscar.Text);
            txtDUI.Text = (cliente.DUI).ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            txtGenero.Text = cliente.Genero;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var resultado = 0;
            var nuevoCliente = ObtenerNuevoCliente();

            if (validarCampoNull(nuevoCliente) == false)
            {
                resultado = clienteRepository.InsertarCliente(nuevoCliente);
                MessageBox.Show("Guardado " + "Filas modificadas = " + resultado);
            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }
        //////////////////
        private bool validarCampoNull(object objeto)
        {
            foreach (PropertyInfo property in objeto.GetType().GetProperties())
            {
                object value = property.GetValue(objeto, null);
                if ((string)value == "")
                {
                    return true;
                }
            }
            return false;
        }
        //////////////////
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var actualizarCliente = ObtenerNuevoCliente();
            int actualizadas = clienteRepository.ActualizarCliente(actualizarCliente);
            MessageBox.Show($"Filas actualizadas = {actualizadas}");
        }

        //////////////////
        private Clientes ObtenerNuevoCliente()
        {
            var nuevoCliente = new Clientes
            {
                DUI = txtDUI.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text,
                Genero = txtGenero.Text,
            };
            return nuevoCliente;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int borradas = clienteRepository.EliminarCliente(txtDUI.Text);
            MessageBox.Show("Filas eliminadas = " + borradas);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
