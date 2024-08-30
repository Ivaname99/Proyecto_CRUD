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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

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
            // TODO: esta línea de código carga datos en la tabla 'project_CRUDDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.project_CRUDDataSet.Clientes);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            RegistroCliente objRegistroCliente = new RegistroCliente();
            objRegistroCliente.ShowDialog();
        }

        private void Filtro()
        {
            string idCliente = txtFiltro.Text;

            dgvClientes.DataSource = clienteRepository.ObtenerLista(idCliente);
            
        }

        private void Cargar()
        {
            var Clientes = clienteRepository.ObtenerTodos();
            dgvClientes.DataSource = Clientes;
        }
    }
}
