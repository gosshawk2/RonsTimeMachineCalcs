<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculate))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGravityConstant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLightSpeed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSquareLength = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLaserIntensity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtResultFrequency = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNumberOfDiodes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDiodePower = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDiodeHeight = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtLaserTowerHeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt8root2GP = New System.Windows.Forms.TextBox()
        Me.TxtacCubed = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTop.Controls.Add(Me.BtnClose)
        Me.pnlTop.Location = New System.Drawing.Point(1, 1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(921, 39)
        Me.pnlTop.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Lime
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(11, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 27)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.Lime
        Me.BtnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(11, 209)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(579, 27)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlMain.Controls.Add(Me.TxtacCubed)
        Me.pnlMain.Controls.Add(Me.Label12)
        Me.pnlMain.Controls.Add(Me.Txt8root2GP)
        Me.pnlMain.Controls.Add(Me.Label11)
        Me.pnlMain.Controls.Add(Me.TxtLaserTowerHeight)
        Me.pnlMain.Controls.Add(Me.BtnCalculate)
        Me.pnlMain.Controls.Add(Me.Label10)
        Me.pnlMain.Controls.Add(Me.Label9)
        Me.pnlMain.Controls.Add(Me.TxtDiodeHeight)
        Me.pnlMain.Controls.Add(Me.Label8)
        Me.pnlMain.Controls.Add(Me.TxtDiodePower)
        Me.pnlMain.Controls.Add(Me.Label7)
        Me.pnlMain.Controls.Add(Me.Label6)
        Me.pnlMain.Controls.Add(Me.TxtNumberOfDiodes)
        Me.pnlMain.Controls.Add(Me.TxtResultFrequency)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.PictureBox1)
        Me.pnlMain.Controls.Add(Me.txtGravityConstant)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.txtLightSpeed)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.txtSquareLength)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.txtLaserIntensity)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(921, 317)
        Me.pnlMain.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(611, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 132)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtGravityConstant
        '
        Me.txtGravityConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGravityConstant.Location = New System.Drawing.Point(445, 93)
        Me.txtGravityConstant.Name = "txtGravityConstant"
        Me.txtGravityConstant.Size = New System.Drawing.Size(145, 26)
        Me.txtGravityConstant.TabIndex = 7
        Me.txtGravityConstant.Text = "9.8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(G) Enter Gravity Constant:"
        '
        'txtLightSpeed
        '
        Me.txtLightSpeed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLightSpeed.Location = New System.Drawing.Point(445, 160)
        Me.txtLightSpeed.Name = "txtLightSpeed"
        Me.txtLightSpeed.Size = New System.Drawing.Size(145, 26)
        Me.txtLightSpeed.TabIndex = 5
        Me.txtLightSpeed.Text = "300000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(c) Enter Light Speed (k/sec):"
        '
        'txtSquareLength
        '
        Me.txtSquareLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSquareLength.Location = New System.Drawing.Point(445, 127)
        Me.txtSquareLength.Name = "txtSquareLength"
        Me.txtSquareLength.Size = New System.Drawing.Size(145, 26)
        Me.txtSquareLength.TabIndex = 3
        Me.txtSquareLength.Text = "0.0000001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(a) Enter Square Length (Meters):"
        '
        'txtLaserIntensity
        '
        Me.txtLaserIntensity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLaserIntensity.Location = New System.Drawing.Point(445, 62)
        Me.txtLaserIntensity.Name = "txtLaserIntensity"
        Me.txtLaserIntensity.Size = New System.Drawing.Size(145, 26)
        Me.txtLaserIntensity.TabIndex = 1
        Me.txtLaserIntensity.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(P) Enter Laser Intensity (watts):"
        '
        'TxtResultFrequency
        '
        Me.TxtResultFrequency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultFrequency.Location = New System.Drawing.Point(369, 248)
        Me.TxtResultFrequency.Name = "TxtResultFrequency"
        Me.TxtResultFrequency.Size = New System.Drawing.Size(221, 26)
        Me.TxtResultFrequency.TabIndex = 10
        Me.TxtResultFrequency.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "(Ʊ) Result: Neutron Spin Direction Change Frequency:"
        '
        'TxtNumberOfDiodes
        '
        Me.TxtNumberOfDiodes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberOfDiodes.Location = New System.Drawing.Point(232, 63)
        Me.TxtNumberOfDiodes.Name = "TxtNumberOfDiodes"
        Me.TxtNumberOfDiodes.Size = New System.Drawing.Size(53, 22)
        Me.TxtNumberOfDiodes.TabIndex = 11
        Me.TxtNumberOfDiodes.Text = "10000"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 50)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Diode Power (watts)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "X"
        '
        'TxtDiodePower
        '
        Me.TxtDiodePower.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiodePower.Location = New System.Drawing.Point(319, 62)
        Me.TxtDiodePower.Name = "TxtDiodePower"
        Me.TxtDiodePower.Size = New System.Drawing.Size(59, 22)
        Me.TxtDiodePower.TabIndex = 14
        Me.TxtDiodePower.Text = "1,000,000"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(233, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 49)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Laser Diodes"
        '
        'TxtDiodeHeight
        '
        Me.TxtDiodeHeight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiodeHeight.Location = New System.Drawing.Point(384, 63)
        Me.TxtDiodeHeight.Name = "TxtDiodeHeight"
        Me.TxtDiodeHeight.Size = New System.Drawing.Size(55, 22)
        Me.TxtDiodeHeight.TabIndex = 16
        Me.TxtDiodeHeight.Text = "0.000155"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(385, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 50)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Diode Height (Meters)"
        '
        'TxtLaserTowerHeight
        '
        Me.TxtLaserTowerHeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLaserTowerHeight.Location = New System.Drawing.Point(445, 281)
        Me.TxtLaserTowerHeight.Name = "TxtLaserTowerHeight"
        Me.TxtLaserTowerHeight.Size = New System.Drawing.Size(145, 26)
        Me.TxtLaserTowerHeight.TabIndex = 19
        Me.TxtLaserTowerHeight.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tower Height (Meters):"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(607, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "8 root 2GP:"
        '
        'Txt8root2GP
        '
        Me.Txt8root2GP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt8root2GP.Location = New System.Drawing.Point(696, 161)
        Me.Txt8root2GP.Name = "Txt8root2GP"
        Me.Txt8root2GP.Size = New System.Drawing.Size(156, 26)
        Me.Txt8root2GP.TabIndex = 21
        Me.Txt8root2GP.Text = "0"
        '
        'TxtacCubed
        '
        Me.TxtacCubed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtacCubed.Location = New System.Drawing.Point(696, 193)
        Me.TxtacCubed.Name = "TxtacCubed"
        Me.TxtacCubed.Size = New System.Drawing.Size(156, 26)
        Me.TxtacCubed.TabIndex = 23
        Me.TxtacCubed.Text = "0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(607, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "ac cubed:"
        '
        'FrmCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(935, 372)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "FrmCalculate"
        Me.Text = "Calculate Neutron Spin Direction Change by Daniel Goss Feb 2021"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtGravityConstant As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLightSpeed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSquareLength As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLaserIntensity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLaserTowerHeight As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDiodeHeight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDiodePower As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumberOfDiodes As TextBox
    Friend WithEvents TxtResultFrequency As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtacCubed As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt8root2GP As TextBox
    Friend WithEvents Label11 As Label
End Class
