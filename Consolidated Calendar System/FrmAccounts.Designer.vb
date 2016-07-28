<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccounts
    Inherits MetroFramework.Forms.MetroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccounts))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tb_lname = New System.Windows.Forms.TextBox()
        Me.tb_mname = New System.Windows.Forms.TextBox()
        Me.tb_fname = New System.Windows.Forms.TextBox()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_usertype = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tb_retypepass = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_uname = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.tb_searchaccount = New System.Windows.Forms.TextBox()
        Me.lb_accounts = New System.Windows.Forms.ListBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.ml_update = New MetroFramework.Controls.MetroLink()
        Me.ml_delete = New MetroFramework.Controls.MetroLink()
        Me.ml_clear = New MetroFramework.Controls.MetroLink()
        Me.ml_save = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mcb_school = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mcb_school)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.tb_lname)
        Me.GroupBox1.Controls.Add(Me.tb_mname)
        Me.GroupBox1.Controls.Add(Me.tb_fname)
        Me.GroupBox1.Controls.Add(Me.tb_id)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.mcb_usertype)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(198, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 255)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(91, 216)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel9.TabIndex = 62
        Me.MetroLabel9.Text = "Last Name:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(72, 177)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel8.TabIndex = 61
        Me.MetroLabel8.Text = "Middle Name:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(133, 20)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel7.TabIndex = 60
        Me.MetroLabel7.Text = "ID#:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(89, 140)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel6.TabIndex = 59
        Me.MetroLabel6.Text = "First Name:"
        '
        'tb_lname
        '
        Me.tb_lname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lname.Location = New System.Drawing.Point(171, 216)
        Me.tb_lname.Name = "tb_lname"
        Me.tb_lname.Size = New System.Drawing.Size(276, 22)
        Me.tb_lname.TabIndex = 58
        '
        'tb_mname
        '
        Me.tb_mname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mname.Location = New System.Drawing.Point(171, 176)
        Me.tb_mname.Name = "tb_mname"
        Me.tb_mname.Size = New System.Drawing.Size(276, 22)
        Me.tb_mname.TabIndex = 57
        '
        'tb_fname
        '
        Me.tb_fname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fname.Location = New System.Drawing.Point(171, 140)
        Me.tb_fname.Name = "tb_fname"
        Me.tb_fname.Size = New System.Drawing.Size(276, 22)
        Me.tb_fname.TabIndex = 56
        '
        'tb_id
        '
        Me.tb_id.AutoCompleteCustomSource.AddRange(New String() {"0-", "1-", "3-", "4-", "5-", "6-", "7-", "8-", "9-", "10-", "11-", "12-", "13-", "14-", "15-", "16-", "17-", "18-", "19-", "20-", "21-", "22-"})
        Me.tb_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_id.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(171, 19)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(276, 22)
        Me.tb_id.TabIndex = 55
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(96, 103)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 54
        Me.MetroLabel2.Text = "User Type:"
        '
        'mcb_usertype
        '
        Me.mcb_usertype.FormattingEnabled = True
        Me.mcb_usertype.ItemHeight = 23
        Me.mcb_usertype.Items.AddRange(New Object() {"-", "Admin", "Guest"})
        Me.mcb_usertype.Location = New System.Drawing.Point(171, 93)
        Me.mcb_usertype.Name = "mcb_usertype"
        Me.mcb_usertype.Size = New System.Drawing.Size(274, 29)
        Me.mcb_usertype.TabIndex = 53
        Me.mcb_usertype.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(33, 68)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel4.TabIndex = 51
        Me.MetroLabel4.Text = "School/Organization:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.tb_retypepass)
        Me.GroupBox2.Controls.Add(Me.tb_password)
        Me.GroupBox2.Controls.Add(Me.tb_uname)
        Me.GroupBox2.Controls.Add(Me.MetroLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(198, 426)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 126)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Details"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(49, 93)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel5.TabIndex = 52
        Me.MetroLabel5.Text = "Re-type Password:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(99, 59)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 51
        Me.MetroLabel3.Text = "Password:"
        '
        'tb_retypepass
        '
        Me.tb_retypepass.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_retypepass.Location = New System.Drawing.Point(171, 93)
        Me.tb_retypepass.Name = "tb_retypepass"
        Me.tb_retypepass.Size = New System.Drawing.Size(276, 22)
        Me.tb_retypepass.TabIndex = 50
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(171, 58)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(276, 22)
        Me.tb_password.TabIndex = 49
        '
        'tb_uname
        '
        Me.tb_uname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_uname.Location = New System.Drawing.Point(171, 18)
        Me.tb_uname.Name = "tb_uname"
        Me.tb_uname.Size = New System.Drawing.Size(276, 22)
        Me.tb_uname.TabIndex = 48
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(94, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 47
        Me.MetroLabel1.Text = "Username:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(368, 140)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel10.TabIndex = 62
        Me.MetroLabel10.Text = "Search by ID#:"
        '
        'tb_searchaccount
        '
        Me.tb_searchaccount.AutoCompleteCustomSource.AddRange(New String() {"0-", "1-", "3-", "4-", "5-", "6-", "7-", "8-", "9-", "10-", "11-", "12-", "13-", "14-", "15-", "16-", "17-", "18-", "19-", "20-", "21-", "22-"})
        Me.tb_searchaccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_searchaccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_searchaccount.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_searchaccount.Location = New System.Drawing.Point(467, 137)
        Me.tb_searchaccount.Name = "tb_searchaccount"
        Me.tb_searchaccount.Size = New System.Drawing.Size(276, 22)
        Me.tb_searchaccount.TabIndex = 61
        '
        'lb_accounts
        '
        Me.lb_accounts.FormattingEnabled = True
        Me.lb_accounts.Location = New System.Drawing.Point(72, 169)
        Me.lb_accounts.Name = "lb_accounts"
        Me.lb_accounts.Size = New System.Drawing.Size(120, 251)
        Me.lb_accounts.TabIndex = 63
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(289, 42)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel11.TabIndex = 81
        Me.MetroLabel11.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel11.UseStyleColors = True
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(707, 6)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = CType(resources.GetObject("ml_minimize.NoFocusImage"), System.Drawing.Image)
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 97
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(753, 6)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = CType(resources.GetObject("ml_exit.NoFocusImage"), System.Drawing.Image)
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 96
        Me.ml_exit.UseSelectable = True
        '
        'ml_update
        '
        Me.ml_update.Image = CType(resources.GetObject("ml_update.Image"), System.Drawing.Image)
        Me.ml_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_update.ImageSize = 32
        Me.ml_update.Location = New System.Drawing.Point(629, 558)
        Me.ml_update.Name = "ml_update"
        Me.ml_update.NoFocusImage = CType(resources.GetObject("ml_update.NoFocusImage"), System.Drawing.Image)
        Me.ml_update.Size = New System.Drawing.Size(114, 39)
        Me.ml_update.TabIndex = 88
        Me.ml_update.Text = "Update"
        Me.ml_update.UseSelectable = True
        '
        'ml_delete
        '
        Me.ml_delete.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_1
        Me.ml_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_delete.ImageSize = 32
        Me.ml_delete.Location = New System.Drawing.Point(519, 560)
        Me.ml_delete.Name = "ml_delete"
        Me.ml_delete.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_2
        Me.ml_delete.Size = New System.Drawing.Size(104, 39)
        Me.ml_delete.TabIndex = 87
        Me.ml_delete.Text = "Delete"
        Me.ml_delete.UseSelectable = True
        '
        'ml_clear
        '
        Me.ml_clear.Image = CType(resources.GetObject("ml_clear.Image"), System.Drawing.Image)
        Me.ml_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_clear.ImageSize = 32
        Me.ml_clear.Location = New System.Drawing.Point(409, 560)
        Me.ml_clear.Name = "ml_clear"
        Me.ml_clear.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.refresh_2
        Me.ml_clear.Size = New System.Drawing.Size(104, 39)
        Me.ml_clear.TabIndex = 86
        Me.ml_clear.Text = "Clear"
        Me.ml_clear.UseSelectable = True
        '
        'ml_save
        '
        Me.ml_save.Image = CType(resources.GetObject("ml_save.Image"), System.Drawing.Image)
        Me.ml_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_save.ImageSize = 32
        Me.ml_save.Location = New System.Drawing.Point(198, 558)
        Me.ml_save.Name = "ml_save"
        Me.ml_save.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.document_2
        Me.ml_save.Size = New System.Drawing.Size(99, 39)
        Me.ml_save.TabIndex = 85
        Me.ml_save.Text = "Save"
        Me.ml_save.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(502, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(213, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'mcb_school
        '
        Me.mcb_school.AutoCompleteCustomSource.AddRange(New String() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "-"})
        Me.mcb_school.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_school.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_school.FormattingEnabled = True
        Me.mcb_school.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "-"})
        Me.mcb_school.Location = New System.Drawing.Point(170, 66)
        Me.mcb_school.Name = "mcb_school"
        Me.mcb_school.Size = New System.Drawing.Size(277, 21)
        Me.mcb_school.TabIndex = 63
        '
        'FrmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.ml_update)
        Me.Controls.Add(Me.ml_delete)
        Me.Controls.Add(Me.ml_clear)
        Me.Controls.Add(Me.ml_save)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lb_accounts)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.tb_searchaccount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAccounts"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_lname As TextBox
    Friend WithEvents tb_mname As TextBox
    Friend WithEvents tb_fname As TextBox
    Friend WithEvents tb_id As TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_usertype As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_retypepass As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_uname As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_searchaccount As TextBox
    Friend WithEvents lb_accounts As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ml_update As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_delete As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_clear As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_save As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents mcb_school As ComboBox
End Class
