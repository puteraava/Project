﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
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

Public Class Menu_1284

    Inherits B1Menu

    Public Sub New()
        MyBase.New()
        MenuUID = "1284"
    End Sub

    '<B1Listener(BoEventTypes.et_MENU_CLICK, False)> _
    'Public Overridable Sub onaftermenuclick(ByVal pval As MenuEvent)
    '    Dim oform As Form = B1Connections.theAppl.Forms.ActiveForm
    '    Dim frmuid As String = oform.UniqueID.ToString
    '    Dim docentry As String = Glovar._docentryds

    '    Try
    '        'Control._executeQuery("update ""@ODLS"" set ""U_IDU_DocStatus""='CL' where ""DocEntry""=" & docentry)
    '        docentry = Glovar._docentryds

    '        If oform.TypeEx = "DLVR_SCH" Then
    '            If docentry <> "" Then
    '                APR_DLS__Sub.updatePI(docentry)

    '                'do transfer balik
    '                Dim itentry As String = Control._retRstField("select ""U_IDU_IT_Entry"" from ""@ODLS"" where ""DocEntry""= " & docentry)

    '                If itentry <> "" Then
    '                    DLVR_SCH__Sub.Transferfrom01(docentry)
    '                End If
    '            End If
    '        ElseIf oform.TypeEx = "139" Then
    '            docentry = Glovar._docentryso
    '            If docentry <> "" Then
    '                'get DS entry
    '                Dim docentryds As String = Control._retRstField("select ""U_IDU_DSNo"" from ""ORDR"" where ""DocEntry""= " & docentry)

    '                If docentryds <> "" Then
    '                    'update Cancel DS
    '                    Dim sql As String = "update ""@ODLS"" set ""U_IDU_DocStatus""='CL' , ""Canceled""='Y' where ""DocEntry""=" & docentryds & ""
    '                    Control._executeQuery(sql)

    '                    APR_DLS__Sub.updatePI(docentryds)

    '                    'do transfer balik
    '                    Dim itentry As String = Control._retRstField("select ""U_IDU_IT_Entry"" from ""@ODLS"" where ""DocEntry""= " & docentryds)

    '                    If itentry <> "" Then
    '                        DLVR_SCH__Sub.Transferfrom01(docentryds)
    '                    End If
    '                End If
    '            End If
    '        End If


    '    Catch ex As Exception
    '        B1Connections.theAppl.SetStatusBarMessage(ex.Message, BoMessageTime.bmt_Short, True)
    '    End Try
    'End Sub



    '<B1Listener(BoEventTypes.et_ITEM_PRESSED, True, {"DLVR_SCH"})> _
    'Public Overridable Function OnBeforeItemPressed(ByVal pVal As ItemEvent) As Boolean
    '    Dim oForm As Form = B1Connections.theAppl.Forms.ActiveForm
    '    Dim frmUID As String = oForm.UniqueID.ToString
    '    Dim docentry As String = oForm.Items.Item("DocEntry").Specific.value

    '    Try
    '        Control._executeQuery("update ""@ODLS"" set ""DocStatus""='CL' where ""DocEntry""=" & docentry)

    '    Catch ex As Exception
    '        B1Connections.theAppl.SetStatusBarMessage(ex.Message, BoMessageTime.bmt_Short, True)
    '    End Try
    'End Function

    '<B1Listener(BoEventTypes.et_ITEM_PRESSED, False, {"DLVR_SCH"})> _
    'Public Overridable Sub OnAfterItemPressed(ByVal pVal As ItemEvent)
    '    Dim form As Form = B1Connections.theAppl.Forms.Item(pVal.FormUID)
    '    Dim mtx As SAPbouiCOM.Matrix = form.Items.Item("mtx_ds").Specific
    '    Dim docentry As String = form.Items.Item("DocEntry").Specific.value
    '    Dim a As String = docentry
    'End Sub

    '<B1Listener(BoEventTypes.et_MENU_CLICK, False, {"DLVR_SCH"})> _
    'Public Overridable Function OnBeforeMenuClick(ByVal pVal As MenuEvent) As Boolean
    '    Dim oForm As Form = B1Connections.theAppl.Forms.ActiveForm
    '    Dim frmUID As String = oForm.UniqueID.ToString
    '    Dim docentry As String = oForm.Items.Item("DocEntry").Specific.value

    '    Try
    '        Control._executeQuery("update ""@ODLS"" set ""DocStatus""='CL' where ""DocEntry""=" & docentry)

    '    Catch ex As Exception
    '        B1Connections.theAppl.SetStatusBarMessage(ex.Message, BoMessageTime.bmt_Short, True)
    '    End Try

    '    Return True
    'End Function
End Class
