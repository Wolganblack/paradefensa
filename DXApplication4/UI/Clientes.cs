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
using SistemaLibreria.UI;
using DevExpress.Xpo;

namespace SistemaLibreria.UI
{
    public partial class Clientes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Clientes()
        {
            InitializeComponent();
            this.UnitOfWork.Connection = XpoDefault.DataLayer.Connection;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}