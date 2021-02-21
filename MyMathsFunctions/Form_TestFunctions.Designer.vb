<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTestFunctions
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlTestRoot = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRootAnswer = New System.Windows.Forms.TextBox()
        Me.BtnRootTestCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRootIndicie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRootNumberEntry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlTestRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.BtnClose)
        Me.pnlTop.Location = New System.Drawing.Point(1, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(787, 56)
        Me.pnlTop.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(40, 10)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 30)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlTestRoot)
        Me.pnlMain.Location = New System.Drawing.Point(1, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(787, 224)
        Me.pnlMain.TabIndex = 1
        '
        'pnlTestRoot
        '
        Me.pnlTestRoot.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlTestRoot.Controls.Add(Me.Label4)
        Me.pnlTestRoot.Controls.Add(Me.TxtRootAnswer)
        Me.pnlTestRoot.Controls.Add(Me.BtnRootTestCalculate)
        Me.pnlTestRoot.Controls.Add(Me.Label3)
        Me.pnlTestRoot.Controls.Add(Me.TxtRootIndicie)
        Me.pnlTestRoot.Controls.Add(Me.Label2)
        Me.pnlTestRoot.Controls.Add(Me.TxtRootNumberEntry)
        Me.pnlTestRoot.Controls.Add(Me.Label1)
        Me.pnlTestRoot.Location = New System.Drawing.Point(0, 3)
        Me.pnlTestRoot.Name = "pnlTestRoot"
        Me.pnlTestRoot.Size = New System.Drawing.Size(767, 100)
        Me.pnlTestRoot.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Root Test Calculation"
        '
        'TxtRootAnswer
        '
        Me.TxtRootAnswer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRootAnswer.Location = New System.Drawing.Point(534, 56)
        Me.TxtRootAnswer.Name = "TxtRootAnswer"
        Me.TxtRootAnswer.Size = New System.Drawing.Size(217, 22)
        Me.TxtRootAnswer.TabIndex = 6
        '
        'BtnRootTestCalculate
        '
        Me.BtnRootTestCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRootTestCalculate.Location = New System.Drawing.Point(409, 54)
        Me.BtnRootTestCalculate.Name = "BtnRootTestCalculate"
        Me.BtnRootTestCalculate.Size = New System.Drawing.Size(119, 26)
        Me.BtnRootTestCalculate.TabIndex = 5
        Me.BtnRootTestCalculate.Text = "Calculate Root"
        Me.BtnRootTestCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Natural (default) root indicie = 2"
        '
        'TxtRootIndicie
        '
        Me.TxtRootIndicie.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRootIndicie.Location = New System.Drawing.Point(341, 54)
        Me.TxtRootIndicie.Name = "TxtRootIndicie"
        Me.TxtRootIndicie.Size = New System.Drawing.Size(40, 26)
        Me.TxtRootIndicie.TabIndex = 3
        Me.TxtRootIndicie.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Indicie:"
        '
        'TxtRootNumberEntry
        '
        Me.TxtRootNumberEntry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRootNumberEntry.Location = New System.Drawing.Point(144, 56)
        Me.TxtRootNumberEntry.Name = "TxtRootNumberEntry"
        Me.TxtRootNumberEntry.Size = New System.Drawing.Size(132, 21)
        Me.TxtRootNumberEntry.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Root Number:"
        '
        'FrmTestFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "FrmTestFunctions"
        Me.Text = "Test Math Functions"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlTestRoot.ResumeLayout(False)
        Me.pnlTestRoot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTestRoot As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRootAnswer As TextBox
    Friend WithEvents BtnRootTestCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRootIndicie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRootNumberEntry As TextBox
    Friend WithEvents Label1 As Label
End Class
