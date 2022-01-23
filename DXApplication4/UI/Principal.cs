using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SistemaLibreria.UI
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        protected void ClienteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clientes formularioClientes = new Clientes();
            formularioClientes.MdiParent = this;
            formularioClientes.Visible = true;
        }
    }
}