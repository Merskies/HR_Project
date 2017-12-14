Imports System.IO

Public Class frmEmployee
    Structure PersonalInformation 'Declare Structure
        Dim ID As String
        Dim FirstName As String
        Dim LastName As String
        Dim Middle As String
        Dim Address As String
        Dim AptRoom As String
        Dim City As String
        Dim State As String
        Dim ZipCode As String
        Dim MainPhone As String
        Dim AlternatePhone As String
        Dim Email As String
        Dim SSN As String
        Dim Birthday As String
        Dim MaritalStatus As String
        Dim Gender As String
        Dim DateRecorded As String
    End Structure

    Public Employee() As PersonalInformation 'Build Array Employee from the Structure

    Private Sub LoadInfo() Handles Me.Load
        Dim Line As String
        Dim Data(16) As String
        Dim Individual() As String = IO.File.ReadAllLines("Employees.txt")
        ReDim Preserve Employee(Individual.Count - 1)
        For i As Integer = 0 To Individual.Count - 1
            Line = Individual(i)
            Data = Line.Split(","c)
            Employee(i).ID = Data(0)
            Employee(i).FirstName = Data(1)
            Employee(i).LastName = Data(2)
            Employee(i).Middle = Data(3)
            Employee(i).Address = Data(4)
            Employee(i).AptRoom = Data(5)
            Employee(i).City = Data(6)
            Employee(i).State = Data(7)
            Employee(i).ZipCode = Data(8)
            Employee(i).MainPhone = Data(9)
            Employee(i).AlternatePhone = Data(10)
            Employee(i).Email = Data(11)
            Employee(i).SSN = Data(12)
            Employee(i).Birthday = Data(13)
            Employee(i).MaritalStatus = Data(14)
            Employee(i).Gender = Data(15)
            Employee(i).DateRecorded = Data(16)
        Next
    End Sub

    Private Sub SwitchForm(sender As Object, e As EventArgs) Handles btnSwitch.Click, SwitchFormToolStripMenuItem.Click
        frmEvaluation.Show()
        Me.Hide()
    End Sub

    Private Sub ClearAllTextBoxes() Handles btnClear.Click, ClearBoxesToolStripMenuItem.Click
        Dim clear As Control
        For Each clear In Me.Controls
            If TypeOf clear Is TextBox Then
                clear.Text = Nothing
            End If
        Next
    End Sub

    Private Sub BtnNewEmployee_Click(sender As Object, e As EventArgs) Handles BtnNewEmployee.Click, NewEmployeeToolStripMenuItem.Click
        'This Code Assigns an ID for the new employee and assigns the date they were added.
        Dim lineCount = File.ReadAllLines("Employees.txt").Length
        Dim EmployeeID As String
        EmployeeID = lineCount + 1
        txtID.Text = EmployeeID
        txtDateRecorded.Text = Date.Today.ToString("dd-MM-yyyy")
    End Sub

    Private Sub BtnSaveEmployee_Click(sender As Object, e As EventArgs) Handles BtnSaveEmployee.Click, SaveToolStripMenuItem.Click
        'This code saves what is currently displayed on the textboxes to the array. It will not save unless all the boxes are filled in and will let the user know that.
        Dim ID, LastN, FirstN, MiddleN, StreetAd, Apt, City, State, Zip, MainPhone, AltPhone, Email, SSN, Birth, Martial, Gender, DateRecorded, Info As String
        ID = txtID.Text
        FirstN = txtFirstName.Text
        LastN = txtLastName.Text
        MiddleN = txtMiddle.Text
        StreetAd = txtAddress.Text
        Apt = txtAptRoom.Text
        City = txtCity.Text
        State = txtState.Text
        Zip = txtZipCode.Text
        MainPhone = txtMainPhone.Text
        AltPhone = txtAltPhone.Text
        Email = txtEmail.Text
        SSN = txtSSN.Text
        Birth = txtBirthday.Text
        Martial = txtMaritalStatus.Text
        Gender = txtGender.Text
        DateRecorded = txtDateRecorded.Text

        Info = ID & ", " & FirstN & ", " & LastN & ", " & MiddleN & ", " & StreetAd & ", " & Apt & ", " & City & ", " & State & ", " & Zip & ", " & MainPhone & ", " & AltPhone & ", " & Email & ", " & SSN & ", " & Birth & ", " & Martial & ", " & Gender & ", " & DateRecorded

        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name

        If ID = "" Then
            MessageBox.show("Please Click the New button before trying to enter information for a new employee")
        ElseIf emptyTextBoxes.Any Then
            MessageBox.show(String.Format("Please fill following textboxes: {0}.", String.Join(", ", emptyTextBoxes)))
            MessageBox.show("If you do not have the information to fill in, use NA instead.")
        Else
            Dim sw As StreamWriter = IO.File.AppendText("Employees.txt")
            sw.WriteLine(Info)
            sw.Close()
            MessageBox.show(FirstN & " " & LastN & " added to file.", "Name Added")
            ClearAllTextBoxes()
            txtLastName.Focus()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim EmployeeID As String
        EmployeeID = txtID.Text
        If EmployeeID <> "" Then
            If IDInFile(EmployeeID) Then
                Dim sr As StreamReader = File.OpenText("Employees.txt")
                Dim sw As StreamWriter = File.CreateText("Temp.txt")
                Dim Employee As String
                Do Until sr.EndOfStream
                    Employee = sr.ReadLine
                    If Employee <> EmployeeID Then
                        sw.WriteLine(Employee)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Employees.txt")
                File.Move("Temp.txt", "Employees.txt")
                MessageBox.Show(EmployeeID & " Updated.", "Employee Updated")
            Else
                MessageBox.Show(EmployeeID & " is not in the file.", "Employee not found")
            End If
        Else
            MessageBox.Show("ID is not found", "ID Error")
        End If
        ClearAllTextBoxes()
        txtFirstName.Focus()
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click, DisplayToolStripMenuItem.Click
        'This code is adding values to the structure.
        LoadInfo()
        Dim NameQuery = From Name In Employee
                        Order By Name.ID Ascending
                        Select Name.ID, Name.FirstName, Name.LastName, Name.Middle, Name.Address, Name.AptRoom, Name.City, Name.State, Name.ZipCode, Name.MainPhone, Name.AlternatePhone, Name.Email, Name.SSN, Name.Birthday, Name.MaritalStatus, Name.Gender, Name.DateRecorded
        dvgEmployee.DataSource = NameQuery.ToList
        dvgEmployee.CurrentCell = Nothing
        dvgEmployee.Columns("ID").HeaderText = "Employee ID"
        dvgEmployee.Columns("FirstName").HeaderText = "First Name"
        dvgEmployee.Columns("LastName").HeaderText = "Last Name"
        dvgEmployee.Columns("Middle").HeaderText = "Middle Name"
        dvgEmployee.Columns("Address").HeaderText = "Address"
        dvgEmployee.Columns("AptRoom").HeaderText = "Apt / Room #"
        dvgEmployee.Columns("City").HeaderText = "City"
        dvgEmployee.Columns("State").HeaderText = "State"
        dvgEmployee.Columns("ZipCode").HeaderText = "Zip Code"
        dvgEmployee.Columns("MainPhone").HeaderText = "Main Phone"
        dvgEmployee.Columns("AlternatePhone").HeaderText = "Alternate Phone"
        dvgEmployee.Columns("Email").HeaderText = "Email"
        dvgEmployee.Columns("SSN").HeaderText = "SSN"
        dvgEmployee.Columns("Birthday").HeaderText = "Birth Date"
        dvgEmployee.Columns("MaritalStatus").HeaderText = "Marital Status"
        dvgEmployee.Columns("Gender").HeaderText = "Gender"
        dvgEmployee.Columns("DateRecorded").HeaderText = "Date Added"
        dvgEmployee.RowHeadersVisible = False
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadInfo()
        Dim IDN As String
        IDN = InputBox("Please enter the employee's ID number to search", "ID Search")
        Dim IDQuery = From Name In Employee
                      Order By Name.ID Ascending
                      Let NameID = Name.ID
                      Where NameID = IDN
                      Select Name.ID, Name.FirstName, Name.LastName, Name.Middle, Name.Address, Name.AptRoom, Name.City, Name.State, Name.ZipCode, Name.MainPhone, Name.AlternatePhone, Name.Email, Name.SSN, Name.Birthday, Name.MaritalStatus, Name.Gender, Name.DateRecorded
        If (IDQuery.Count <> 0) Then
            Dim DBEmployee = IDQuery.First
            txtID.Text = DBEmployee.ID
            txtFirstName.Text = DBEmployee.FirstName
            txtLastName.Text = DBEmployee.LastName
            txtMiddle.Text = DBEmployee.Middle
            txtAddress.Text = DBEmployee.Address
            txtAptRoom.Text = DBEmployee.AptRoom
            txtCity.Text = DBEmployee.City
            txtState.Text = DBEmployee.State
            txtZipCode.Text = DBEmployee.ZipCode
            txtMainPhone.Text = DBEmployee.MainPhone
            txtAltPhone.Text = DBEmployee.AlternatePhone
            txtEmail.Text = DBEmployee.Email
            txtSSN.Text = DBEmployee.SSN
            txtBirthday.Text = DBEmployee.Birthday
            txtMaritalStatus.Text = DBEmployee.MaritalStatus
            txtGender.Text = DBEmployee.Gender
            txtDateRecorded.Text = DBEmployee.DateRecorded
            Return
        Else
            MessageBox.Show("That ID cannot be found! Please try another ID!", "ID Not Found")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenFile() Handles OpenToolStripMenuItem.Click
        Dim Open As New OpenFileDialog
        Dim Response As String
        Dim FileName
        Open.ShowDialog()
        open.Filter = "All Files(*.*)|*.*"
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

    Function IDInFile(ID As String) As Boolean
        If File.Exists("Employees.txt") Then
            Dim sr As StreamReader = File.OpenText("Employees.txt")
            Dim IDCheck As String
            Do Until sr.EndOfStream
                IDCheck = sr.ReadLine
                If IDCheck = ID Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function
End Class
