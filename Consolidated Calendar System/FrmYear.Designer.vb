<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmYear))
        Me.mcb_year = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.ml_delete = New MetroFramework.Controls.MetroLink()
        Me.ml_save = New MetroFramework.Controls.MetroLink()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcb_year
        '
        Me.mcb_year.FormattingEnabled = True
        Me.mcb_year.ItemHeight = 23
        Me.mcb_year.Items.AddRange(New Object() {"2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "Other"})
        Me.mcb_year.Location = New System.Drawing.Point(98, 170)
        Me.mcb_year.Name = "mcb_year"
        Me.mcb_year.Size = New System.Drawing.Size(297, 29)
        Me.mcb_year.TabIndex = 0
        Me.mcb_year.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(145, 63)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel11.TabIndex = 93
        Me.MetroLabel11.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel11.UseStyleColors = True
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(402, 6)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 95
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(449, 6)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 94
        Me.ml_exit.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(358, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(69, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'MetroLink1
        '
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.ImageSize = 32
        Me.MetroLink1.Location = New System.Drawing.Point(291, 217)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.play_2
        Me.MetroLink1.Size = New System.Drawing.Size(104, 39)
        Me.MetroLink1.TabIndex = 90
        Me.MetroLink1.Text = "Load"
        Me.MetroLink1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLink1.UseSelectable = True
        '
        'ml_delete
        '
        Me.ml_delete.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_1
        Me.ml_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_delete.ImageSize = 32
        Me.ml_delete.Location = New System.Drawing.Point(98, 262)
        Me.ml_delete.Name = "ml_delete"
        Me.ml_delete.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_2
        Me.ml_delete.Size = New System.Drawing.Size(104, 39)
        Me.ml_delete.TabIndex = 89
        Me.ml_delete.Text = "Delete"
        Me.ml_delete.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ml_delete.UseSelectable = True
        '
        'ml_save
        '
        Me.ml_save.Image = CType(resources.GetObject("ml_save.Image"), System.Drawing.Image)
        Me.ml_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_save.ImageSize = 32
        Me.ml_save.Location = New System.Drawing.Point(98, 217)
        Me.ml_save.Name = "ml_save"
        Me.ml_save.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.document_2
        Me.ml_save.Size = New System.Drawing.Size(104, 39)
        Me.ml_save.TabIndex = 88
        Me.ml_save.Text = "Save"
        Me.ml_save.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ml_save.UseSelectable = True
        '
        'Timer1
        '
        '
        'FrmYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.ml_delete)
        Me.Controls.Add(Me.ml_save)
        Me.Controls.Add(Me.mcb_year)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmYear"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mcb_year As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ml_delete As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_save As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents Timer1 As Timer
End Class
