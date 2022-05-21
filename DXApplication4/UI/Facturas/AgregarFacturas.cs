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
using ModeloDatos.ORM;

namespace SistemaLibreria.UI.Facturas
{
    public partial class AgregarFacturas : DevExpress.XtraEditors.XtraForm
    {
        private Factura factura;

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

        private void AgregarFacturas_Load(object sender, EventArgs e)
        {
            this.factura = this.FacturaBindingSource.AddNew() as Factura;
        }

        private void AñadirVentaSimpleButton_Click(object sender, EventArgs e)
        {
            var producto = this.ProductoSearchLookUpEdit.EditValue as ModeloDatos.ORM.Producto;
            var cantidad = this.CantidadTextEdit.EditValue;
            int valorCantidad = 0;
            if (producto == null || 
                cantidad == null || 
                !int.TryParse(cantidad.ToString(), out valorCantidad))
            {
                return;
            }

            var detalleFacura = new DetalleFactura(this.factura.Session);
            detalleFacura.Descripcion = producto.Descripcion;
            detalleFacura.CantidadPedida = valorCantidad;
            detalleFacura.FacturaId = this.factura;
            detalleFacura.ProductoId = producto;
            detalleFacura.PrecioTotal = producto.PrecioVenta * valorCantidad;
            this.DetalleFacturaBindingSource.Add(detalleFacura);
            this.DetalleFacturaGridView.RefreshData();
        }

        private void AgregarFacturaSimpleButton_Click(object sender, EventArgs e)
        {
            if (!this.AgregarFacDxValidationProvider.Validate())
            {
                return;

            }
            this.DetalleFacturaBindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }

        private void ProductoSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var producto = this.ProductoSearchLookUpEdit.EditValue as ModeloDatos.ORM.Producto;

            if(producto==null)
            {
                this.StockTextEdit.EditValue = null;
                return;
            }
            this.StockTextEdit.EditValue = producto.Existencias;
        }

        private void ProductoSearchLookUpEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }
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

