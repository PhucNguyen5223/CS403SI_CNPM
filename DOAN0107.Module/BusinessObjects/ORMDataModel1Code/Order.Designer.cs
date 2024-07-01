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
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
namespace DOAN0107.Module.BusinessObjects.ORMDataModel1
{

    public partial class Order : XPObject
    {
        User fUserID;
        [Association(@"OrderReferencesUser")]
        public User UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<User>(nameof(UserID), ref fUserID, value); }
        }
        Employee fEmployeeID;
        [Association(@"OrderReferencesEmployee")]
        public Employee EmployeeID
        {
            get { return fEmployeeID; }
            set { SetPropertyValue<Employee>(nameof(EmployeeID), ref fEmployeeID, value); }
        }
        string fStatus;
        public string Status
        {
            get { return fStatus; }
            set { SetPropertyValue<string>(nameof(Status), ref fStatus, value); }
        }
        double fTotalPrice;
        public double TotalPrice
        {
            get { return fTotalPrice; }
            set { SetPropertyValue<double>(nameof(TotalPrice), ref fTotalPrice, value); }
        }
        DateTime fCreateTime;
        [ModelDefault("EditMask", "dd/MM/yyyy HH:mm")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime CreateTime
        {
            get { return fCreateTime; }
            set { SetPropertyValue<DateTime>(nameof(CreateTime), ref fCreateTime, value); }
        }
        [Association(@"Order_DetailReferencesOrder")]
        public XPCollection<Order_Detail> Order_Details { get { return GetCollection<Order_Detail>(nameof(Order_Details)); } }
    }

}
