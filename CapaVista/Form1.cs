using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var Clientes = clienteRepository.ObtenerTodos();
            dgvMostrarClientes.DataSource = Clientes;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // var filtro = Customers.FindAll( X => X.CompanyName.StartsWith(tbFiltro.Text));
            // dataGrid.DataSource = filtro;

            //List<Clientes> Clientes = new List<Clientes>();
            //var filtro = Clientes.FindAll(X => X.Nombre.StartsWith(txtFiltro.Text));
            //dgvMostrarClientes.DataSource = filtro;
        }
    }
}
