﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXApplication4.sisstemadelibreria
{

    [Persistent(@"departamento")]
    public partial class Departamento : XPLiteObject
    {
        int fidDepartamento;
        [Key]
        public int idDepartamento
        {
            get { return fidDepartamento; }
            set { SetPropertyValue<int>(nameof(idDepartamento), ref fidDepartamento, value); }
        }
        string fDepartamento1;
        [Size(45)]
        [Persistent(@"Departamento")]
        public string Departamento1
        {
            get { return fDepartamento1; }
            set { SetPropertyValue<string>(nameof(Departamento1), ref fDepartamento1, value); }
        }
        [Association(@"MunicipioReferencesDepartamento")]
        public XPCollection<Municipio> Municipios { get { return GetCollection<Municipio>(nameof(Municipios)); } }
    }

}