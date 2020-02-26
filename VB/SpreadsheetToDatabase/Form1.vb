Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace SpreadsheetToDatabase
	Partial Public Class Form1
		Inherits Form
		Private connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TestDB.mdf;Integrated Security=True"

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnDBSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDBSave.Click
			Using connection As New SqlConnection(connectionString)
				connection.Open()
				Dim command As SqlCommand = connection.CreateCommand()
				command.CommandText = "INSERT INTO WorksheetData(Data) VALUES(@Data)"
				Dim dataParameter As New SqlParameter("@Data", SqlDbType.VarBinary)
				dataParameter.Value = spreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.OpenXml)
				command.Parameters.Add(dataParameter)
				command.ExecuteNonQuery()
			End Using
		End Sub

		Private Sub btnDBLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDBLoad.Click
			Dim receivedBytes() As Byte
			Using connection As New SqlConnection(connectionString)
				connection.Open()
				Dim command As SqlCommand = connection.CreateCommand()
				command.CommandText = "SELECT Data FROM WorksheetData WHERE ID = (SELECT MAX(ID) FROM WorksheetData)"

				Dim sqlReader As SqlDataReader = command.ExecuteReader()
				sqlReader.Read()
				receivedBytes = CType(sqlReader(0), Byte())
			End Using
			spreadsheetControl1.Document.LoadDocument(receivedBytes, DevExpress.Spreadsheet.DocumentFormat.OpenXml)
		End Sub
	End Class
End Namespace
