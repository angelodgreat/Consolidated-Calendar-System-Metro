<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Developers:"
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(396, 5)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = CType(resources.GetObject("ml_minimize.NoFocusImage"), System.Drawing.Image)
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 90
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(441, 5)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = CType(resources.GetObject("ml_exit.NoFocusImage"), System.Drawing.Image)
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 89
        Me.ml_exit.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(29, 26)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(162, 228)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Umali, Christian Angelo R." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lumaque, Demar S." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tecson, Miguel Exequiel H." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Muñoz, Hadrian G." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               Adviser:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Haidee M. Valin"
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 356)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAbout"
        Me.Text = "CEU Consolidated Calendar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
