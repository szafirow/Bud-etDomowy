Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Collections.Generic


Public Class DB
    'Ustawienie polaczenia z  baza danych
    'Public Shared connectionString As String = "Data Source=LAPTOPSZAFIRKA;Initial Catalog=budzet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    '  Public Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MyData\Prywatne\BudzetDomowy\BudzetDomowy\BudzetDomowy\Database.mdf;Integrated Security=True"
    '  Public Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Patryk\BudzetDomowy\Database.mdf;Integrated Security=True"
    'C:\MyData\Prywatne\BudzetDomowy\BudzetDomowy\BudzetDomowy\bin\Debug\
    'Public Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" & System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "'\Database.mdf;Integrated Security=True"
    Public Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Database.mdf;Integrated Security=True"




End Class