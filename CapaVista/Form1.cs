using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        
        public Form1()
        {
            InitializeComponent();
        }

        // llama al metodo para cargar todos los clientes en el DataGridView
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        // Llama a un metodo para filtrar los clientes según el texto ingresado
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                Filtro();
            }
            else
            {
                Cargar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Cierra la ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            RegistroCliente objRegistroCliente = new RegistroCliente();
            objRegistroCliente.ShowDialog(); // Abre el formulario para modificar los datos del cliente
        }

        // Filtra los clientes según el texto ingresado
        private void Filtro()
        {
            string idCliente = txtFiltro.Text;

            dgvClientes.DataSource = clienteRepository.ObtenerLista(idCliente);
            
        }

        // Carga todos los clientes si el filtro está vacío
        private void Cargar()
        {
            var Clientes = clienteRepository.ObtenerTodos();
            dgvClientes.DataSource = Clientes;
        }
    }
}
