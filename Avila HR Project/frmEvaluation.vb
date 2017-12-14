Imports System.IO
Public Class frmEvaluation
    Structure EmployeeEvaluation 'Declare Structure
        Dim Index As Integer
        Dim ID As String
        Dim FirstName As String
        Dim LastName As String
    End Structure

    Public Employees() As EmployeeEvaluation 'Build Array Employee from the Structure

    Private Sub frmEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEmployee.Hide()
    End Sub

    Private Sub SwitchFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchFormToolStripMenuItem.Click
        frmEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub ClearAllTextBoxes() Handles ClearBoxesToolStripMenuItem.Click
        Dim clear As Control
        For Each clear In Me.Controls
            If TypeOf clear Is TextBox Then
                clear.Text = Nothing
            End If
        Next
    End Sub

    Private Sub OpenFile() Handles OpenToolStripMenuItem.Click
        Dim Open As New OpenFileDialog
        Dim Response As String
        Dim FileName
        Open.ShowDialog()
        Open.Filter = "All Files(*.*)|*.*"
        FileName = Open.FileName
        If File.Exists(FileName) Then
            MsgBox("You have selected: " & FileName, MsgBoxStyle.Information)
            Response = MsgBox("Do you want to open it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If Response = vbYes Then
                System.Diagnostics.Process.Start(FileName)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmEvaluation_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class