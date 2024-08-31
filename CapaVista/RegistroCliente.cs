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

        // Llena los campos con los datos del cliente
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = clienteRepository.ObtenerPorID(txtBuscar.Text);
            txtDUI.Text = cliente.DUI;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            txtGenero.Text = cliente.Genero;
        }

        // Guarda el nuevo cliente en la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var resultado = 0;
            var nuevoCliente = ObtenerNuevoCliente();

            if (validarCampoNull(nuevoCliente) == false)
            {
                resultado = clienteRepository.InsertarCliente(nuevoCliente);
                MessageBox.Show("Guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }

        // Verifica si algún campo del objeto está vacío
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

        // Edita un cliente existente en la base de datos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var actualizarCliente = ObtenerNuevoCliente();
            int actualizadas = clienteRepository.ActualizarCliente(actualizarCliente);
            MessageBox.Show("Actualizaciòn exitosa");
        }

        // Obtiene los datos del formulario y los convierte en un objeto Cliente
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

        // Elimina un cliente existende en la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int borradas = clienteRepository.EliminarCliente(txtDUI.Text);
            MessageBox.Show("Filas eliminadas exitosamente");
        }

        // cierra la ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
