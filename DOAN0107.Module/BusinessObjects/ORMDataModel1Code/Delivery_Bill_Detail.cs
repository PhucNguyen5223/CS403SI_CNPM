using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DOAN0107.Module.BusinessObjects.ORMDataModel1
{

    public partial class Delivery_Bill_Detail
    {
        public Delivery_Bill_Detail(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
