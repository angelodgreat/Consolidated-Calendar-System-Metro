<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEvent
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEvent))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mdtp_datepicker = New MetroFramework.Controls.MetroDateTime()
        Me.time_picker_to = New System.Windows.Forms.DateTimePicker()
        Me.time_picker_from = New System.Windows.Forms.DateTimePicker()
        Me.tb_eventid = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.rtb_event = New System.Windows.Forms.RichTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.ml_print = New MetroFramework.Controls.MetroLink()
        Me.ml_update = New MetroFramework.Controls.MetroLink()
        Me.ml_delete = New MetroFramework.Controls.MetroLink()
        Me.ml_clear = New MetroFramework.Controls.MetroLink()
        Me.ml_save = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.mcb_kpi = New System.Windows.Forms.ComboBox()
        Me.mcb_location = New System.Windows.Forms.ComboBox()
        Me.mcb_school = New System.Windows.Forms.ComboBox()
        Me.mcb_noa = New System.Windows.Forms.ComboBox()
        Me.cb_remarks = New System.Windows.Forms.ComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.MetroGrid1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1255, 262)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Events"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 16)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.RowHeadersVisible = False
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1249, 243)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroGrid1.TabIndex = 0
        Me.MetroGrid1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(149, 397)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Event ID#:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(149, 443)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Date:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(149, 476)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "Time:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(149, 524)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "KPI:"
        '
        'mdtp_datepicker
        '
        Me.mdtp_datepicker.Location = New System.Drawing.Point(222, 433)
        Me.mdtp_datepicker.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtp_datepicker.Name = "mdtp_datepicker"
        Me.mdtp_datepicker.Size = New System.Drawing.Size(276, 29)
        Me.mdtp_datepicker.TabIndex = 22
        '
        'time_picker_to
        '
        Me.time_picker_to.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.time_picker_to.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.time_picker_to.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.time_picker_to.CustomFormat = "h:mm tt"
        Me.time_picker_to.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.time_picker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time_picker_to.Location = New System.Drawing.Point(342, 475)
        Me.time_picker_to.Name = "time_picker_to"
        Me.time_picker_to.ShowUpDown = True
        Me.time_picker_to.Size = New System.Drawing.Size(115, 22)
        Me.time_picker_to.TabIndex = 27
        '
        'time_picker_from
        '
        Me.time_picker_from.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.time_picker_from.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.time_picker_from.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.time_picker_from.CustomFormat = "h:mm tt"
        Me.time_picker_from.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.time_picker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time_picker_from.Location = New System.Drawing.Point(222, 475)
        Me.time_picker_from.Name = "time_picker_from"
        Me.time_picker_from.ShowUpDown = True
        Me.time_picker_from.Size = New System.Drawing.Size(114, 22)
        Me.time_picker_from.TabIndex = 26
        '
        'tb_eventid
        '
        Me.tb_eventid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tb_eventid.Location = New System.Drawing.Point(222, 397)
        Me.tb_eventid.Name = "tb_eventid"
        Me.tb_eventid.Size = New System.Drawing.Size(276, 22)
        Me.tb_eventid.TabIndex = 31
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(569, 433)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = "Nature of Activity:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(149, 572)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel6.TabIndex = 33
        Me.MetroLabel6.Text = "Location:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(569, 397)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel7.TabIndex = 34
        Me.MetroLabel7.Text = "School/Organization:"
        '
        'rtb_event
        '
        Me.rtb_event.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rtb_event.Location = New System.Drawing.Point(569, 497)
        Me.rtb_event.Name = "rtb_event"
        Me.rtb_event.Size = New System.Drawing.Size(640, 94)
        Me.rtb_event.TabIndex = 35
        Me.rtb_event.Text = ""
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(569, 476)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel8.TabIndex = 36
        Me.MetroLabel8.Text = "Event:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(512, 40)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel9.TabIndex = 81
        Me.MetroLabel9.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel9.UseStyleColors = True
        '
        'ml_print
        '
        Me.ml_print.Image = CType(resources.GetObject("ml_print.Image"), System.Drawing.Image)
        Me.ml_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_print.ImageSize = 32
        Me.ml_print.Location = New System.Drawing.Point(673, 597)
        Me.ml_print.Name = "ml_print"
        Me.ml_print.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.print_1
        Me.ml_print.Size = New System.Drawing.Size(104, 39)
        Me.ml_print.TabIndex = 93
        Me.ml_print.Text = "Print"
        Me.ml_print.UseSelectable = True
        '
        'ml_update
        '
        Me.ml_update.Image = CType(resources.GetObject("ml_update.Image"), System.Drawing.Image)
        Me.ml_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_update.ImageSize = 32
        Me.ml_update.Location = New System.Drawing.Point(1095, 597)
        Me.ml_update.Name = "ml_update"
        Me.ml_update.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.compact_disc_2
        Me.ml_update.Size = New System.Drawing.Size(114, 39)
        Me.ml_update.TabIndex = 92
        Me.ml_update.Text = "Update"
        Me.ml_update.UseSelectable = True
        '
        'ml_delete
        '
        Me.ml_delete.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_1
        Me.ml_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_delete.ImageSize = 32
        Me.ml_delete.Location = New System.Drawing.Point(985, 597)
        Me.ml_delete.Name = "ml_delete"
        Me.ml_delete.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_2
        Me.ml_delete.Size = New System.Drawing.Size(104, 39)
        Me.ml_delete.TabIndex = 91
        Me.ml_delete.Text = "Delete"
        Me.ml_delete.UseSelectable = True
        '
        'ml_clear
        '
        Me.ml_clear.Image = CType(resources.GetObject("ml_clear.Image"), System.Drawing.Image)
        Me.ml_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_clear.ImageSize = 32
        Me.ml_clear.Location = New System.Drawing.Point(875, 597)
        Me.ml_clear.Name = "ml_clear"
        Me.ml_clear.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.refresh_2
        Me.ml_clear.Size = New System.Drawing.Size(104, 39)
        Me.ml_clear.TabIndex = 90
        Me.ml_clear.Text = "Clear"
        Me.ml_clear.UseSelectable = True
        '
        'ml_save
        '
        Me.ml_save.Image = CType(resources.GetObject("ml_save.Image"), System.Drawing.Image)
        Me.ml_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_save.ImageSize = 32
        Me.ml_save.Location = New System.Drawing.Point(568, 598)
        Me.ml_save.Name = "ml_save"
        Me.ml_save.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.document_2
        Me.ml_save.Size = New System.Drawing.Size(99, 39)
        Me.ml_save.TabIndex = 89
        Me.ml_save.Text = "Save"
        Me.ml_save.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(725, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(436, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(1216, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 97
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(1263, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 96
        Me.ml_exit.UseSelectable = True
        '
        'mcb_kpi
        '
        Me.mcb_kpi.AutoCompleteCustomSource.AddRange(New String() {"IGA", "CSA", "LTS", "SDP", "SRA", "COA", "HWP", "-"})
        Me.mcb_kpi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_kpi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_kpi.FormattingEnabled = True
        Me.mcb_kpi.Items.AddRange(New Object() {"IGA", "CSA", "LTS", "SDP", "SRA", "COA", "HWP", "-"})
        Me.mcb_kpi.Location = New System.Drawing.Point(222, 524)
        Me.mcb_kpi.Name = "mcb_kpi"
        Me.mcb_kpi.Size = New System.Drawing.Size(276, 21)
        Me.mcb_kpi.TabIndex = 98
        '
        'mcb_location
        '
        Me.mcb_location.AutoCompleteCustomSource.AddRange(New String() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "LAH Seminar Room #2, #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "-", "SDV Friendship Area/Lanai with/out Lights", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "ISC Mezzanine #1 & #2", "DENTISTRY AND SCIENCE BLDG", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle", "Center Gate", "North Gate", "Other"})
        Me.mcb_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_location.FormattingEnabled = True
        Me.mcb_location.Items.AddRange(New Object() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "LAH Seminar Room #2, #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "-", "SDV Friendship Area/Lanai with/out Lights", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "ISC Mezzanine #1 & #2", "DENTISTRY AND SCIENCE BLDG", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle", "Center Gate", "North Gate", "Other"})
        Me.mcb_location.Location = New System.Drawing.Point(222, 572)
        Me.mcb_location.Name = "mcb_location"
        Me.mcb_location.Size = New System.Drawing.Size(276, 21)
        Me.mcb_location.TabIndex = 99
        '
        'mcb_school
        '
        Me.mcb_school.AutoCompleteCustomSource.AddRange(New String() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "Other", "-"})
        Me.mcb_school.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_school.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_school.FormattingEnabled = True
        Me.mcb_school.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "Other", "-"})
        Me.mcb_school.Location = New System.Drawing.Point(708, 397)
        Me.mcb_school.Name = "mcb_school"
        Me.mcb_school.Size = New System.Drawing.Size(314, 21)
        Me.mcb_school.TabIndex = 100
        '
        'mcb_noa
        '
        Me.mcb_noa.AutoCompleteCustomSource.AddRange(New String() {"Academic Related", "Co/Extra-Curricular Activity", "Community Outreach Program", "-"})
        Me.mcb_noa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mcb_noa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mcb_noa.FormattingEnabled = True
        Me.mcb_noa.Items.AddRange(New Object() {"Academic Related", "Co/Extra-Curricular Activity", "Community Outreach Program", "-"})
        Me.mcb_noa.Location = New System.Drawing.Point(708, 433)
        Me.mcb_noa.Name = "mcb_noa"
        Me.mcb_noa.Size = New System.Drawing.Size(314, 21)
        Me.mcb_noa.TabIndex = 101
        '
        'cb_remarks
        '
        Me.cb_remarks.AutoCompleteCustomSource.AddRange(New String() {"Cancelled", "Moved Date", "Moved Location", "Finished"})
        Me.cb_remarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_remarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_remarks.FormattingEnabled = True
        Me.cb_remarks.Items.AddRange(New Object() {"Cancelled", "Moved Date", "Moved Location", "Finished"})
        Me.cb_remarks.Location = New System.Drawing.Point(1109, 398)
        Me.cb_remarks.Name = "cb_remarks"
        Me.cb_remarks.Size = New System.Drawing.Size(173, 21)
        Me.cb_remarks.TabIndex = 102
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(1041, 398)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel10.TabIndex = 103
        Me.MetroLabel10.Text = "Remarks:"
        '
        'FrmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImagePadding = New System.Windows.Forms.Padding(10)
        Me.BackMaxSize = 70
        Me.ClientSize = New System.Drawing.Size(1301, 646)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cb_remarks)
        Me.Controls.Add(Me.mcb_noa)
        Me.Controls.Add(Me.mcb_school)
        Me.Controls.Add(Me.mcb_location)
        Me.Controls.Add(Me.mcb_kpi)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.ml_print)
        Me.Controls.Add(Me.ml_update)
        Me.Controls.Add(Me.ml_delete)
        Me.Controls.Add(Me.ml_clear)
        Me.Controls.Add(Me.ml_save)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.rtb_event)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.tb_eventid)
        Me.Controls.Add(Me.time_picker_to)
        Me.Controls.Add(Me.time_picker_from)
        Me.Controls.Add(Me.mdtp_datepicker)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEvent"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdtp_datepicker As MetroFramework.Controls.MetroDateTime
    Friend WithEvents time_picker_to As DateTimePicker
    Friend WithEvents time_picker_from As DateTimePicker
    Friend WithEvents tb_eventid As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rtb_event As RichTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ml_update As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_delete As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_clear As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_save As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_print As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents mcb_kpi As ComboBox
    Friend WithEvents mcb_location As ComboBox
    Friend WithEvents mcb_school As ComboBox
    Friend WithEvents mcb_noa As ComboBox
    Friend WithEvents cb_remarks As ComboBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
End Class
