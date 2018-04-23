using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpreadsheetToDatabase
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TestDB.mdf;Integrated Security=True";
                  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO WorksheetData(Data) VALUES(@Data)";
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.VarBinary);
                dataParameter.Value = spreadsheetControl1.SaveDocument(DevExpress.Spreadsheet.DocumentFormat.OpenXml);
                command.Parameters.Add(dataParameter);
                command.ExecuteNonQuery();
            }
            spreadsheetControl1.CreateNewDocument();
        }

        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            byte[] receivedBytes;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Data FROM WorksheetData WHERE ID = (SELECT MAX(ID) FROM WorksheetData)";

                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                receivedBytes = (byte[])sqlReader[0];
            }
            spreadsheetControl1.Document.LoadDocument(receivedBytes, DevExpress.Spreadsheet.DocumentFormat.OpenXml);
        }
    }
}
