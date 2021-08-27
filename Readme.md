<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613915/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5132)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SpreadsheetToDatabase/Form1.cs) (VB: [Form1.vb](./VB/SpreadsheetToDatabase/Form1.vb))
<!-- default file list end -->
# How to store a workbook in the database


<p>This example uses the SaveDocument(DocumentFormat format) and LoadDocument(byte[] buffer, DocumentFormat format) methods of the SpreadsheetControl to store workbook in the database and retrieve it from there.</p><p>The test database is MS SQL local file database. It is included in the project.<br />
To use another database, change the connection string as required and create a new table in that database.  Use the script contained in the TestDB_table.sql file  to generate a table for the MS SQL Server database.</p>

<br/>


