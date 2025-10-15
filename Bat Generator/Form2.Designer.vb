<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
    Inherits System.Windows.Forms.Form
    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(3, -1)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(433, 13)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START!"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bat_Generator.My.Resources.Resources.anonymous_siti_piemonte_csi
        Me.PictureBox1.Location = New System.Drawing.Point(3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(439, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "BAT - Jordan Merli"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 10 Then
            Label1.Text = ("HKEY_LOCAL_MACHINE\System\CurrentCo...")
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = ("HKLM\SYSTEM\CurrentCo....")
        End If
        If ProgressBar1.Value = 17 Then
            Label1.Text = ("HKEY_LOCAL_MACHINE\SYSTEM\WPA\Key-XXXXX...")
        End If
        If ProgressBar1.Value = 19 Then
            Label1.Text = ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentContro....965-E325-11CE-BFC1-08002BE10318}...")
        End If
        If ProgressBar1.Value = 26 Then
            Label1.Text = ("pack42516001.vb")
        End If
        If ProgressBar1.Value = 31 Then
            Label1.Text = ("pack42516002.vbx")
        End If
        If ProgressBar1.Value = 32 Then
            Label1.Text = ("pack42516003.hd")
        End If
        If ProgressBar1.Value = 33 Then
            Label1.Text = ("pack42516004.5536")
        End If
        If ProgressBar1.Value = 34 Then
            Label1.Text = ("pack42516005.ghy")
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = ("pack42516006.yyge")
        End If
        If ProgressBar1.Value = 36 Then
            Label1.Text = ("pack42516007.nt")
        End If
        If ProgressBar1.Value = 37 Then
            Label1.Text = ("pack42516008.HKEY")
        End If
        If ProgressBar1.Value = 38 Then
            Label1.Text = ("pack42516009.488")
        End If
        If ProgressBar1.Value = 39 Then
            Label1.Text = ("pack42516010.43")
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = ("pack42516011.rm")
        End If
        If ProgressBar1.Value = 41 Then
            Label1.Text = ("HKLM:\\FU_1043C603&REV_1000")
        End If
        If ProgressBar1.Value = 42 Then
            Label1.Text = ("HKLM:\\FU_10669807t2097EV_1000")
        End If
        If ProgressBar1.Value = 43 Then
            Label1.Text = ("HKLM:\\FU_104Systemo87REV_1000")
        End If
        If ProgressBar1.Value = 44 Then
            Label1.Text = ("76867.5486.zjed")
        End If
        If ProgressBar1.Value = 45 Then
            Label1.Text = ("76ygqw.5486.zjed")
        End If
        If ProgressBar1.Value = 47 Then
            Label1.Text = ("76hnwh.zjed")
        End If
        If ProgressBar1.Value = 48 Then
            Label1.Text = ("Backup TEMP Files")
        End If
        If ProgressBar1.Value = 49 Then
            Label1.Text = ("Backup TEMP Files")
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = ("Delete TEMP Files.old")
        End If
        If ProgressBar1.Value = 51 Then
            Label1.Text = ("Connection to DB XAML.jm")
        End If
        If ProgressBar1.Value = 52 Then
            Label1.Text = ("package0542.jm...")
        End If
        If ProgressBar1.Value = 53 Then
            Label1.Text = ("package675265928.jm...")
        End If
        If ProgressBar1.Value = 54 Then
            Label1.Text = ("package6279822.jm...")
        End If
        If ProgressBar1.Value = 56 Then
            Label1.Text = ("Registry Editor [423412635716];...")
        End If
        If ProgressBar1.Value = 59 Then
            Label1.Text = ("sub798 e sub7652...")
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = ("file .temp...")
        End If
        If ProgressBar1.Value = 61 Then
            Label1.Text = ("Firewall")
        End If
        If ProgressBar1.Value = 68 Then
            Label1.Text = ("Auto-Run as Administrator")
        End If
        If ProgressBar1.Value = 75 Then
            Label1.Text = ("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
        End If
        If ProgressBar1.Value = 81 Then
            Label1.Text = ("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
        End If
        If ProgressBar1.Value = 89 Then
            Label1.Text = ("Kill TEMP.exe...")
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = ("")
        End If
        If ProgressBar1.Value = 100 Then Button1.Show()
    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Enabled = True Then Form1.Show()
        If Button1.Enabled = True Then Me.Close()
    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class