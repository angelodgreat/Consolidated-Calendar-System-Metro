<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.mcb_filtercollege = New System.Windows.Forms.ComboBox()
        Me.filtersearch_location = New System.Windows.Forms.ComboBox()
        Me.ml_refresh = New MetroFramework.Controls.MetroLink()
        Me.ml_search = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HomeMetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mdtph_filter2 = New MetroFramework.Controls.MetroDateTime()
        Me.mdtph_filter1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroNoteGrid = New MetroFramework.Controls.MetroGrid()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.mtlb_time = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mlb_showsem = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HomeMetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MetroNoteGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(3, 163)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1330, 546)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.mcb_filtercollege)
        Me.MetroTabPage1.Controls.Add(Me.filtersearch_location)
        Me.MetroTabPage1.Controls.Add(Me.ml_refresh)
        Me.MetroTabPage1.Controls.Add(Me.ml_search)
        Me.MetroTabPage1.Controls.Add(Me.GroupBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.mdtph_filter2)
        Me.MetroTabPage1.Controls.Add(Me.mdtph_filter1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.MetroTile5)
        Me.MetroTabPage1.Controls.Add(Me.MetroTile2)
        Me.MetroTabPage1.Controls.Add(Me.MetroTile1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1322, 504)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Home"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'mcb_filtercollege
        '
        Me.mcb_filtercollege.AutoCompleteCustomSource.AddRange(New String() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) "})
        Me.mcb_filtercollege.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_filtercollege.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_filtercollege.FormattingEnabled = True
        Me.mcb_filtercollege.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) "})
        Me.mcb_filtercollege.Location = New System.Drawing.Point(18, 433)
        Me.mcb_filtercollege.Name = "mcb_filtercollege"
        Me.mcb_filtercollege.Size = New System.Drawing.Size(293, 21)
        Me.mcb_filtercollege.TabIndex = 89
        '
        'filtersearch_location
        '
        Me.filtersearch_location.AutoCompleteCustomSource.AddRange(New String() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "LAH Seminar Room #2, #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "SDV Friendship Area/Lanai with/out Lights", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "ISC Mezzanine #1 & #2", "DENTISTRY AND SCIENCE BLDG", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle", "Center Gate", "North Gate"})
        Me.filtersearch_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtersearch_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtersearch_location.FormattingEnabled = True
        Me.filtersearch_location.Items.AddRange(New Object() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "LAH Seminar Room #2, #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "SDV Friendship Area/Lanai with/out Lights", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "ISC Mezzanine #1 & #2", "DENTISTRY AND SCIENCE BLDG", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle", "Center Gate", "North Gate"})
        Me.filtersearch_location.Location = New System.Drawing.Point(18, 209)
        Me.filtersearch_location.Name = "filtersearch_location"
        Me.filtersearch_location.Size = New System.Drawing.Size(293, 21)
        Me.filtersearch_location.TabIndex = 88
        '
        'ml_refresh
        '
        Me.ml_refresh.Image = CType(resources.GetObject("ml_refresh.Image"), System.Drawing.Image)
        Me.ml_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_refresh.ImageSize = 40
        Me.ml_refresh.Location = New System.Drawing.Point(188, 164)
        Me.ml_refresh.Name = "ml_refresh"
        Me.ml_refresh.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.refresh_21
        Me.ml_refresh.Size = New System.Drawing.Size(123, 39)
        Me.ml_refresh.TabIndex = 87
        Me.ml_refresh.Text = "Refresh"
        Me.ml_refresh.UseSelectable = True
        '
        'ml_search
        '
        Me.ml_search.Image = CType(resources.GetObject("ml_search.Image"), System.Drawing.Image)
        Me.ml_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_search.ImageSize = 32
        Me.ml_search.Location = New System.Drawing.Point(188, 346)
        Me.ml_search.Name = "ml_search"
        Me.ml_search.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.Search_2
        Me.ml_search.Size = New System.Drawing.Size(123, 39)
        Me.ml_search.TabIndex = 86
        Me.ml_search.Text = "Search"
        Me.ml_search.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.HomeMetroGrid1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 489)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Events"
        '
        'HomeMetroGrid1
        '
        Me.HomeMetroGrid1.AllowUserToAddRows = False
        Me.HomeMetroGrid1.AllowUserToDeleteRows = False
        Me.HomeMetroGrid1.AllowUserToResizeRows = False
        Me.HomeMetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HomeMetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeMetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HomeMetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.HomeMetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeMetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.HomeMetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HomeMetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.HomeMetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeMetroGrid1.EnableHeadersVisualStyles = False
        Me.HomeMetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.HomeMetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeMetroGrid1.Location = New System.Drawing.Point(3, 18)
        Me.HomeMetroGrid1.Name = "HomeMetroGrid1"
        Me.HomeMetroGrid1.ReadOnly = True
        Me.HomeMetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeMetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.HomeMetroGrid1.RowHeadersVisible = False
        Me.HomeMetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.HomeMetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HomeMetroGrid1.Size = New System.Drawing.Size(979, 468)
        Me.HomeMetroGrid1.Style = MetroFramework.MetroColorStyle.Orange
        Me.HomeMetroGrid1.TabIndex = 0
        Me.HomeMetroGrid1.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 400)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel3.TabIndex = 14
        Me.MetroLabel3.Text = "School/Organization"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(18, 254)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Date"
        '
        'mdtph_filter2
        '
        Me.mdtph_filter2.Location = New System.Drawing.Point(18, 311)
        Me.mdtph_filter2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtph_filter2.Name = "mdtph_filter2"
        Me.mdtph_filter2.Size = New System.Drawing.Size(293, 29)
        Me.mdtph_filter2.TabIndex = 11
        '
        'mdtph_filter1
        '
        Me.mdtph_filter1.Location = New System.Drawing.Point(18, 276)
        Me.mdtph_filter1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtph_filter1.Name = "mdtph_filter1"
        Me.mdtph_filter1.Size = New System.Drawing.Size(293, 29)
        Me.mdtph_filter1.TabIndex = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 186)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Location"
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(84, 74)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(158, 64)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile5.TabIndex = 7
        Me.MetroTile5.Text = "Year Management"
        Me.MetroTile5.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(168, 3)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(159, 65)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile2.TabIndex = 4
        Me.MetroTile2.Text = "Accounts Management"
        Me.MetroTile2.UseSelectable = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(159, 65)
        Me.MetroTile1.TabIndex = 3
        Me.MetroTile1.Text = "Events Management"
        Me.MetroTile1.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroTile4)
        Me.MetroTabPage2.Controls.Add(Me.GroupBox4)
        Me.MetroTabPage2.Controls.Add(Me.GroupBox3)
        Me.MetroTabPage2.Controls.Add(Me.GroupBox2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1322, 504)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Notes and Abouts"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(546, 382)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(159, 65)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile4.TabIndex = 7
        Me.MetroTile4.Text = "Notes Management"
        Me.MetroTile4.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.MetroLabel4)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(534, 158)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "About CEU"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 32)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(473, 95)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = resources.GetString("MetroLabel4.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.MetroLabel5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(534, 195)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "About Students Affairs Office"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(6, 29)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(514, 133)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = resources.GetString("MetroLabel5.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroNoteGrid)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(543, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 359)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notes"
        '
        'MetroNoteGrid
        '
        Me.MetroNoteGrid.AllowUserToAddRows = False
        Me.MetroNoteGrid.AllowUserToDeleteRows = False
        Me.MetroNoteGrid.AllowUserToResizeRows = False
        Me.MetroNoteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroNoteGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroNoteGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroNoteGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroNoteGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroNoteGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroNoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroNoteGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroNoteGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroNoteGrid.EnableHeadersVisualStyles = False
        Me.MetroNoteGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroNoteGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroNoteGrid.Location = New System.Drawing.Point(3, 18)
        Me.MetroNoteGrid.Name = "MetroNoteGrid"
        Me.MetroNoteGrid.ReadOnly = True
        Me.MetroNoteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroNoteGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroNoteGrid.RowHeadersVisible = False
        Me.MetroNoteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroNoteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroNoteGrid.Size = New System.Drawing.Size(741, 338)
        Me.MetroNoteGrid.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroNoteGrid.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1295, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(550, 87)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel11.TabIndex = 82
        Me.MetroLabel11.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel11.UseStyleColors = True
        '
        'mtlb_time
        '
        Me.mtlb_time.AutoSize = True
        Me.mtlb_time.Location = New System.Drawing.Point(3, 5)
        Me.mtlb_time.Name = "mtlb_time"
        Me.mtlb_time.Size = New System.Drawing.Size(38, 19)
        Me.mtlb_time.Style = MetroFramework.MetroColorStyle.Black
        Me.mtlb_time.TabIndex = 89
        Me.mtlb_time.Text = "Time"
        Me.mtlb_time.UseStyleColors = True
        '
        'Timer1
        '
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(1248, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 88
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(1294, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 87
        Me.ml_exit.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(763, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(474, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'mlb_showsem
        '
        Me.mlb_showsem.AutoSize = True
        Me.mlb_showsem.Location = New System.Drawing.Point(680, 5)
        Me.mlb_showsem.Name = "mlb_showsem"
        Me.mlb_showsem.Size = New System.Drawing.Size(77, 19)
        Me.mlb_showsem.TabIndex = 90
        Me.mlb_showsem.Text = "School year"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(545, 5)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel6.TabIndex = 91
        Me.MetroLabel6.Text = "Current School Year:"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.mlb_showsem)
        Me.Controls.Add(Me.mtlb_time)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmHome"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Centro Escolar University"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.HomeMetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MetroNoteGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroNoteGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlb_time As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ml_refresh As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_search As MetroFramework.Controls.MetroLink
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HomeMetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdtph_filter2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtph_filter1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents mlb_showsem As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_filtercollege As ComboBox
    Friend WithEvents filtersearch_location As ComboBox
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents opd As OpenFileDialog
End Class
