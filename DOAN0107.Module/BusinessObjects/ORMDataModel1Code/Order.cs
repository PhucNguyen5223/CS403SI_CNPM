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
    public partial class Order
    {
        public Order(Session session) : base(session) {
<<<<<<< HEAD
            CreateTime=DateTime.Now;
=======
>>>>>>> thanh
        }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
