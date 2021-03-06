﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  1.0.0.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Selected Constituents Report' data form
''' </summary>

Partial Public Class [SelectedConstituentsReportUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.ReportParameterUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _selectionid As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of System.Guid)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "1.0.0.0")> _
    Public Sub New()
        MyBase.New()

        _selectionid = New Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of System.Guid)

        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/SelectedConstituentsReport.html"

        '
        '_selectionid
        '
        _selectionid.Name = "SELECTIONID"
        _selectionid.Caption = "Selection"
        _selectionid.SearchListId = New System.Guid("1f0e603c-1c55-4e1e-8218-bdb877b2cbe8")
        _selectionid.SearchFieldOverrides.Add(New Global.Blackbaud.AppFx.UIModeling.Core.FieldOverride() With {.FieldId = "IDSETFORMAT", .ReadOnly = True, .DefaultValueText = "2"})
        _selectionid.SearchFieldOverrides.Add(New Global.Blackbaud.AppFx.UIModeling.Core.FieldOverride() With {.FieldId = "RECORDTYPE", .ReadOnly = True, .DefaultValueText = "Constituent"})
        _selectionid.SystemSearchType = Global.Blackbaud.AppFx.UIModeling.Core.SystemSearchType.Selection
        Me.Fields.Add(_selectionid)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Selection
    ''' </summary>
    <System.ComponentModel.Description("Selection")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "1.0.0.0")> _
    Public ReadOnly Property [SELECTIONID]() As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of System.Guid)
        Get
            Return _selectionid
        End Get
    End Property
    
End Class
