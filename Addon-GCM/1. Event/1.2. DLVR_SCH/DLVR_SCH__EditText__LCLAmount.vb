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
Public Class DLVR_SCH__EditText__LCLAmount
    Inherits B1Item

    Public Sub New()
        MyBase.New()
        FormType = "DLVRSCHv2"
        ItemUID = "LCLAmnt"
    End Sub

    <B1Listener(BoEventTypes.et_VALIDATE, False)> _
    Public Overridable Sub OnAfterValidate(ByVal pVal As ItemEvent)
        Try
            Dim ActionSuccess As Boolean = pVal.ActionSuccess
            Dim form As SAPbouiCOM.Form = B1Connections.theAppl.Forms.Item(pVal.FormUID)
            DLVR_SCH__Sub.RefreshGrandTotal(form)

        Catch ex As Exception
            B1Connections.theAppl.MessageBox("VALIDATE_LCLAmnt|OnAfterValidate|" & ex.Message.ToString)
        End Try
    End Sub
End Class
