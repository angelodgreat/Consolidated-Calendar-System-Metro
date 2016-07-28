<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuest
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGuest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HGMetroGrid = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.filtersearch_location = New System.Windows.Forms.TextBox()
        Me.mdtph_filter1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mdtph_filter2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_filtercollege = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtlb_time = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.mlb_showsem = New MetroFramework.Controls.MetroLabel()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ml_refresh = New MetroFramework.Controls.MetroLink()
        Me.ml_search = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HGMetroGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.HGMetroGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 489)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Events"
        '
        'HGMetroGrid
        '
        Me.HGMetroGrid.AllowUserToResizeRows = False
        Me.HGMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HGMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HGMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HGMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.HGMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HGMetroGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.HGMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HGMetroGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.HGMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGMetroGrid.EnableHeadersVisualStyles = False
        Me.HGMetroGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.HGMetroGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HGMetroGrid.Location = New System.Drawing.Point(3, 18)
        Me.HGMetroGrid.Name = "HGMetroGrid"
        Me.HGMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HGMetroGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.HGMetroGrid.RowHeadersVisible = False
        Me.HGMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.HGMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HGMetroGrid.Size = New System.Drawing.Size(979, 468)
        Me.HGMetroGrid.Style = MetroFramework.MetroColorStyle.Orange
        Me.HGMetroGrid.TabIndex = 0
        Me.HGMetroGrid.UseStyleColors = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ml_refresh)
        Me.GroupBox2.Controls.Add(Me.ml_search)
        Me.GroupBox2.Controls.Add(Me.MetroLabel1)
        Me.GroupBox2.Controls.Add(Me.filtersearch_location)
        Me.GroupBox2.Controls.Add(Me.mdtph_filter1)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.mdtph_filter2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.mcb_filtercollege)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 354)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 61)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel1.TabIndex = 99
        Me.MetroLabel1.Text = "Location"
        '
        'filtersearch_location
        '
        Me.filtersearch_location.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.filtersearch_location.Location = New System.Drawing.Point(21, 83)
        Me.filtersearch_location.Name = "filtersearch_location"
        Me.filtersearch_location.Size = New System.Drawing.Size(274, 22)
        Me.filtersearch_location.TabIndex = 105
        '
        'mdtph_filter1
        '
        Me.mdtph_filter1.Location = New System.Drawing.Point(21, 151)
        Me.mdtph_filter1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtph_filter1.Name = "mdtph_filter1"
        Me.mdtph_filter1.Size = New System.Drawing.Size(274, 29)
        Me.mdtph_filter1.TabIndex = 100
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(21, 275)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel3.TabIndex = 104
        Me.MetroLabel3.Text = "School/Organization"
        '
        'mdtph_filter2
        '
        Me.mdtph_filter2.Location = New System.Drawing.Point(21, 186)
        Me.mdtph_filter2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtph_filter2.Name = "mdtph_filter2"
        Me.mdtph_filter2.Size = New System.Drawing.Size(274, 29)
        Me.mdtph_filter2.TabIndex = 101
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 129)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel2.TabIndex = 103
        Me.MetroLabel2.Text = "Date"
        '
        'mcb_filtercollege
        '
        Me.mcb_filtercollege.FormattingEnabled = True
        Me.mcb_filtercollege.ItemHeight = 23
        Me.mcb_filtercollege.Items.AddRange(New Object() {"-", "College of Accountancy and Management", "College of Dentistry", "College of Education—Liberal Arts—Music—Social Work", "College of Medical Technology", "College of Nursing", "College of Nutrition and Hospitality Management", "College of Optometry", "College of Pharmacy", "College of Science and Technology", "College of Graduate School", "College of Senior High School (Grades 11 & 12)", "Other"})
        Me.mcb_filtercollege.Location = New System.Drawing.Point(21, 297)
        Me.mcb_filtercollege.Name = "mcb_filtercollege"
        Me.mcb_filtercollege.Size = New System.Drawing.Size(274, 29)
        Me.mcb_filtercollege.TabIndex = 102
        Me.mcb_filtercollege.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mcb_filtercollege.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(593, 87)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel11.TabIndex = 102
        Me.MetroLabel11.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel11.UseStyleColors = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1302, 24)
        Me.MenuStrip1.TabIndex = 99
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'mtlb_time
        '
        Me.mtlb_time.AutoSize = True
        Me.mtlb_time.Location = New System.Drawing.Point(3, 5)
        Me.mtlb_time.Name = "mtlb_time"
        Me.mtlb_time.Size = New System.Drawing.Size(38, 19)
        Me.mtlb_time.Style = MetroFramework.MetroColorStyle.Black
        Me.mtlb_time.TabIndex = 105
        Me.mtlb_time.Text = "Time"
        Me.mtlb_time.UseStyleColors = True
        '
        'Timer1
        '
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(165, 228)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(158, 64)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile5.TabIndex = 106
        Me.MetroTile5.Text = "Year Management"
        Me.MetroTile5.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(588, 5)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel6.TabIndex = 108
        Me.MetroLabel6.Text = "Current School Year:"
        '
        'mlb_showsem
        '
        Me.mlb_showsem.AutoSize = True
        Me.mlb_showsem.Location = New System.Drawing.Point(723, 5)
        Me.mlb_showsem.Name = "mlb_showsem"
        Me.mlb_showsem.Size = New System.Drawing.Size(77, 19)
        Me.mlb_showsem.TabIndex = 107
        Me.mlb_showsem.Text = "School year"
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(1257, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 104
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(1303, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 103
        Me.ml_exit.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(806, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(517, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'ml_refresh
        '
        Me.ml_refresh.Image = CType(resources.GetObject("ml_refresh.Image"), System.Drawing.Image)
        Me.ml_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_refresh.ImageSize = 40
        Me.ml_refresh.Location = New System.Drawing.Point(177, 38)
        Me.ml_refresh.Name = "ml_refresh"
        Me.ml_refresh.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.refresh_21
        Me.ml_refresh.Size = New System.Drawing.Size(118, 39)
        Me.ml_refresh.TabIndex = 107
        Me.ml_refresh.Text = "Refresh"
        Me.ml_refresh.UseSelectable = True
        '
        'ml_search
        '
        Me.ml_search.Image = CType(resources.GetObject("ml_search.Image"), System.Drawing.Image)
        Me.ml_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_search.ImageSize = 32
        Me.ml_search.Location = New System.Drawing.Point(177, 221)
        Me.ml_search.Name = "ml_search"
        Me.ml_search.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.Search_2
        Me.ml_search.Size = New System.Drawing.Size(118, 39)
        Me.ml_search.TabIndex = 106
        Me.ml_search.Text = "Search"
        Me.ml_search.UseSelectable = True
        '
        'FrmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.mlb_showsem)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.mtlb_time)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGuest"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.HGMetroGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HGMetroGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ml_refresh As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_search As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents filtersearch_location As TextBox
    Friend WithEvents mdtph_filter1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdtph_filter2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_filtercollege As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mtlb_time As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlb_showsem As MetroFramework.Controls.MetroLabel
End Class
