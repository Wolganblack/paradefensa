﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;

namespace DXApplication4.UI.Provedor
{
    public partial class AgregarProveedor : DevExpress.XtraEditors.XtraForm
    {
        public int? Id
        {
            get;

            set;
        }

        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            if (this.Id != null)
            {
                var criteria = CriteriaOperator.Parse(string.Format("{0} = {1}", nameof(AgregarProveedor.Id), this.Id));
                ProveedorXpCollection.Criteria = criteria;
                ProveedorXpCollection.LoadingEnabled = true;
                ProveedorXpCollection.Load();
            }
            else
            {
                this.ProovedorBindingSource.AddNew();
            }
        }

        private void AgregarProveedorSimpleButton1_Click(object sender, EventArgs e)
        {
            if (!this.AgregarProveedorDxValidationProvider1.Validate())
            {
                return;

            }
            this.ProovedorBindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }


    }
}
