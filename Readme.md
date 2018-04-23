# How to store a workbook in the database


<p>This example uses the SaveDocument(DocumentFormat format) and LoadDocument(byte[] buffer, DocumentFormat format) methods of the SpreadsheetControl to store workbook in the database and retrieve it from there.</p><p>The test database is MS SQL local file database. It is included in the project.<br />
To use another database, change the connection string as required and create a new table in that database.  Use the script contained in the TestDB_table.sql file  to generate a table for the MS SQL Server database.</p>

<br/>


