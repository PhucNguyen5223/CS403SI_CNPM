using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace DOAN0107.Module.BusinessObjects.ORMDataModel1
{
    [DefaultClassOptions]
    public partial class Bill
    {
        public Bill(Session session) : base(session)
        {
            CreateTime = DateTime.Now;
        }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
