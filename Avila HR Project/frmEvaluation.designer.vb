<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvaluation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblJobPosition = New System.Windows.Forms.Label()
        Me.lbldepartment = New System.Windows.Forms.Label()
        Me.lblInterviewer = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtInterviewer = New System.Windows.Forms.TextBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip.TabIndex = 0
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
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchFormToolStripMenuItem, Me.ClearBoxesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SwitchFormToolStripMenuItem
        '
        Me.SwitchFormToolStripMenuItem.Name = "SwitchFormToolStripMenuItem"
        Me.SwitchFormToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SwitchFormToolStripMenuItem.Text = "Switch Form"
        '
        'ClearBoxesToolStripMenuItem
        '
        Me.ClearBoxesToolStripMenuItem.Name = "ClearBoxesToolStripMenuItem"
        Me.ClearBoxesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearBoxesToolStripMenuItem.Text = "Clear Boxes"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(39, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(75, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(248, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 55)
        Me.lblTitle.TabIndex = 100
        Me.lblTitle.Text = "Evaluation"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 129)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 13)
        Me.lblName.TabIndex = 101
        Me.lblName.Text = "Employee Name"
        '
        'lblJobPosition
        '
        Me.lblJobPosition.AutoSize = True
        Me.lblJobPosition.Location = New System.Drawing.Point(12, 168)
        Me.lblJobPosition.Name = "lblJobPosition"
        Me.lblJobPosition.Size = New System.Drawing.Size(44, 13)
        Me.lblJobPosition.TabIndex = 101
        Me.lblJobPosition.Text = "Position"
        '
        'lbldepartment
        '
        Me.lbldepartment.AutoSize = True
        Me.lbldepartment.Location = New System.Drawing.Point(12, 207)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.Size = New System.Drawing.Size(62, 13)
        Me.lbldepartment.TabIndex = 101
        Me.lbldepartment.Text = "Department"
        '
        'lblInterviewer
        '
        Me.lblInterviewer.AutoSize = True
        Me.lblInterviewer.Location = New System.Drawing.Point(12, 246)
        Me.lblInterviewer.Name = "lblInterviewer"
        Me.lblInterviewer.Size = New System.Drawing.Size(59, 13)
        Me.lblInterviewer.TabIndex = 101
        Me.lblInterviewer.Text = "Interviewer"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(102, 126)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(169, 20)
        Me.txtEmployeeName.TabIndex = 103
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(102, 165)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(169, 20)
        Me.txtPosition.TabIndex = 103
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(102, 204)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(169, 20)
        Me.txtDepartment.TabIndex = 103
        '
        'txtInterviewer
        '
        Me.txtInterviewer.Location = New System.Drawing.Point(102, 243)
        Me.txtInterviewer.Name = "txtInterviewer"
        Me.txtInterviewer.Size = New System.Drawing.Size(169, 20)
        Me.txtInterviewer.TabIndex = 103
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Location = New System.Drawing.Point(12, 105)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(117, 13)
        Me.lblInformation.TabIndex = 104
        Me.lblInformation.Text = "Candidate's Information"
        '
        'frmEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(840, 569)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.txtInterviewer)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblInterviewer)
        Me.Controls.Add(Me.lbldepartment)
        Me.Controls.Add(Me.lblJobPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmEvaluation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEvaluation"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwitchFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearBoxesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblJobPosition As Label
    Friend WithEvents lbldepartment As Label
    Friend WithEvents lblInterviewer As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtInterviewer As TextBox
    Friend WithEvents lblInformation As Label
End Class
