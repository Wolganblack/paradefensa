using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXApplication4.sisstemadelibreria
{

    public partial class Municipio
    {
        public Municipio(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
