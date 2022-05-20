namespace SistemaLibreria.UI.Facturas
{
    partial class AgregarFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFacturas));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EmpleadoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ClienteSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ClienteXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FacturaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CodigoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.DescripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.StockTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PrecioUnitarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TotalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.AñadirVentaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimirSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModificarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductoSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ProductoXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AgregarFacturaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha:";
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Location = new System.Drawing.Point(101, 11);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(125, 22);
            this.FechaDateEdit.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Empleado:";
            // 
            // EmpleadoTextEdit
            // 
            this.EmpleadoTextEdit.Location = new System.Drawing.Point(101, 49);
            this.EmpleadoTextEdit.Name = "EmpleadoTextEdit";
            this.EmpleadoTextEdit.Size = new System.Drawing.Size(212, 22);
            this.EmpleadoTextEdit.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cliente:";
            // 
            // ClienteSearchLookUpEdit
            // 
            this.ClienteSearchLookUpEdit.Location = new System.Drawing.Point(101, 92);
            this.ClienteSearchLookUpEdit.Name = "ClienteSearchLookUpEdit";
            this.ClienteSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ClienteSearchLookUpEdit.Properties.DataSource = this.ClienteXpCollection;
            this.ClienteSearchLookUpEdit.Properties.DisplayMember = "Nombre_apellido";
            this.ClienteSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.ClienteSearchLookUpEdit.Properties.ValueMember = "Id";
            this.ClienteSearchLookUpEdit.Size = new System.Drawing.Size(327, 22);
            this.ClienteSearchLookUpEdit.TabIndex = 5;
            // 
            // ClienteXpCollection
            // 
            this.ClienteXpCollection.ObjectType = typeof(ModeloDatos.ORM.Cliente);
            this.ClienteXpCollection.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FacturaTextEdit
            // 
            this.FacturaTextEdit.Location = new System.Drawing.Point(417, 11);
            this.FacturaTextEdit.Name = "FacturaTextEdit";
            this.FacturaTextEdit.Size = new System.Drawing.Size(125, 22);
            this.FacturaTextEdit.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(347, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 20);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Factura:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(371, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 20);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Codigo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(10, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(135, 20);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Buscar Producto:";
            // 
            // CodigoTextEdit
            // 
            this.CodigoTextEdit.Location = new System.Drawing.Point(439, 148);
            this.CodigoTextEdit.Name = "CodigoTextEdit";
            this.CodigoTextEdit.Size = new System.Drawing.Size(69, 22);
            this.CodigoTextEdit.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 193);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 20);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Descripcion:";
            // 
            // DescripcionTextEdit
            // 
            this.DescripcionTextEdit.Location = new System.Drawing.Point(114, 193);
            this.DescripcionTextEdit.Name = "DescripcionTextEdit";
            this.DescripcionTextEdit.Size = new System.Drawing.Size(219, 22);
            this.DescripcionTextEdit.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(514, 148);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 20);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Stock:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 234);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 20);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Total:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(347, 195);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(124, 20);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Precio Unitario:";
            // 
            // StockTextEdit
            // 
            this.StockTextEdit.Location = new System.Drawing.Point(569, 149);
            this.StockTextEdit.Name = "StockTextEdit";
            this.StockTextEdit.Size = new System.Drawing.Size(80, 22);
            this.StockTextEdit.TabIndex = 18;
            // 
            // PrecioUnitarioTextEdit
            // 
            this.PrecioUnitarioTextEdit.Location = new System.Drawing.Point(477, 195);
            this.PrecioUnitarioTextEdit.Name = "PrecioUnitarioTextEdit";
            this.PrecioUnitarioTextEdit.Size = new System.Drawing.Size(86, 22);
            this.PrecioUnitarioTextEdit.TabIndex = 19;
            // 
            // TotalTextEdit
            // 
            this.TotalTextEdit.Location = new System.Drawing.Point(88, 231);
            this.TotalTextEdit.Name = "TotalTextEdit";
            this.TotalTextEdit.Size = new System.Drawing.Size(86, 22);
            this.TotalTextEdit.TabIndex = 20;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(10, 304);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(516, 262);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(10, 278);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(146, 20);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Detalle de Factura:";
            // 
            // AñadirVentaSimpleButton
            // 
            this.AñadirVentaSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AñadirVentaSimpleButton.ImageOptions.Image")));
            this.AñadirVentaSimpleButton.Location = new System.Drawing.Point(532, 304);
            this.AñadirVentaSimpleButton.Name = "AñadirVentaSimpleButton";
            this.AñadirVentaSimpleButton.Size = new System.Drawing.Size(141, 42);
            this.AñadirVentaSimpleButton.TabIndex = 23;
            this.AñadirVentaSimpleButton.Text = "Añadir Venta";
            // 
            // ImprimirSimpleButton
            // 
            this.ImprimirSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirSimpleButton.ImageOptions.Image")));
            this.ImprimirSimpleButton.Location = new System.Drawing.Point(532, 376);
            this.ImprimirSimpleButton.Name = "ImprimirSimpleButton";
            this.ImprimirSimpleButton.Size = new System.Drawing.Size(141, 41);
            this.ImprimirSimpleButton.TabIndex = 24;
            this.ImprimirSimpleButton.Text = "ImprimirFactura";
            this.ImprimirSimpleButton.Click += new System.EventHandler(this.ImprimirSimpleButton_Click);
            // 
            // ModificarSimpleButton
            // 
            this.ModificarSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ModificarSimpleButton.ImageOptions.Image")));
            this.ModificarSimpleButton.Location = new System.Drawing.Point(532, 454);
            this.ModificarSimpleButton.Name = "ModificarSimpleButton";
            this.ModificarSimpleButton.Size = new System.Drawing.Size(141, 41);
            this.ModificarSimpleButton.TabIndex = 25;
            this.ModificarSimpleButton.Text = "Modificar Factura";
            // 
            // ProductoSearchLookUpEdit
            // 
            this.ProductoSearchLookUpEdit.Location = new System.Drawing.Point(151, 149);
            this.ProductoSearchLookUpEdit.Name = "ProductoSearchLookUpEdit";
            this.ProductoSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductoSearchLookUpEdit.Properties.DataSource = this.ProductoXpCollection;
            this.ProductoSearchLookUpEdit.Properties.DisplayMember = "Nombre";
            this.ProductoSearchLookUpEdit.Properties.PopupView = this.gridView2;
            this.ProductoSearchLookUpEdit.Properties.ValueMember = "Id";
            this.ProductoSearchLookUpEdit.Size = new System.Drawing.Size(214, 22);
            this.ProductoSearchLookUpEdit.TabIndex = 26;
            // 
            // ProductoXpCollection
            // 
            this.ProductoXpCollection.ObjectType = typeof(ModeloDatos.ORM.Producto);
            this.ProductoXpCollection.Session = this.unitOfWork1;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // AgregarFacturaSimpleButton
            // 
            this.AgregarFacturaSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AgregarFacturaSimpleButton.ImageOptions.Image")));
            this.AgregarFacturaSimpleButton.Location = new System.Drawing.Point(532, 525);
            this.AgregarFacturaSimpleButton.Name = "AgregarFacturaSimpleButton";
            this.AgregarFacturaSimpleButton.Size = new System.Drawing.Size(141, 41);
            this.AgregarFacturaSimpleButton.TabIndex = 27;
            this.AgregarFacturaSimpleButton.Text = "Agregar Factura";
            // 
            // AgregarFacturas
            // 
            this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("AgregarFacturas.Appearance.Image")));
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 595);
            this.Controls.Add(this.AgregarFacturaSimpleButton);
            this.Controls.Add(this.ProductoSearchLookUpEdit);
            this.Controls.Add(this.ModificarSimpleButton);
            this.Controls.Add(this.ImprimirSimpleButton);
            this.Controls.Add(this.AñadirVentaSimpleButton);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TotalTextEdit);
            this.Controls.Add(this.PrecioUnitarioTextEdit);
            this.Controls.Add(this.StockTextEdit);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.DescripcionTextEdit);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.CodigoTextEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.FacturaTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ClienteSearchLookUpEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.EmpleadoTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.FechaDateEdit);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarFacturas";
            this.Text = "AgregarFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit FechaDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit EmpleadoTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit ClienteSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit FacturaTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit CodigoTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit DescripcionTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit StockTextEdit;
        private DevExpress.XtraEditors.TextEdit PrecioUnitarioTextEdit;
        private DevExpress.XtraEditors.TextEdit TotalTextEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton AñadirVentaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimirSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModificarSimpleButton;
        private DevExpress.XtraEditors.SearchLookUpEdit ProductoSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton AgregarFacturaSimpleButton;
        private DevExpress.Xpo.XPCollection ClienteXpCollection;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.Xpo.XPCollection ProductoXpCollection;
    }
}