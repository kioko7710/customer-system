Imports ADODB
Imports System.Data
Imports System.Data.OleDb

Public Class username
    Private ReadOnly txtPassword As Object
    Private ReadOnly txtName As Object
    Private form1 As Object

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uname As String
        Dim pword As String
        Dim username As String
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Fill all the Information")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
        End If
        Dim querry As String = "select password from table1 where name= '" & uname & "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kioko-pc\Documents\login.accdb"
        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Try
            pass = cmd.ExecuteScalar() / ToString()
        Catch ex As Exception
            MsgBox("username does not exist")
        End Try
        If (pword = pass) Then
            MsgBox("login success")
            Form2.Show()
            If Form2.ScrollStateHScrollVisible Then
                Me.Hide()

            End If
        Else
            MsgBox("Login Failed")
            TextBox1.Clear()
            TextBox2.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

Friend Class ConnectToDB
End Class
