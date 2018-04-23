Imports Microsoft.VisualBasic
Imports System
Namespace SpreadsheetToDatabase
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnDBLoad = New DevExpress.XtraEditors.SimpleButton()
			Me.btnDBSave = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 56)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.SelectedPicture = Nothing
			Me.spreadsheetControl1.SelectedShape = Nothing
			Me.spreadsheetControl1.Size = New System.Drawing.Size(814, 481)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnDBLoad)
			Me.panelControl1.Controls.Add(Me.btnDBSave)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(814, 56)
			Me.panelControl1.TabIndex = 1
			' 
			' btnDBLoad
			' 
			Me.btnDBLoad.Location = New System.Drawing.Point(330, 13)
			Me.btnDBLoad.Name = "btnDBLoad"
			Me.btnDBLoad.Size = New System.Drawing.Size(122, 23)
			Me.btnDBLoad.TabIndex = 1
			Me.btnDBLoad.Text = "Load from Database"
'			Me.btnDBLoad.Click += New System.EventHandler(Me.btnDBLoad_Click);
			' 
			' btnDBSave
			' 
			Me.btnDBSave.Location = New System.Drawing.Point(30, 13)
			Me.btnDBSave.Name = "btnDBSave"
			Me.btnDBSave.Size = New System.Drawing.Size(122, 23)
			Me.btnDBSave.TabIndex = 0
			Me.btnDBSave.Text = "Save to Database"
'			Me.btnDBSave.Click += New System.EventHandler(Me.btnDBSave_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(814, 537)
			Me.Controls.Add(Me.spreadsheetControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnDBLoad As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnDBSave As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

