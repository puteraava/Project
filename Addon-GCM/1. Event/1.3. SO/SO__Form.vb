﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.296
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
Imports System.Threading
Public Class SO__Form
    Inherits B1Event

    Public Sub New()
        MyBase.New()
        'FormType = "RealisasiTagihan"
        'ItemUID = "mtx_real"
    End Sub

    <B1Listener(BoEventTypes.et_FORM_DATA_ADD, False, {"139"})> _
    Public Overridable Sub OnAfterFormDataAdd(ByVal pVal As BusinessObjectInfo)
        Try
            Dim form As Form = B1Connections.theAppl.Forms.Item(pVal.FormUID)
            'Dim formActive As SAPbouiCOM.Form
            Dim formActiveUdf As SAPbouiCOM.Form
            formActiveUdf = B1Connections.theAppl.Forms.Item(form.UDFFormUID)
            ' new issue
            Dim docentryds As String = formActiveUdf.Items.Item("U_IDU_DSNo").Specific.Value
            Dim docentry As String = form.DataSources.DBDataSources.Item("ORDR").GetValue("DocEntry", 0)
            Dim docnum As String = Control._retRstField("select ""DocNum"" from ""ORDR"" where ""DocEntry""='" & docentry & "'")

            Control._executeQuery("update ""@ODLS"" set ""U_IDU_SO_Number""='" & docnum & "', ""U_IDU_SO_Entry""='" & docentry & "', ""Status""='C', ""U_IDU_DocStatus""='C' where ""DocEntry""=" & docentryds)
        Catch ex As Exception
            B1Connections.theAppl.MessageBox("Form_FORM_DATA_ADD_SO|OnAfterFormDataAddSO|" & ex.Message.ToString)
        Finally

        End Try
    End Sub

    <B1Listener(BoEventTypes.et_RIGHT_CLICK, True, {"139"})> _
    Public Overridable Function OnBeforeRightClick(ByVal pVal As ContextMenuInfo) As Boolean
        Dim form As Form = B1Connections.theAppl.Forms.Item(pVal.FormUID)
        'ADD YOUR ACTION CODE HERE ...
        Dim odbds As SAPbouiCOM.DBDataSource = CType(form.DataSources.DBDataSources.Item(0), SAPbouiCOM.DBDataSource)
        Dim docentry As String = odbds.GetValue("DocEntry", odbds.Offset)
        'Dim a As String = docentry
        If docentry <> "" Then
            Glovar._docentryso = docentry
        End If
        Return True
    End Function
End Class
