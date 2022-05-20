using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace SistemaLibreria.UI.Facturas
{
    public partial class AgregarFacturas : DevExpress.XtraEditors.XtraForm
    {
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirSimpleButton_Click(object sender, EventArgs e)
        {
           
        }
      /*  public void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }*/
    }
}