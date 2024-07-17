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
Public Class APR_DLS__Button__Approve
    Inherits B1Item

    Public Sub New()
        MyBase.New()
        FormType = "APR_DLS"
        ItemUID = "btn_appr"
    End Sub

    <B1Listener(BoEventTypes.et_ITEM_PRESSED, False)> _
    Public Overridable Sub OnAfterItemPressed(ByVal pVal As ItemEvent)
        Dim form As Form = B1Connections.theAppl.Forms.Item(pVal.FormUID)
        'Dim mtx As SAPbouiCOM.Matrix = form.Items.Item("mtx_ds").Specific
        'ADD YOUR ACTION CODE HERE ...
        Try
            Dim Grid As SAPbouiCOM.Grid
            Grid = form.Items.Item("Item_0").Specific
            If Grid.Rows.SelectedRows.Count <= 0 Then
                Exit Sub
            End If

            'Dim i As Integer
            'Dim brs As Integer
            'Dim j As Integer
            Dim SelectRow As Integer
            Dim GridIndex As Integer

            'cek row yg keselect
            For brs = 0 To Grid.Rows.SelectedRows.Count - 1
                SelectRow = Grid.Rows.SelectedRows.Item(brs, BoOrderType.ot_SelectionOrder)
                GridIndex = APR_DLS__Sub._getGridRowIndex(Grid, SelectRow)
                Dim Docentry As String = (Grid.DataTable.Columns.Item(0).Cells.Item(GridIndex).Value)
                Dim remark As String = (Grid.DataTable.Columns.Item(5).Cells.Item(GridIndex).Value)
                Dim sql As String = "update ""@ODLS"" set ""U_IDU_Appr_Status""='A', ""Remark""='" & remark & "' where ""DocEntry""=" & Docentry & " and ""U_IDU_Appr_Status"" = 'W' "
                'Control._executeQuery(sql)

                If DLVR_SCH__Sub.Transferto01(Docentry) = True Then
                    Control._executeQuery(sql)
                End If
            Next

            APR_DLS__Sub.Loadgrid(form)
        Catch ex As Exception
            B1Connections.theAppl.MessageBox("btn_appr|OnBeforeItemPressed|" & ex.Message.ToString)
        End Try
    End Sub
End Class
