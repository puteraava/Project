'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports B1WizardBase
Imports SAPbobsCOM
Imports SAPbouiCOM

Namespace Deliveryschedule

    Public Class Deliveryschedule_Db
        Inherits B1Db

        Public Sub New()
            MyBase.New()

            Tables = New B1DbTable() {
                New B1DbTable("@ODLS", "Delivery Schedule", BoUTBTableType.bott_Document),
                New B1DbTable("@DLS1", "Delivery Schedule - Detail", BoUTBTableType.bott_DocumentLines),
                New B1DbTable("@IDU_TRANSPORTER", "Transporter Master Data", BoUTBTableType.bott_NoObject),
                New B1DbTable("@IDU_TRUCK", "Truck Master Data", BoUTBTableType.bott_NoObject)
                }

            Columns = New B1DbColumn() {
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_CardCode", .Description = "Customer Code", .Type = BoFieldTypes.db_Alpha, .Size = 15, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_CardName", .Description = "Customer Name", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_DS_Del_Term", .Description = "DS Delivery term", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Transporter", .Description = "Transporter", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Truck", .Description = "Truck", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_TruckQty", .Description = "TruckQuantity", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_DocNum", .Description = "No", .Type = BoFieldTypes.db_Alpha, .Size = 11, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_DocDate", .Description = "Posting Date", .Type = BoFieldTypes.db_Date, .IsNullable = False},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_DocStatus", .Description = "Doc Status", .Type = BoFieldTypes.db_Alpha, .Size = 2, .IsNullable = False, .ValidValues = {New B1DbValidValue("O", "Open"), New B1DbValidValue("C", "Closed"), New B1DbValidValue("CL", "Closed")}},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Appr_Status", .Description = "Approval Status", .Type = BoFieldTypes.db_Alpha, .Size = 2, .IsNullable = False, .ValidValues = {New B1DbValidValue("W", "Waiting for Approval"), New B1DbValidValue("A", "Approved"), New B1DbValidValue("R", "Rejected")}},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_SO_Date", .Description = "Sales Order Date", .Type = BoFieldTypes.db_Date, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_SO_Number", .Description = "Sales Order Number", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_SO_Entry", .Description = "Sales Order Doc Entry", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Draft_Number", .Description = "Draft Number", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Draft_Entry", .Description = "Draft Doc Entry", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_IT_Number", .Description = "Item Transfer Number", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_IT_Entry", .Description = "Item Transfer Entry", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_Remarks", .Description = "Remarks (Agent)", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_DocTotal", .Description = "Total", .Type = BoFieldTypes.db_Float, .Size = 10, .SubType = BoFldSubTypes.st_Price, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_LCLAmount", .Description = "LCL Amount", .Type = BoFieldTypes.db_Float, .Size = 10, .SubType = BoFldSubTypes.st_Price, .IsNullable = True},
                New B1DbColumn With {.Table = "@ODLS", .Name = "IDU_GrandTotal", .Description = "Grand Total", .Type = BoFieldTypes.db_Float, .Size = 10, .SubType = BoFldSubTypes.st_Price, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_PIEntry", .Description = "PI Base Entry", .Type = BoFieldTypes.db_Alpha, .Size = 11, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_PI_No", .Description = "PI No", .Type = BoFieldTypes.db_Alpha, .Size = 11, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_NumAtCard", .Description = "Customer Reference No", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_ItemCode", .Description = "Item Code", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Dscription", .Description = "Item Description", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Price", .Description = "Unit Price", .Type = BoFieldTypes.db_Float, .Size = 10, .SubType = BoFldSubTypes.st_Price, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Quantity", .Description = "Quantity", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_QuantityPI", .Description = "Quantity PI", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_unitMsr", .Description = "UoM", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Packaging", .Description = "Packaging", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_IDU_Bags", .Description = "Qty Bags", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Bagging_Weight", .Description = "Bagging weight", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_TotalAmount", .Description = "Total Amount", .Type = BoFieldTypes.db_Float, .Size = 10, .SubType = BoFldSubTypes.st_Price, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_BalanceQty", .Description = "Balance Qty", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Whse", .Description = "Warehouse", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_BatchNo", .Description = "Batch No", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_BIN_Loc", .Description = "BIN Location", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = False},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_ShipDate", .Description = "Shipment Date", .Type = BoFieldTypes.db_Date, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_LCL", .Description = "LCL", .Type = BoFieldTypes.db_Alpha, .Size = 3, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_PrdctHrchy", .Description = "Product Hierarchy", .Type = BoFieldTypes.db_Alpha, .Size = 30, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_PricingGrp", .Description = "Pricing Group", .Type = BoFieldTypes.db_Alpha, .Size = 1, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Grade", .Description = "Grade", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Project", .Description = "Project", .Type = BoFieldTypes.db_Alpha, .Size = 100, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_OcrCode", .Description = "Product Type", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_OcrCode2", .Description = "Distribution Channel", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_OcrCode3", .Description = "Department", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_OcrCode4", .Description = "Sales Employee", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_OcrCode5", .Description = "Trading Partner", .Type = BoFieldTypes.db_Alpha, .Size = 8, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_GroupNum", .Description = "Payment Terms", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_VatGroup", .Description = "VAT Group", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "@DLS1", .Name = "IDU_Status", .Description = "Status Checked", .Type = BoFieldTypes.db_Alpha, .Size = 3, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "QUT1", .Name = "Packaging", .Description = "Packaging", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "U_IDU_Bags", .Description = "Qty Bags", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "U_IDU_Bagging_Weight", .Description = "Bagging Weight", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Measurement, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "IDU_PrdctHrchy", .Description = "Product Hierarchy", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "IDU_PricingGrp", .Description = "Pricing Group", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "IDU_PI_Bal", .Description = "PI Bal", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Price, .Size = 10, .IsNullable = True},
                New B1DbColumn With {.Table = "QUT1", .Name = "Grade", .Description = "Grade", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_DistChannel", .Description = "Dist Channel", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_PricingGrp", .Description = "Pricing Group", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_SellingType", .Description = "Selling Type", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_PostalCode", .Description = "Postal Code", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_PlaceOfDel", .Description = "Place of Del", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_PortofDischarge", .Description = "Port of Discharge", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
                New B1DbColumn With {.Table = "OQUT", .Name = "IDU_PostalCode", .Description = "Dist Channel", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "OWTR", .Name = "IDU_DSNo", .Description = "DS No", .Type = BoFieldTypes.db_Alpha, .Size = 50, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "OITM", .Name = "IDU_Bagging_Weight", .Description = "Bagging Weight", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 10, .IsNullable = True},
 _
                New B1DbColumn With {.Table = "@IDU_TRANSPORTER", .Name = "IDU_TRANSPORTER_CODE", .Description = "Transporter Code", .Type = BoFieldTypes.db_Alpha, .Size = 5, .IsNullable = False},
                New B1DbColumn With {.Table = "@IDU_TRANSPORTER", .Name = "IDU_TRANSPORTER_NAME", .Description = "Transporter Name", .Type = BoFieldTypes.db_Alpha, .Size = 20, .IsNullable = False},
 _
                New B1DbColumn With {.Table = "@IDU_TRUCK", .Name = "IDU_TRUCK_TYPE", .Description = "Truck Type", .Type = BoFieldTypes.db_Alpha, .Size = 10, .IsNullable = False},
                New B1DbColumn With {.Table = "@IDU_TRUCK", .Name = "IDU_DEFAULT_WEIGHT", .Description = "Default Weight in D/S", .Type = BoFieldTypes.db_Float, .SubType = BoFldSubTypes.st_Quantity, .Size = 5, .IsNullable = False},
 _
                New B1DbColumn With {.Table = "RDR1", .Name = "IDU_RefPI_No", .Description = "PI RefNo", .Type = BoFieldTypes.db_Alpha, .Size = 11, .IsNullable = False} ' Update New UDF 31/05/2024
                }

            Udos = New B1Udo() {
                New B1Udo With {
                    .Code = "DLVR_SCH", .Name = "Delivery Schedule", .Type = BoUDOObjType.boud_Document, .Table = "ODLS",
                    .CanCancel = BoYesNoEnum.tYES, .CanDelete = BoYesNoEnum.tNO,
                    .CanFind = BoYesNoEnum.tYES, .ManageSeries = BoYesNoEnum.tYES,
                    .Children = New String() {"DLS1"},
                    .FindColumnsAlias = New String() {"DocEntry"},
                    .FindColumnsDesc = New String() {"DocEntry"}
                }
            }
        End Sub
    End Class
End Namespace
