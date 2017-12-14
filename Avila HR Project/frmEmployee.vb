Imports System.IO

Public Class frmEmployee
    Structure EmployeeInformation 'Declares Structure
        Dim Index As Integer
        Dim ID As String
        Dim FirstName As String
        Dim LastName As String
        Dim MiddleInitial As String
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

    Public Employees() As EmployeeInformation 'Builds Array Employee from the Structure

    Private Sub LoadInfo() Handles Me.Load 'Loads the array with data from Employees.txt file
        Dim Line As String
        Dim Data(16) As String
        Dim Individual() As String = IO.File.ReadAllLines("Employees.txt")
        ReDim Preserve Employees(Individual.Count - 1)
        For i As Integer = 0 To Individual.Count - 1
            Line = Individual(i)
            Data = Line.Split(","c)
            Employees(i).Index = i
            Employees(i).ID = Data(0)
            Employees(i).FirstName = Data(1)
            Employees(i).LastName = Data(2)
            Employees(i).MiddleInitial = Data(3)
            Employees(i).Address = Data(4)
            Employees(i).AptRoom = Data(5)
            Employees(i).City = Data(6)
            Employees(i).State = Data(7)
            Employees(i).ZipCode = Data(8)
            Employees(i).MainPhone = Data(9)
            Employees(i).AlternatePhone = Data(10)
            Employees(i).Email = Data(11)
            Employees(i).SSN = Data(12)
            Employees(i).Birthday = Data(13)
            Employees(i).MaritalStatus = Data(14)
            Employees(i).Gender = Data(15)
            Employees(i).DateRecorded = Data(16)
        Next
    End Sub

    Private Sub SwitchForm(sender As Object, e As EventArgs) Handles btnSwitch.Click, SwitchFormToolStripMenuItem.Click
        frmEvaluation.Show() 'Shows the other form and hide the current form.
        Me.Hide()
    End Sub

    Private Sub ClearAllTextBoxes() Handles btnClear.Click, ClearBoxesToolStripMenuItem.Click 'Clears all textboxes
        Dim clear As Control
        For Each clear In Me.Controls
            If TypeOf clear Is TextBox Then
                clear.Text = Nothing
            End If
        Next
        BtnSaveEmployee.Enabled = False
    End Sub

    Private Sub NewEmployee() Handles BtnNewEmployee.Click, NewEmployeeToolStripMenuItem.Click
        'Assigns an ID for the new employee and assigns the date they were added.
        Dim lineCount = File.ReadAllLines("Employees.txt").Length
        Dim EmployeeID As String
        EmployeeID = lineCount + 1
        ClearAllTextBoxes()
        txtID.Text = EmployeeID
        txtDateRecorded.Text = Date.Today.ToString("dd-MM-yyyy")
        BtnSaveEmployee.Enabled = True
        BtnUpdate.Enabled = False
    End Sub

    Private Sub SaveEmployee() Handles BtnSaveEmployee.Click, SaveToolStripMenuItem.Click
        'Saves what is currently displayed on the textboxes to the array. It will not save unless all the boxes are filled in and will let the user know that.
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
        'Concatenates all the variables into Info
        Dim emptyTextBoxes = 'Checks for empty text boxes
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}.", String.Join(", ", emptyTextBoxes)), "Missing Information")
            MessageBox.Show("If you do not have the information to fill in, use NA instead.", "Missing Information")
        Else
            Dim sw As StreamWriter = IO.File.AppendText("Employees.txt")
            sw.WriteLine(Info)
            sw.Close()
            MessageBox.Show(FirstN & " " & LastN & " added to file.", "Name Added")
            ClearAllTextBoxes()
            txtLastName.Focus()
        End If
    End Sub

    Private Sub UpdateInfo() Handles BtnUpdate.Click, UpdateToolStripMenuItem.Click 'Appends the file
        Dim EmployeeID, Name As String
        EmployeeID = txtID.Text
        Name = txtFirstName.Text & " " & txtLastName.Text
        Dim UpdatedData As String = ""
        For Each EM In Employees
            If EmployeeID = EM.ID Then
                EM.FirstName = txtFirstName.Text
                EM.LastName = txtLastName.Text
                EM.MiddleInitial = txtMiddle.Text
                EM.Address = txtAddress.Text
                EM.AptRoom = txtAptRoom.Text
                EM.City = txtCity.Text
                EM.State = txtState.Text
                EM.ZipCode = txtZipCode.Text
                EM.MainPhone = txtMainPhone.Text
                EM.AlternatePhone = txtAltPhone.Text
                EM.Email = txtEmail.Text
                EM.SSN = txtSSN.Text
                EM.Birthday = txtBirthday.Text
                EM.MaritalStatus = txtMaritalStatus.Text
                EM.Gender = txtGender.Text
                EM.DateRecorded = txtDateRecorded.Text
            End If
            With EM
                UpdatedData &= $"{ .ID},{ .FirstName},{ .LastName},{ .MiddleInitial},{ .Address},{ .AptRoom},{ .City},{ .State},{ .ZipCode},{ .MainPhone},{ .AlternatePhone},{ .Email},{ .SSN},{ .Birthday},{ .MaritalStatus},{ .Gender},{ .DateRecorded}" & vbCrLf
            End With
        Next
        File.WriteAllText("Employees.txt", UpdatedData)
        MessageBox.Show(Name & " Updated.", "Employee Updated")
        ClearAllTextBoxes()
        txtFirstName.Focus()
    End Sub

    Private Sub DisplayEmployees() Handles BtnDisplay.Click, DisplayToolStripMenuItem.Click
        'This code is adding values to the structure.
        LoadInfo()
        Dim NameQuery = From Employee In Employees
                        Order By Employee.ID Ascending
                        Select Employee.ID, Employee.FirstName, Employee.LastName, Employee.MiddleInitial, Employee.Address, Employee.AptRoom, Employee.City, Employee.State, Employee.ZipCode, Employee.MainPhone, Employee.AlternatePhone, Employee.Email, Employee.SSN, Employee.Birthday, Employee.MaritalStatus, Employee.Gender, Employee.DateRecorded
        dvgEmployee.DataSource = NameQuery.ToList
        dvgEmployee.CurrentCell = Nothing
        dvgEmployee.Columns("ID").HeaderText = "Employee ID"
        dvgEmployee.Columns("FirstName").HeaderText = "First Name"
        dvgEmployee.Columns("LastName").HeaderText = "Last Name"
        dvgEmployee.Columns("MiddleInitial").HeaderText = "Middle Initial"
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

    Private Sub SearchID() Handles BtnSearch.Click, SearchToolStripMenuItem.Click
        LoadInfo()
        Dim IDNumber As String
        IDNumber = InputBox("Please enter the employee's ID number to search", "ID Search")
        Dim IDQuery = From Employee In Employees
                      Order By Employee.ID Ascending
                      Let NameID = Employee.ID
                      Where NameID = IDNumber
                      Select Employee.ID, Employee.FirstName, Employee.LastName, Employee.MiddleInitial, Employee.Address, Employee.AptRoom, Employee.City, Employee.State, Employee.ZipCode, Employee.MainPhone, Employee.AlternatePhone, Employee.Email, Employee.SSN, Employee.Birthday, Employee.MaritalStatus, Employee.Gender, Employee.DateRecorded
        If (IDQuery.Count <> 0) Then
            Dim DBEmployee = IDQuery.First
            txtID.Text = DBEmployee.ID
            txtFirstName.Text = DBEmployee.FirstName
            txtLastName.Text = DBEmployee.LastName
            txtMiddle.Text = DBEmployee.MiddleInitial
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

            BtnSaveEmployee.Enabled = False
            BtnUpdate.Enabled = True
            Return
        Else
            MessageBox.Show("That ID cannot be found! Please try another ID!", "ID Not Found")
        End If
    End Sub

    Private Sub CloseApp() Handles ExitToolStripMenuItem.Click 'close the application
        End
    End Sub

    Private Sub OpenFile() Handles OpenToolStripMenuItem.Click 'Code for open option on menustrip
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

    Function IDInFile(ID As String) As Boolean 'Checks whether given ID is in the Employees.txt
        If File.Exists("Employees.txt") Then
            Dim sr As StreamReader = File.OpenText("Employees.txt")
            Dim IDCheck As String
            Do Until sr.EndOfStream
                IDCheck = sr.ReadLine
                If IDCheck(0) = ID Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function
End Class
