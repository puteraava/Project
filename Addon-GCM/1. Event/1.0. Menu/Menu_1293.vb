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

Public Class Menu_1293

    Inherits B1Menu

    Public Sub New()
        MyBase.New()
        MenuUID = "1293"
    End Sub

    '<B1Listener(BoEventTypes.et_MENU_CLICK, True, {"DLVR_SCH"})> _
    'Public Overridable Function OnBeforeMenuClick(ByVal pVal As MenuEvent) As Boolean
    '    Dim oForm As Form = B1Connections.theAppl.Forms.ActiveForm
    '    Dim frmUID As String = oForm.UniqueID.ToString

    '    Try
    '        'If oForm.TypeEx = "DLVR_SCH" Then

    '        '    Dim iResultMessage As Int16 = B1Connections.theAppl.MessageBox("Are you sure delete this line?", 1, "Yes", "No")

    '        '    If iResultMessage = 1 Then
    '        '        Dim oMatrix As Matrix = oForm.Items.Item("mtx_ds").Specific
    '        '        'oForm.DataSources.DBDataSources.Item("@IDU_TMP_DTL").RemoveRecord(_matrixLineNumber - 1)
    '        '        oMatrix.DeleteRow(_matrixLineNumber)

    '        '        If oForm.Mode = BoFormMode.fm_OK_MODE Then
    '        '            oForm.Mode = BoFormMode.fm_UPDATE_MODE
    '        '        End If
    '        '        Return False
    '        '    Else
    '        '        Return False
    '        '    End If

    '        'End If

    '        Return True
    '    Catch ex As Exception
    '        B1Connections.theAppl.SetStatusBarMessage(ex.Message, BoMessageTime.bmt_Short, True)
    '    End Try
    'End Function

End Class