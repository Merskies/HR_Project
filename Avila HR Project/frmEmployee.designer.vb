<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMainPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnNewEmployee = New System.Windows.Forms.Button()
        Me.BtnSaveEmployee = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.dvgEmployee = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAptRoom = New System.Windows.Forms.TextBox()
        Me.lblAptRoom = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblAltPhone = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtMaritalStatus = New System.Windows.Forms.TextBox()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDateRecorded = New System.Windows.Forms.Label()
        Me.txtDateRecorded = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.txtMainPhone = New System.Windows.Forms.TextBox()
        Me.txtAltPhone = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        CType(Me.dvgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(132, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(161, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(63, 111)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(299, 111)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name:"
        '
        'lblMainPhone
        '
        Me.lblMainPhone.AutoSize = True
        Me.lblMainPhone.Location = New System.Drawing.Point(63, 213)
        Me.lblMainPhone.Name = "lblMainPhone"
        Me.lblMainPhone.Size = New System.Drawing.Size(67, 13)
        Me.lblMainPhone.TabIndex = 1
        Me.lblMainPhone.Text = "Main Phone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(63, 247)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(368, 108)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(161, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(132, 248)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(643, 20)
        Me.txtEmail.TabIndex = 11
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(573, 390)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisplay.TabIndex = 22
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnNewEmployee
        '
        Me.BtnNewEmployee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNewEmployee.Location = New System.Drawing.Point(291, 390)
        Me.BtnNewEmployee.Name = "BtnNewEmployee"
        Me.BtnNewEmployee.Size = New System.Drawing.Size(87, 23)
        Me.BtnNewEmployee.TabIndex = 19
        Me.BtnNewEmployee.Text = "New Employee"
        Me.BtnNewEmployee.UseVisualStyleBackColor = False
        '
        'BtnSaveEmployee
        '
        Me.BtnSaveEmployee.Location = New System.Drawing.Point(393, 390)
        Me.BtnSaveEmployee.Name = "BtnSaveEmployee"
        Me.BtnSaveEmployee.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveEmployee.TabIndex = 20
        Me.BtnSaveEmployee.Text = "Save"
        Me.BtnSaveEmployee.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSearch.Location = New System.Drawing.Point(663, 390)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 23
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnUpdate.Location = New System.Drawing.Point(483, 390)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'dvgEmployee
        '
        Me.dvgEmployee.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dvgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgEmployee.Location = New System.Drawing.Point(13, 419)
        Me.dvgEmployee.Name = "dvgEmployee"
        Me.dvgEmployee.Size = New System.Drawing.Size(816, 138)
        Me.dvgEmployee.TabIndex = 7
        Me.dvgEmployee.TabStop = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(39, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(75, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(614, 108)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(161, 20)
        Me.txtMiddle.TabIndex = 3
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Location = New System.Drawing.Point(535, 111)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(68, 13)
        Me.lblMiddle.TabIndex = 1
        Me.lblMiddle.Text = "Middle Initial:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(132, 143)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(397, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(63, 145)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'txtAptRoom
        '
        Me.txtAptRoom.Location = New System.Drawing.Point(614, 142)
        Me.txtAptRoom.Name = "txtAptRoom"
        Me.txtAptRoom.Size = New System.Drawing.Size(161, 20)
        Me.txtAptRoom.TabIndex = 5
        '
        'lblAptRoom
        '
        Me.lblAptRoom.AutoSize = True
        Me.lblAptRoom.Location = New System.Drawing.Point(533, 145)
        Me.lblAptRoom.Name = "lblAptRoom"
        Me.lblAptRoom.Size = New System.Drawing.Size(75, 13)
        Me.lblAptRoom.TabIndex = 1
        Me.lblAptRoom.Text = "Apt / Room #:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(132, 178)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(161, 20)
        Me.txtCity.TabIndex = 6
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(63, 179)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(299, 181)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "State:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(535, 181)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(53, 13)
        Me.lblZip.TabIndex = 1
        Me.lblZip.Text = "Zip Code:"
        '
        'lblAltPhone
        '
        Me.lblAltPhone.AutoSize = True
        Me.lblAltPhone.Location = New System.Drawing.Point(299, 213)
        Me.lblAltPhone.Name = "lblAltPhone"
        Me.lblAltPhone.Size = New System.Drawing.Size(59, 13)
        Me.lblAltPhone.TabIndex = 1
        Me.lblAltPhone.Text = "Alt. Phone:"
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(155, 283)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(620, 20)
        Me.txtSSN.TabIndex = 12
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(63, 281)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(86, 13)
        Me.lblSSN.TabIndex = 1
        Me.lblSSN.Text = "SSN or Gov't ID:"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(63, 315)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(57, 13)
        Me.lblBirthday.TabIndex = 1
        Me.lblBirthday.Text = "Birth Date:"
        '
        'txtMaritalStatus
        '
        Me.txtMaritalStatus.Location = New System.Drawing.Point(379, 316)
        Me.txtMaritalStatus.Name = "txtMaritalStatus"
        Me.txtMaritalStatus.Size = New System.Drawing.Size(150, 20)
        Me.txtMaritalStatus.TabIndex = 14
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.Location = New System.Drawing.Point(299, 319)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblMaritalStatus.TabIndex = 1
        Me.lblMaritalStatus.Text = "Marital Status:"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(614, 316)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(161, 20)
        Me.txtGender.TabIndex = 15
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(535, 319)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(248, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(344, 55)
        Me.lblTitle.TabIndex = 99
        Me.lblTitle.Text = "Employee Info"
        '
        'btnSwitch
        '
        Me.btnSwitch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSwitch.Location = New System.Drawing.Point(87, 390)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(87, 23)
        Me.btnSwitch.TabIndex = 17
        Me.btnSwitch.Text = "Switch Form"
        Me.btnSwitch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(189, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear Boxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip.TabIndex = 100
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchFormToolStripMenuItem, Me.ClearBoxesToolStripMenuItem, Me.NewEmployeeToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SwitchFormToolStripMenuItem
        '
        Me.SwitchFormToolStripMenuItem.Name = "SwitchFormToolStripMenuItem"
        Me.SwitchFormToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SwitchFormToolStripMenuItem.Text = "Switch Form"
        '
        'ClearBoxesToolStripMenuItem
        '
        Me.ClearBoxesToolStripMenuItem.Name = "ClearBoxesToolStripMenuItem"
        Me.ClearBoxesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ClearBoxesToolStripMenuItem.Text = "Clear Boxes"
        '
        'NewEmployeeToolStripMenuItem
        '
        Me.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem"
        Me.NewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewEmployeeToolStripMenuItem.Text = "New Employee"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'lblDateRecorded
        '
        Me.lblDateRecorded.AutoSize = True
        Me.lblDateRecorded.Location = New System.Drawing.Point(63, 350)
        Me.lblDateRecorded.Name = "lblDateRecorded"
        Me.lblDateRecorded.Size = New System.Drawing.Size(80, 13)
        Me.lblDateRecorded.TabIndex = 101
        Me.lblDateRecorded.Text = "Date Recorded"
        '
        'txtDateRecorded
        '
        Me.txtDateRecorded.Location = New System.Drawing.Point(149, 347)
        Me.txtDateRecorded.Name = "txtDateRecorded"
        Me.txtDateRecorded.ReadOnly = True
        Me.txtDateRecorded.Size = New System.Drawing.Size(626, 20)
        Me.txtDateRecorded.TabIndex = 16
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(132, 315)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(161, 20)
        Me.txtBirthday.TabIndex = 6
        '
        'txtMainPhone
        '
        Me.txtMainPhone.Location = New System.Drawing.Point(132, 213)
        Me.txtMainPhone.Name = "txtMainPhone"
        Me.txtMainPhone.Size = New System.Drawing.Size(161, 20)
        Me.txtMainPhone.TabIndex = 6
        '
        'txtAltPhone
        '
        Me.txtAltPhone.Location = New System.Drawing.Point(368, 213)
        Me.txtAltPhone.Name = "txtAltPhone"
        Me.txtAltPhone.Size = New System.Drawing.Size(407, 20)
        Me.txtAltPhone.TabIndex = 6
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(614, 176)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(161, 20)
        Me.txtZipCode.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(368, 176)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(161, 20)
        Me.txtState.TabIndex = 5
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(840, 569)
        Me.Controls.Add(Me.txtDateRecorded)
        Me.Controls.Add(Me.lblDateRecorded)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dvgEmployee)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnSaveEmployee)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnNewEmployee)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAltPhone)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblMaritalStatus)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblMainPhone)
        Me.Controls.Add(Me.lblAptRoom)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtAptRoom)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtMaritalStatus)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtAltPhone)
        Me.Controls.Add(Me.txtMainPhone)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information"
        CType(Me.dvgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMainPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnNewEmployee As Button
    Friend WithEvents BtnSaveEmployee As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents dvgEmployee As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents lblMiddle As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAptRoom As TextBox
    Friend WithEvents lblAptRoom As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblAltPhone As Label
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents lblSSN As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtMaritalStatus As TextBox
    Friend WithEvents lblMaritalStatus As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSwitch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDateRecorded As Label
    Friend WithEvents txtDateRecorded As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwitchFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearBoxesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtMainPhone As TextBox
    Friend WithEvents txtAltPhone As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtState As TextBox
End Class
