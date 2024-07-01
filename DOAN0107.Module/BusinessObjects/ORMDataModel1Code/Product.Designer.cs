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

    public partial class Product : XPObject
    {
        string fNameProduct;
        public string NameProduct
        {
            get { return fNameProduct; }
            set { SetPropertyValue<string>(nameof(NameProduct), ref fNameProduct, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }

        [Delayed(true), VisibleInListView(true)]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PopupPictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorFixedHeight = 340, DetailViewImageEditorFixedWidth = 227,
        ListViewImageEditorCustomHeight = 40)]
        [XafDisplayName("Ảnh")]
        public byte[] Images
        {
            get { return GetDelayedPropertyValue<byte[]>(nameof(Images)); }
            set { SetDelayedPropertyValue(nameof(Images), value); }
        }
        double fPrice;
        public double Price
        {
            get { return fPrice; }
            set { SetPropertyValue<double>(nameof(Price), ref fPrice, value); }
        }
        string fBrand;
        public string Brand
        {
            get { return fBrand; }
            set { SetPropertyValue<string>(nameof(Brand), ref fBrand, value); }
        }
        Category fCategoryID;
        [Association(@"ProductReferencesCategory")]
        public Category CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<Category>(nameof(CategoryID), ref fCategoryID, value); }
        }
        [Association(@"Product_DetailReferencesProduct")]
        public XPCollection<Product_Detail> Product_Details { get { return GetCollection<Product_Detail>(nameof(Product_Details)); } }
    }

}
