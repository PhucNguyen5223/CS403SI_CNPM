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
        string fAvatar;
        public string Avatar
        {
            get { return fAvatar; }
            set { SetPropertyValue<string>(nameof(Avatar), ref fAvatar, value); }
        }
        Branch fBranchID;
        [Association(@"EmployeeReferencesBranch")]
        public Branch BranchID
        {
            get { return fBranchID; }
            set { SetPropertyValue<Branch>(nameof(BranchID), ref fBranchID, value); }
        }
        [Association(@"StoreReferencesEmployee")]
        public XPCollection<Store> Stores { get { return GetCollection<Store>(nameof(Stores)); } }
        [Association(@"OrderReferencesEmployee")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>(nameof(Orders)); } }
    }

}
