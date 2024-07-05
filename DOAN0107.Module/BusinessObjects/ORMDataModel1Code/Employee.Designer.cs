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
using DevExpress.Persistent.Base;
namespace DOAN0107.Module.BusinessObjects.ORMDataModel1
{

    public partial class Employee : XPObject
    {
        string fFullName;
        public string FullName
        {
            get { return fFullName; }
            set { SetPropertyValue<string>(nameof(FullName), ref fFullName, value); }
        }
        string fNumberPhone;
        public string NumberPhone
        {
            get { return fNumberPhone; }
            set { SetPropertyValue<string>(nameof(NumberPhone), ref fNumberPhone, value); }
        }
        string fAddress;
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>(nameof(Address), ref fAddress, value); }
        }
        string fPosition;
        public string Position
        {
            get { return fPosition; }
            set { SetPropertyValue<string>(nameof(Position), ref fPosition, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        [Delayed(true), VisibleInListView(true)]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PopupPictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorFixedHeight = 340, DetailViewImageEditorFixedWidth = 227,
        ListViewImageEditorCustomHeight = 40)]
        [XafDisplayName("Ảnh")]
        public byte[] Avatar
        {
            get { return GetDelayedPropertyValue<byte[]>(nameof(Avatar)); }
            set { SetDelayedPropertyValue(nameof(Avatar), value); }
        }
        
        Branch fBranchID;
        [Association(@"EmployeeReferencesBranch")]
        public Branch BranchID
        {
            get { return fBranchID; }
            set { SetPropertyValue<Branch>(nameof(BranchID), ref fBranchID, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        string fRole;
        public string Role
        {
            get { return fRole; }
            set { SetPropertyValue<string>(nameof(Role), ref fRole, value); }
        }
        [Association(@"StoreReferencesEmployee")]
        public XPCollection<Warehouse_Receipt> Stores { get { return GetCollection<Warehouse_Receipt>(nameof(Stores)); } }
        [Association(@"OrderReferencesEmployee")]
        public XPCollection<Bill> Orders { get { return GetCollection<Bill>(nameof(Orders)); } }
        [Association(@"Delivery_BillReferencesEmployee")]
        public XPCollection<Delivery_Bill> Delivery_Bills { get { return GetCollection<Delivery_Bill>(nameof(Delivery_Bills)); } }
    }

}
