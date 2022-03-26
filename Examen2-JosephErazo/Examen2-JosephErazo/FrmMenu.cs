using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2_JosephErazo
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        FrmProducto frmProducto = null;
       FrmPedidos frmPedido = null; 

        private void ProductostoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
        }

        private void PedidostoolStripButton_Click(object sender, EventArgs e)
        {
           if (frmPedido == null)
            {
                frmPedido = new FrmPedidos();
                frmPedido.MdiParent = this;
                frmPedido.Show();
            }
            else
            {
                frmPedido.Activate();
            }
        }

 
    }
}
