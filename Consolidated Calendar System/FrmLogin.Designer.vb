<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtlb_time = New MetroFramework.Controls.MetroLabel()
        Me.mtlb_status = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mb_login = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_uname = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(127, 84)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(207, 75)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel3.TabIndex = 81
        Me.MetroLabel3.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Students Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Mendiola, Manila"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel3.UseStyleColors = True
        '
        'mtlb_time
        '
        Me.mtlb_time.AutoSize = True
        Me.mtlb_time.Location = New System.Drawing.Point(-1, 5)
        Me.mtlb_time.Name = "mtlb_time"
        Me.mtlb_time.Size = New System.Drawing.Size(38, 19)
        Me.mtlb_time.Style = MetroFramework.MetroColorStyle.Black
        Me.mtlb_time.TabIndex = 82
        Me.mtlb_time.Text = "Time"
        Me.mtlb_time.UseStyleColors = True
        '
        'mtlb_status
        '
        Me.mtlb_status.AutoSize = True
        Me.mtlb_status.Location = New System.Drawing.Point(367, 311)
        Me.mtlb_status.Name = "mtlb_status"
        Me.mtlb_status.Size = New System.Drawing.Size(43, 19)
        Me.mtlb_status.Style = MetroFramework.MetroColorStyle.Black
        Me.mtlb_status.TabIndex = 83
        Me.mtlb_status.Text = "Status"
        Me.mtlb_status.UseStyleColors = True
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mb_login)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.tb_password)
        Me.GroupBox1.Controls.Add(Me.tb_uname)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 121)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'mb_login
        '
        Me.mb_login.Location = New System.Drawing.Point(242, 89)
        Me.mb_login.Name = "mb_login"
        Me.mb_login.Size = New System.Drawing.Size(75, 23)
        Me.mb_login.TabIndex = 9
        Me.mb_login.Text = "Log-in"
        Me.mb_login.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(51, 46)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Password:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(46, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Username:"
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tb_password.Location = New System.Drawing.Point(123, 46)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(194, 22)
        Me.tb_password.TabIndex = 6
        '
        'tb_uname
        '
        Me.tb_uname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tb_uname.Location = New System.Drawing.Point(123, 18)
        Me.tb_uname.Name = "tb_uname"
        Me.tb_uname.Size = New System.Drawing.Size(194, 22)
        Me.tb_uname.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(340, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consolidated_Calendar_System.My.Resources.Resources.oie_1411852htlPKYzi
        Me.PictureBox1.Location = New System.Drawing.Point(50, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(434, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 85
        Me.ml_exit.UseSelectable = True
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(389, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 86
        Me.ml_minimize.UseSelectable = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtlb_status)
        Me.Controls.Add(Me.mtlb_time)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtlb_time As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtlb_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mb_login As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_uname As TextBox
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
End Class
