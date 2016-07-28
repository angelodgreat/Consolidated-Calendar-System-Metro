<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotes))
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.rtb_n = New System.Windows.Forms.RichTextBox()
        Me.tb_nn = New System.Windows.Forms.TextBox()
        Me.mdt_ndtp = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ml_update = New MetroFramework.Controls.MetroLink()
        Me.ml_delete = New MetroFramework.Controls.MetroLink()
        Me.ml_clear = New MetroFramework.Controls.MetroLink()
        Me.ml_save = New MetroFramework.Controls.MetroLink()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(48, 212)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel8.TabIndex = 42
        Me.MetroLabel8.Text = "Note:"
        '
        'rtb_n
        '
        Me.rtb_n.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rtb_n.Location = New System.Drawing.Point(48, 234)
        Me.rtb_n.Name = "rtb_n"
        Me.rtb_n.Size = New System.Drawing.Size(508, 112)
        Me.rtb_n.TabIndex = 41
        Me.rtb_n.Text = ""
        '
        'tb_nn
        '
        Me.tb_nn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tb_nn.Location = New System.Drawing.Point(170, 155)
        Me.tb_nn.Name = "tb_nn"
        Me.tb_nn.Size = New System.Drawing.Size(276, 22)
        Me.tb_nn.TabIndex = 40
        '
        'mdt_ndtp
        '
        Me.mdt_ndtp.Location = New System.Drawing.Point(170, 183)
        Me.mdt_ndtp.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdt_ndtp.Name = "mdt_ndtp"
        Me.mdt_ndtp.Size = New System.Drawing.Size(276, 29)
        Me.mdt_ndtp.TabIndex = 39
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(125, 193)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 38
        Me.MetroLabel2.Text = "Date:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(99, 155)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 37
        Me.MetroLabel1.Text = "Note ID#:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(187, 58)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel3.TabIndex = 80
        Me.MetroLabel3.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel3.UseStyleColors = True
        '
        'ml_update
        '
        Me.ml_update.Image = CType(resources.GetObject("ml_update.Image"), System.Drawing.Image)
        Me.ml_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_update.ImageSize = 32
        Me.ml_update.Location = New System.Drawing.Point(452, 360)
        Me.ml_update.Name = "ml_update"
        Me.ml_update.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.compact_disc_2
        Me.ml_update.Size = New System.Drawing.Size(114, 39)
        Me.ml_update.TabIndex = 84
        Me.ml_update.Text = "Update"
        Me.ml_update.UseSelectable = True
        '
        'ml_delete
        '
        Me.ml_delete.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_1
        Me.ml_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_delete.ImageSize = 32
        Me.ml_delete.Location = New System.Drawing.Point(342, 360)
        Me.ml_delete.Name = "ml_delete"
        Me.ml_delete.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.delete_2
        Me.ml_delete.Size = New System.Drawing.Size(104, 39)
        Me.ml_delete.TabIndex = 83
        Me.ml_delete.Text = "Delete"
        Me.ml_delete.UseSelectable = True
        '
        'ml_clear
        '
        Me.ml_clear.Image = CType(resources.GetObject("ml_clear.Image"), System.Drawing.Image)
        Me.ml_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_clear.ImageSize = 32
        Me.ml_clear.Location = New System.Drawing.Point(232, 360)
        Me.ml_clear.Name = "ml_clear"
        Me.ml_clear.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.refresh_21
        Me.ml_clear.Size = New System.Drawing.Size(104, 39)
        Me.ml_clear.TabIndex = 82
        Me.ml_clear.Text = "Clear"
        Me.ml_clear.UseSelectable = True
        '
        'ml_save
        '
        Me.ml_save.Image = CType(resources.GetObject("ml_save.Image"), System.Drawing.Image)
        Me.ml_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_save.ImageSize = 32
        Me.ml_save.Location = New System.Drawing.Point(48, 360)
        Me.ml_save.Name = "ml_save"
        Me.ml_save.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.document_2
        Me.ml_save.Size = New System.Drawing.Size(99, 39)
        Me.ml_save.TabIndex = 81
        Me.ml_save.Text = "Save"
        Me.ml_save.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(400, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(111, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(519, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 99
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(564, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 98
        Me.ml_exit.UseSelectable = True
        '
        'FrmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.ml_update)
        Me.Controls.Add(Me.ml_delete)
        Me.Controls.Add(Me.ml_clear)
        Me.Controls.Add(Me.ml_save)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.rtb_n)
        Me.Controls.Add(Me.tb_nn)
        Me.Controls.Add(Me.mdt_ndtp)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNotes"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rtb_n As RichTextBox
    Friend WithEvents tb_nn As TextBox
    Friend WithEvents mdt_ndtp As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ml_save As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_clear As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_delete As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_update As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
End Class
