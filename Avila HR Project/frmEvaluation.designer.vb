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
        Me.gbox1 = New System.Windows.Forms.GroupBox()
        Me.RB1_U = New System.Windows.Forms.RadioButton()
        Me.RB1_5 = New System.Windows.Forms.RadioButton()
        Me.RB1_4 = New System.Windows.Forms.RadioButton()
        Me.RB1_3 = New System.Windows.Forms.RadioButton()
        Me.RB1_2 = New System.Windows.Forms.RadioButton()
        Me.RB1_1 = New System.Windows.Forms.RadioButton()
        Me.lblVision = New System.Windows.Forms.Label()
        Me.gboxRatingScale = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblU = New System.Windows.Forms.Label()
        Me.lblRatingScale = New System.Windows.Forms.Label()
        Me.gbox2 = New System.Windows.Forms.GroupBox()
        Me.RB2_U = New System.Windows.Forms.RadioButton()
        Me.RB2_5 = New System.Windows.Forms.RadioButton()
        Me.RB2_4 = New System.Windows.Forms.RadioButton()
        Me.RB2_3 = New System.Windows.Forms.RadioButton()
        Me.RB2_2 = New System.Windows.Forms.RadioButton()
        Me.RB2_1 = New System.Windows.Forms.RadioButton()
        Me.lblJudgment = New System.Windows.Forms.Label()
        Me.gbox3 = New System.Windows.Forms.GroupBox()
        Me.RB3_U = New System.Windows.Forms.RadioButton()
        Me.RB3_5 = New System.Windows.Forms.RadioButton()
        Me.RB3_4 = New System.Windows.Forms.RadioButton()
        Me.RB3_3 = New System.Windows.Forms.RadioButton()
        Me.RB3_2 = New System.Windows.Forms.RadioButton()
        Me.RB3_1 = New System.Windows.Forms.RadioButton()
        Me.lblInterpersonal = New System.Windows.Forms.Label()
        Me.gbox4 = New System.Windows.Forms.GroupBox()
        Me.RB4_U = New System.Windows.Forms.RadioButton()
        Me.RB4_5 = New System.Windows.Forms.RadioButton()
        Me.RB4_4 = New System.Windows.Forms.RadioButton()
        Me.RB4_3 = New System.Windows.Forms.RadioButton()
        Me.RB4_2 = New System.Windows.Forms.RadioButton()
        Me.RB4_1 = New System.Windows.Forms.RadioButton()
        Me.lblKnowledge = New System.Windows.Forms.Label()
        Me.gbox5 = New System.Windows.Forms.GroupBox()
        Me.RB5_U = New System.Windows.Forms.RadioButton()
        Me.RB5_5 = New System.Windows.Forms.RadioButton()
        Me.RB5_4 = New System.Windows.Forms.RadioButton()
        Me.RB5_3 = New System.Windows.Forms.RadioButton()
        Me.RB5_2 = New System.Windows.Forms.RadioButton()
        Me.RB5_1 = New System.Windows.Forms.RadioButton()
        Me.lblCommunications = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.gbox1.SuspendLayout()
        Me.gboxRatingScale.SuspendLayout()
        Me.gbox2.SuspendLayout()
        Me.gbox3.SuspendLayout()
        Me.gbox4.SuspendLayout()
        Me.gbox5.SuspendLayout()
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
        Me.txtID.TabIndex = 0
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
        Me.lblName.Location = New System.Drawing.Point(13, 129)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 13)
        Me.lblName.TabIndex = 101
        Me.lblName.Text = "Employee Name"
        '
        'lblJobPosition
        '
        Me.lblJobPosition.AutoSize = True
        Me.lblJobPosition.Location = New System.Drawing.Point(13, 160)
        Me.lblJobPosition.Name = "lblJobPosition"
        Me.lblJobPosition.Size = New System.Drawing.Size(44, 13)
        Me.lblJobPosition.TabIndex = 101
        Me.lblJobPosition.Text = "Position"
        '
        'lbldepartment
        '
        Me.lbldepartment.AutoSize = True
        Me.lbldepartment.Location = New System.Drawing.Point(13, 191)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.Size = New System.Drawing.Size(62, 13)
        Me.lbldepartment.TabIndex = 101
        Me.lbldepartment.Text = "Department"
        '
        'lblInterviewer
        '
        Me.lblInterviewer.AutoSize = True
        Me.lblInterviewer.Location = New System.Drawing.Point(13, 222)
        Me.lblInterviewer.Name = "lblInterviewer"
        Me.lblInterviewer.Size = New System.Drawing.Size(59, 13)
        Me.lblInterviewer.TabIndex = 101
        Me.lblInterviewer.Text = "Interviewer"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(103, 126)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(169, 20)
        Me.txtEmployeeName.TabIndex = 1
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(103, 157)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(169, 20)
        Me.txtPosition.TabIndex = 2
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(103, 188)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(169, 20)
        Me.txtDepartment.TabIndex = 3
        '
        'txtInterviewer
        '
        Me.txtInterviewer.Location = New System.Drawing.Point(103, 219)
        Me.txtInterviewer.Name = "txtInterviewer"
        Me.txtInterviewer.Size = New System.Drawing.Size(169, 20)
        Me.txtInterviewer.TabIndex = 4
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(13, 96)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(241, 26)
        Me.lblInformation.TabIndex = 104
        Me.lblInformation.Text = "Candidate's Information"
        '
        'gbox1
        '
        Me.gbox1.Controls.Add(Me.RB1_U)
        Me.gbox1.Controls.Add(Me.RB1_5)
        Me.gbox1.Controls.Add(Me.RB1_4)
        Me.gbox1.Controls.Add(Me.RB1_3)
        Me.gbox1.Controls.Add(Me.RB1_2)
        Me.gbox1.Controls.Add(Me.RB1_1)
        Me.gbox1.Controls.Add(Me.lblVision)
        Me.gbox1.Location = New System.Drawing.Point(15, 258)
        Me.gbox1.Name = "gbox1"
        Me.gbox1.Size = New System.Drawing.Size(721, 46)
        Me.gbox1.TabIndex = 5
        Me.gbox1.TabStop = False
        '
        'RB1_U
        '
        Me.RB1_U.AutoSize = True
        Me.RB1_U.Location = New System.Drawing.Point(621, 16)
        Me.RB1_U.Name = "RB1_U"
        Me.RB1_U.Size = New System.Drawing.Size(33, 17)
        Me.RB1_U.TabIndex = 3
        Me.RB1_U.Text = "U"
        Me.RB1_U.UseVisualStyleBackColor = True
        '
        'RB1_5
        '
        Me.RB1_5.AutoSize = True
        Me.RB1_5.Location = New System.Drawing.Point(539, 16)
        Me.RB1_5.Name = "RB1_5"
        Me.RB1_5.Size = New System.Drawing.Size(31, 17)
        Me.RB1_5.TabIndex = 3
        Me.RB1_5.Text = "5"
        Me.RB1_5.UseVisualStyleBackColor = True
        '
        'RB1_4
        '
        Me.RB1_4.AutoSize = True
        Me.RB1_4.Location = New System.Drawing.Point(457, 16)
        Me.RB1_4.Name = "RB1_4"
        Me.RB1_4.Size = New System.Drawing.Size(31, 17)
        Me.RB1_4.TabIndex = 3
        Me.RB1_4.Text = "4"
        Me.RB1_4.UseVisualStyleBackColor = True
        '
        'RB1_3
        '
        Me.RB1_3.AutoSize = True
        Me.RB1_3.Location = New System.Drawing.Point(375, 16)
        Me.RB1_3.Name = "RB1_3"
        Me.RB1_3.Size = New System.Drawing.Size(31, 17)
        Me.RB1_3.TabIndex = 3
        Me.RB1_3.Text = "3"
        Me.RB1_3.UseVisualStyleBackColor = True
        '
        'RB1_2
        '
        Me.RB1_2.AutoSize = True
        Me.RB1_2.Location = New System.Drawing.Point(293, 16)
        Me.RB1_2.Name = "RB1_2"
        Me.RB1_2.Size = New System.Drawing.Size(31, 17)
        Me.RB1_2.TabIndex = 2
        Me.RB1_2.Text = "2"
        Me.RB1_2.UseVisualStyleBackColor = True
        '
        'RB1_1
        '
        Me.RB1_1.AutoSize = True
        Me.RB1_1.Location = New System.Drawing.Point(211, 16)
        Me.RB1_1.Name = "RB1_1"
        Me.RB1_1.Size = New System.Drawing.Size(31, 17)
        Me.RB1_1.TabIndex = 1
        Me.RB1_1.Text = "1"
        Me.RB1_1.UseVisualStyleBackColor = True
        '
        'lblVision
        '
        Me.lblVision.AutoSize = True
        Me.lblVision.Location = New System.Drawing.Point(3, 17)
        Me.lblVision.Name = "lblVision"
        Me.lblVision.Size = New System.Drawing.Size(136, 13)
        Me.lblVision.TabIndex = 0
        Me.lblVision.Text = "Vision and Leadership skills"
        '
        'gboxRatingScale
        '
        Me.gboxRatingScale.BackColor = System.Drawing.Color.LightBlue
        Me.gboxRatingScale.Controls.Add(Me.lbl1)
        Me.gboxRatingScale.Controls.Add(Me.lbl2)
        Me.gboxRatingScale.Controls.Add(Me.lbl3)
        Me.gboxRatingScale.Controls.Add(Me.lbl4)
        Me.gboxRatingScale.Controls.Add(Me.lbl5)
        Me.gboxRatingScale.Controls.Add(Me.lblU)
        Me.gboxRatingScale.Controls.Add(Me.lblRatingScale)
        Me.gboxRatingScale.Location = New System.Drawing.Point(450, 97)
        Me.gboxRatingScale.Name = "gboxRatingScale"
        Me.gboxRatingScale.Size = New System.Drawing.Size(283, 155)
        Me.gboxRatingScale.TabIndex = 1
        Me.gboxRatingScale.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(11, 139)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(47, 13)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "1 = Poor"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(11, 118)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(127, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "2 = Less than acceptable"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(11, 97)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(79, 13)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "3 = Acceptable"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(11, 76)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(129, 13)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "4 = More than acceptable"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(11, 55)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(68, 13)
        Me.lbl5.TabIndex = 2
        Me.lbl5.Text = "5 = Excellent"
        '
        'lblU
        '
        Me.lblU.AutoSize = True
        Me.lblU.Location = New System.Drawing.Point(11, 34)
        Me.lblU.Name = "lblU"
        Me.lblU.Size = New System.Drawing.Size(118, 13)
        Me.lblU.TabIndex = 1
        Me.lblU.Text = "U = Unable to Evaluate"
        '
        'lblRatingScale
        '
        Me.lblRatingScale.AutoSize = True
        Me.lblRatingScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingScale.Location = New System.Drawing.Point(91, 13)
        Me.lblRatingScale.Name = "lblRatingScale"
        Me.lblRatingScale.Size = New System.Drawing.Size(100, 20)
        Me.lblRatingScale.TabIndex = 0
        Me.lblRatingScale.Text = "Rating Scale"
        '
        'gbox2
        '
        Me.gbox2.Controls.Add(Me.RB2_U)
        Me.gbox2.Controls.Add(Me.RB2_5)
        Me.gbox2.Controls.Add(Me.RB2_4)
        Me.gbox2.Controls.Add(Me.RB2_3)
        Me.gbox2.Controls.Add(Me.RB2_2)
        Me.gbox2.Controls.Add(Me.RB2_1)
        Me.gbox2.Controls.Add(Me.lblJudgment)
        Me.gbox2.Location = New System.Drawing.Point(15, 310)
        Me.gbox2.Name = "gbox2"
        Me.gbox2.Size = New System.Drawing.Size(721, 46)
        Me.gbox2.TabIndex = 6
        Me.gbox2.TabStop = False
        '
        'RB2_U
        '
        Me.RB2_U.AutoSize = True
        Me.RB2_U.Location = New System.Drawing.Point(621, 16)
        Me.RB2_U.Name = "RB2_U"
        Me.RB2_U.Size = New System.Drawing.Size(33, 17)
        Me.RB2_U.TabIndex = 3
        Me.RB2_U.Text = "U"
        Me.RB2_U.UseVisualStyleBackColor = True
        '
        'RB2_5
        '
        Me.RB2_5.AutoSize = True
        Me.RB2_5.Location = New System.Drawing.Point(539, 16)
        Me.RB2_5.Name = "RB2_5"
        Me.RB2_5.Size = New System.Drawing.Size(31, 17)
        Me.RB2_5.TabIndex = 3
        Me.RB2_5.Text = "5"
        Me.RB2_5.UseVisualStyleBackColor = True
        '
        'RB2_4
        '
        Me.RB2_4.AutoSize = True
        Me.RB2_4.Location = New System.Drawing.Point(457, 16)
        Me.RB2_4.Name = "RB2_4"
        Me.RB2_4.Size = New System.Drawing.Size(31, 17)
        Me.RB2_4.TabIndex = 3
        Me.RB2_4.Text = "4"
        Me.RB2_4.UseVisualStyleBackColor = True
        '
        'RB2_3
        '
        Me.RB2_3.AutoSize = True
        Me.RB2_3.Location = New System.Drawing.Point(375, 16)
        Me.RB2_3.Name = "RB2_3"
        Me.RB2_3.Size = New System.Drawing.Size(31, 17)
        Me.RB2_3.TabIndex = 3
        Me.RB2_3.Text = "3"
        Me.RB2_3.UseVisualStyleBackColor = True
        '
        'RB2_2
        '
        Me.RB2_2.AutoSize = True
        Me.RB2_2.Location = New System.Drawing.Point(293, 16)
        Me.RB2_2.Name = "RB2_2"
        Me.RB2_2.Size = New System.Drawing.Size(31, 17)
        Me.RB2_2.TabIndex = 2
        Me.RB2_2.Text = "2"
        Me.RB2_2.UseVisualStyleBackColor = True
        '
        'RB2_1
        '
        Me.RB2_1.AutoSize = True
        Me.RB2_1.Location = New System.Drawing.Point(211, 16)
        Me.RB2_1.Name = "RB2_1"
        Me.RB2_1.Size = New System.Drawing.Size(31, 17)
        Me.RB2_1.TabIndex = 1
        Me.RB2_1.Text = "1"
        Me.RB2_1.UseVisualStyleBackColor = True
        '
        'lblJudgment
        '
        Me.lblJudgment.AutoSize = True
        Me.lblJudgment.Location = New System.Drawing.Point(3, 17)
        Me.lblJudgment.Name = "lblJudgment"
        Me.lblJudgment.Size = New System.Drawing.Size(183, 13)
        Me.lblJudgment.TabIndex = 0
        Me.lblJudgment.Text = "Judgment and Decision Making Skills"
        '
        'gbox3
        '
        Me.gbox3.Controls.Add(Me.RB3_U)
        Me.gbox3.Controls.Add(Me.RB3_5)
        Me.gbox3.Controls.Add(Me.RB3_4)
        Me.gbox3.Controls.Add(Me.RB3_3)
        Me.gbox3.Controls.Add(Me.RB3_2)
        Me.gbox3.Controls.Add(Me.RB3_1)
        Me.gbox3.Controls.Add(Me.lblInterpersonal)
        Me.gbox3.Location = New System.Drawing.Point(15, 362)
        Me.gbox3.Name = "gbox3"
        Me.gbox3.Size = New System.Drawing.Size(721, 46)
        Me.gbox3.TabIndex = 7
        Me.gbox3.TabStop = False
        '
        'RB3_U
        '
        Me.RB3_U.AutoSize = True
        Me.RB3_U.Location = New System.Drawing.Point(621, 16)
        Me.RB3_U.Name = "RB3_U"
        Me.RB3_U.Size = New System.Drawing.Size(33, 17)
        Me.RB3_U.TabIndex = 3
        Me.RB3_U.Text = "U"
        Me.RB3_U.UseVisualStyleBackColor = True
        '
        'RB3_5
        '
        Me.RB3_5.AutoSize = True
        Me.RB3_5.Location = New System.Drawing.Point(539, 16)
        Me.RB3_5.Name = "RB3_5"
        Me.RB3_5.Size = New System.Drawing.Size(31, 17)
        Me.RB3_5.TabIndex = 3
        Me.RB3_5.Text = "5"
        Me.RB3_5.UseVisualStyleBackColor = True
        '
        'RB3_4
        '
        Me.RB3_4.AutoSize = True
        Me.RB3_4.Location = New System.Drawing.Point(457, 16)
        Me.RB3_4.Name = "RB3_4"
        Me.RB3_4.Size = New System.Drawing.Size(31, 17)
        Me.RB3_4.TabIndex = 3
        Me.RB3_4.Text = "4"
        Me.RB3_4.UseVisualStyleBackColor = True
        '
        'RB3_3
        '
        Me.RB3_3.AutoSize = True
        Me.RB3_3.Location = New System.Drawing.Point(375, 16)
        Me.RB3_3.Name = "RB3_3"
        Me.RB3_3.Size = New System.Drawing.Size(31, 17)
        Me.RB3_3.TabIndex = 3
        Me.RB3_3.Text = "3"
        Me.RB3_3.UseVisualStyleBackColor = True
        '
        'RB3_2
        '
        Me.RB3_2.AutoSize = True
        Me.RB3_2.Location = New System.Drawing.Point(293, 16)
        Me.RB3_2.Name = "RB3_2"
        Me.RB3_2.Size = New System.Drawing.Size(31, 17)
        Me.RB3_2.TabIndex = 2
        Me.RB3_2.Text = "2"
        Me.RB3_2.UseVisualStyleBackColor = True
        '
        'RB3_1
        '
        Me.RB3_1.AutoSize = True
        Me.RB3_1.Location = New System.Drawing.Point(211, 16)
        Me.RB3_1.Name = "RB3_1"
        Me.RB3_1.Size = New System.Drawing.Size(31, 17)
        Me.RB3_1.TabIndex = 1
        Me.RB3_1.Text = "1"
        Me.RB3_1.UseVisualStyleBackColor = True
        '
        'lblInterpersonal
        '
        Me.lblInterpersonal.AutoSize = True
        Me.lblInterpersonal.Location = New System.Drawing.Point(3, 17)
        Me.lblInterpersonal.Name = "lblInterpersonal"
        Me.lblInterpersonal.Size = New System.Drawing.Size(95, 13)
        Me.lblInterpersonal.TabIndex = 0
        Me.lblInterpersonal.Text = "Interpersonal Skills"
        '
        'gbox4
        '
        Me.gbox4.Controls.Add(Me.RB4_U)
        Me.gbox4.Controls.Add(Me.RB4_5)
        Me.gbox4.Controls.Add(Me.RB4_4)
        Me.gbox4.Controls.Add(Me.RB4_3)
        Me.gbox4.Controls.Add(Me.RB4_2)
        Me.gbox4.Controls.Add(Me.RB4_1)
        Me.gbox4.Controls.Add(Me.lblKnowledge)
        Me.gbox4.Location = New System.Drawing.Point(15, 414)
        Me.gbox4.Name = "gbox4"
        Me.gbox4.Size = New System.Drawing.Size(721, 46)
        Me.gbox4.TabIndex = 8
        Me.gbox4.TabStop = False
        '
        'RB4_U
        '
        Me.RB4_U.AutoSize = True
        Me.RB4_U.Location = New System.Drawing.Point(621, 16)
        Me.RB4_U.Name = "RB4_U"
        Me.RB4_U.Size = New System.Drawing.Size(33, 17)
        Me.RB4_U.TabIndex = 3
        Me.RB4_U.Text = "U"
        Me.RB4_U.UseVisualStyleBackColor = True
        '
        'RB4_5
        '
        Me.RB4_5.AutoSize = True
        Me.RB4_5.Location = New System.Drawing.Point(539, 16)
        Me.RB4_5.Name = "RB4_5"
        Me.RB4_5.Size = New System.Drawing.Size(31, 17)
        Me.RB4_5.TabIndex = 3
        Me.RB4_5.Text = "5"
        Me.RB4_5.UseVisualStyleBackColor = True
        '
        'RB4_4
        '
        Me.RB4_4.AutoSize = True
        Me.RB4_4.Location = New System.Drawing.Point(457, 16)
        Me.RB4_4.Name = "RB4_4"
        Me.RB4_4.Size = New System.Drawing.Size(31, 17)
        Me.RB4_4.TabIndex = 3
        Me.RB4_4.Text = "4"
        Me.RB4_4.UseVisualStyleBackColor = True
        '
        'RB4_3
        '
        Me.RB4_3.AutoSize = True
        Me.RB4_3.Location = New System.Drawing.Point(375, 16)
        Me.RB4_3.Name = "RB4_3"
        Me.RB4_3.Size = New System.Drawing.Size(31, 17)
        Me.RB4_3.TabIndex = 3
        Me.RB4_3.Text = "3"
        Me.RB4_3.UseVisualStyleBackColor = True
        '
        'RB4_2
        '
        Me.RB4_2.AutoSize = True
        Me.RB4_2.Location = New System.Drawing.Point(293, 16)
        Me.RB4_2.Name = "RB4_2"
        Me.RB4_2.Size = New System.Drawing.Size(31, 17)
        Me.RB4_2.TabIndex = 2
        Me.RB4_2.Text = "2"
        Me.RB4_2.UseVisualStyleBackColor = True
        '
        'RB4_1
        '
        Me.RB4_1.AutoSize = True
        Me.RB4_1.Location = New System.Drawing.Point(211, 16)
        Me.RB4_1.Name = "RB4_1"
        Me.RB4_1.Size = New System.Drawing.Size(31, 17)
        Me.RB4_1.TabIndex = 1
        Me.RB4_1.Text = "1"
        Me.RB4_1.UseVisualStyleBackColor = True
        '
        'lblKnowledge
        '
        Me.lblKnowledge.AutoSize = True
        Me.lblKnowledge.Location = New System.Drawing.Point(3, 17)
        Me.lblKnowledge.Name = "lblKnowledge"
        Me.lblKnowledge.Size = New System.Drawing.Size(178, 13)
        Me.lblKnowledge.TabIndex = 0
        Me.lblKnowledge.Text = "Knowledge about Areas of Specialty"
        '
        'gbox5
        '
        Me.gbox5.Controls.Add(Me.RB5_U)
        Me.gbox5.Controls.Add(Me.RB5_5)
        Me.gbox5.Controls.Add(Me.RB5_4)
        Me.gbox5.Controls.Add(Me.RB5_3)
        Me.gbox5.Controls.Add(Me.RB5_2)
        Me.gbox5.Controls.Add(Me.RB5_1)
        Me.gbox5.Controls.Add(Me.lblCommunications)
        Me.gbox5.Location = New System.Drawing.Point(15, 466)
        Me.gbox5.Name = "gbox5"
        Me.gbox5.Size = New System.Drawing.Size(721, 46)
        Me.gbox5.TabIndex = 9
        Me.gbox5.TabStop = False
        '
        'RB5_U
        '
        Me.RB5_U.AutoSize = True
        Me.RB5_U.Location = New System.Drawing.Point(621, 16)
        Me.RB5_U.Name = "RB5_U"
        Me.RB5_U.Size = New System.Drawing.Size(33, 17)
        Me.RB5_U.TabIndex = 3
        Me.RB5_U.Text = "U"
        Me.RB5_U.UseVisualStyleBackColor = True
        '
        'RB5_5
        '
        Me.RB5_5.AutoSize = True
        Me.RB5_5.Location = New System.Drawing.Point(539, 16)
        Me.RB5_5.Name = "RB5_5"
        Me.RB5_5.Size = New System.Drawing.Size(31, 17)
        Me.RB5_5.TabIndex = 3
        Me.RB5_5.Text = "5"
        Me.RB5_5.UseVisualStyleBackColor = True
        '
        'RB5_4
        '
        Me.RB5_4.AutoSize = True
        Me.RB5_4.Location = New System.Drawing.Point(457, 16)
        Me.RB5_4.Name = "RB5_4"
        Me.RB5_4.Size = New System.Drawing.Size(31, 17)
        Me.RB5_4.TabIndex = 3
        Me.RB5_4.Text = "4"
        Me.RB5_4.UseVisualStyleBackColor = True
        '
        'RB5_3
        '
        Me.RB5_3.AutoSize = True
        Me.RB5_3.Location = New System.Drawing.Point(375, 16)
        Me.RB5_3.Name = "RB5_3"
        Me.RB5_3.Size = New System.Drawing.Size(31, 17)
        Me.RB5_3.TabIndex = 3
        Me.RB5_3.Text = "3"
        Me.RB5_3.UseVisualStyleBackColor = True
        '
        'RB5_2
        '
        Me.RB5_2.AutoSize = True
        Me.RB5_2.Location = New System.Drawing.Point(293, 16)
        Me.RB5_2.Name = "RB5_2"
        Me.RB5_2.Size = New System.Drawing.Size(31, 17)
        Me.RB5_2.TabIndex = 2
        Me.RB5_2.Text = "2"
        Me.RB5_2.UseVisualStyleBackColor = True
        '
        'RB5_1
        '
        Me.RB5_1.AutoSize = True
        Me.RB5_1.Location = New System.Drawing.Point(211, 16)
        Me.RB5_1.Name = "RB5_1"
        Me.RB5_1.Size = New System.Drawing.Size(31, 17)
        Me.RB5_1.TabIndex = 1
        Me.RB5_1.Text = "1"
        Me.RB5_1.UseVisualStyleBackColor = True
        '
        'lblCommunications
        '
        Me.lblCommunications.AutoSize = True
        Me.lblCommunications.Location = New System.Drawing.Point(3, 17)
        Me.lblCommunications.Name = "lblCommunications"
        Me.lblCommunications.Size = New System.Drawing.Size(84, 13)
        Me.lblCommunications.TabIndex = 0
        Me.lblCommunications.Text = "Communications"
        '
        'frmEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(840, 569)
        Me.Controls.Add(Me.gboxRatingScale)
        Me.Controls.Add(Me.gbox5)
        Me.Controls.Add(Me.gbox4)
        Me.Controls.Add(Me.gbox3)
        Me.Controls.Add(Me.gbox2)
        Me.Controls.Add(Me.gbox1)
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
        Me.gbox1.ResumeLayout(False)
        Me.gbox1.PerformLayout()
        Me.gboxRatingScale.ResumeLayout(False)
        Me.gboxRatingScale.PerformLayout()
        Me.gbox2.ResumeLayout(False)
        Me.gbox2.PerformLayout()
        Me.gbox3.ResumeLayout(False)
        Me.gbox3.PerformLayout()
        Me.gbox4.ResumeLayout(False)
        Me.gbox4.PerformLayout()
        Me.gbox5.ResumeLayout(False)
        Me.gbox5.PerformLayout()
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
    Friend WithEvents gbox1 As GroupBox
    Friend WithEvents lblVision As Label
    Friend WithEvents gboxRatingScale As GroupBox
    Friend WithEvents lblRatingScale As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents RB1_3 As RadioButton
    Friend WithEvents RB1_2 As RadioButton
    Friend WithEvents RB1_1 As RadioButton
    Friend WithEvents RB1_U As RadioButton
    Friend WithEvents RB1_5 As RadioButton
    Friend WithEvents RB1_4 As RadioButton
    Friend WithEvents gbox2 As GroupBox
    Friend WithEvents RB2_U As RadioButton
    Friend WithEvents RB2_5 As RadioButton
    Friend WithEvents RB2_4 As RadioButton
    Friend WithEvents RB2_3 As RadioButton
    Friend WithEvents RB2_2 As RadioButton
    Friend WithEvents RB2_1 As RadioButton
    Friend WithEvents lblJudgment As Label
    Friend WithEvents gbox3 As GroupBox
    Friend WithEvents RB3_U As RadioButton
    Friend WithEvents RB3_5 As RadioButton
    Friend WithEvents RB3_4 As RadioButton
    Friend WithEvents RB3_3 As RadioButton
    Friend WithEvents RB3_2 As RadioButton
    Friend WithEvents RB3_1 As RadioButton
    Friend WithEvents lblInterpersonal As Label
    Friend WithEvents gbox4 As GroupBox
    Friend WithEvents RB4_U As RadioButton
    Friend WithEvents RB4_5 As RadioButton
    Friend WithEvents RB4_4 As RadioButton
    Friend WithEvents RB4_3 As RadioButton
    Friend WithEvents RB4_2 As RadioButton
    Friend WithEvents RB4_1 As RadioButton
    Friend WithEvents lblKnowledge As Label
    Friend WithEvents gbox5 As GroupBox
    Friend WithEvents RB5_U As RadioButton
    Friend WithEvents RB5_5 As RadioButton
    Friend WithEvents RB5_4 As RadioButton
    Friend WithEvents RB5_3 As RadioButton
    Friend WithEvents RB5_2 As RadioButton
    Friend WithEvents RB5_1 As RadioButton
    Friend WithEvents lblCommunications As Label
End Class
