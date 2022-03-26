using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_JosephErazo
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }
        Pedidos pedidos = new Pedidos();
        PedidosDA pedidosDA = new PedidosDA();
        private void ListarPedidos()
        {
            DetalleDataGridView.DataSource = pedidosDA.ListarPedidos();
        }

        private void LimpiarControles()
        {
            IDclienteTextBox.Clear();
            NombreTextBox.Clear();
            CodigoProductoTextBox.Clear();
            CantidadTextBox.Clear();
            NombreProductoTextBox.Clear();
        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            pedidos.IDcliente = IDclienteTextBox.Text;
            pedidos.Nombre = NombreTextBox.Text;
            pedidos.Codigo = CodigoProductoTextBox.Text;
            pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.NombreProducto = NombreProductoTextBox.Text;
            pedidos.Fecha = FechaDateTimePicker.Value;

            int idPedido = 0;

            idPedido = pedidosDA.InsertarPedidos(pedidos);

            ListarPedidos();
            LimpiarControles();


        }
    }
}
