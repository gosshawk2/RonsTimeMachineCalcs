Public Class FrmCalculate
    Private _8root2GP As Double
    Private _acCubed As Double

    Property EightRoot2GP As Double
        Get
            Return _8root2GP
        End Get
        Set(value As Double)
            _8root2GP = value
        End Set
    End Property

    Property acCubed As Double
        Get
            Return _acCubed
        End Get
        Set(value As Double)
            _acCubed = value
        End Set
    End Property

    Private Sub FrmCalculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form_Main
        PopulateForm()
    End Sub

    Sub PopulateForm()
        txtLightSpeed.Text = "300000"
        txtGravityConstant.Text = "9.8"
    End Sub

    Function CalcTowerHeight() As Double
        Dim Result As Double = 0
        Dim DiodeHeight As Double = 0
        Dim NumberofDiodes As Integer = 0

        CalcTowerHeight = 0
        If TxtNumberOfDiodes.Text <> "" Then
            If IsNumeric(TxtNumberOfDiodes.Text) Then
                NumberofDiodes = CInt(TxtNumberOfDiodes.Text)
            Else
                MsgBox("Enter Number of Diodes")
                Exit Function
            End If
        End If

        If TxtDiodeHeight.Text <> "" Then
            If IsNumeric(TxtDiodeHeight.Text) Then
                DiodeHeight = CDbl(TxtDiodeHeight.Text)
            Else
                MsgBox("Enter Diode Height")
                Exit Function
            End If
        End If
        Result = System.Math.Abs(NumberofDiodes) * DiodeHeight
        Return Result

    End Function

    Function CalculatePowerOutput() As Double
        Dim Result As Double = 0
        Dim DiodePower As Double = 0
        Dim NumberofDiodes As Integer = 0

        CalculatePowerOutput = 0
        If TxtNumberOfDiodes.Text <> "" Then
            If IsNumeric(TxtNumberOfDiodes.Text) Then
                NumberofDiodes = CInt(TxtNumberOfDiodes.Text)
            Else
                MsgBox("Enter Number of Diodes")
                Exit Function
            End If
        End If

        If TxtDiodePower.Text <> "" Then
            If IsNumeric(TxtDiodePower.Text) Then
                DiodePower = CDbl(TxtDiodePower.Text)
            Else
                MsgBox("Enter Diode Power")
                Exit Function
            End If
        End If
        Result = System.Math.Abs(NumberofDiodes) * DiodePower
        Return Result

    End Function

    Function CalculateRonsEquation() As Double
        Dim NeutronSpinResult As Double = 0.0
        Dim PowerOutput As Double = 0.0
        Dim LightSpeed As Double = 0.0
        Dim GravityConstant As Double = 0.0
        Dim SquareLength As Double = 0.0
        Dim TwoGP As Double = 0.0
        Dim ACCubed As Double = 0.0
        Dim RootTwoGP As Double = 0.0
        Dim LightCubed As Double = 0.0
        Dim MyFunctions As New MyMathsFunctions.ClsMyMathFunctions

        CalculateRonsEquation = 0
        If txtLaserIntensity.Text <> "" Then
            If IsNumeric(txtLaserIntensity.Text) Then
                PowerOutput = CDbl(txtLaserIntensity.Text)
            Else
                MsgBox("Enter Laser Power Output")
                Exit Function
            End If
        End If

        If txtLightSpeed.Text <> "" Then
            If IsNumeric(txtLightSpeed.Text) Then
                LightSpeed = CDbl(txtLightSpeed.Text)
            Else
                MsgBox("Enter Light Speed in KM/SEC")
                Exit Function
            End If
        End If

        If txtGravityConstant.Text <> "" Then
            If IsNumeric(txtGravityConstant.Text) Then
                GravityConstant = CDbl(txtGravityConstant.Text)
            Else
                MsgBox("Enter Gravity Constant (usually 9.8)")
                Exit Function
            End If
        End If

        If txtSquareLength.Text <> "" Then
            If IsNumeric(txtSquareLength.Text) Then
                SquareLength = CDbl(txtSquareLength.Text)
            Else
                MsgBox("Enter Square Length (Meters)")
                Exit Function
            End If
        End If
        TwoGP = 2 * GravityConstant * PowerOutput
        RootTwoGP = MyFunctions.RootCalc(TwoGP, 8)
        Me.EightRoot2GP = RootTwoGP
        LightCubed = MyFunctions.PowerCalc(LightSpeed, 3.0)
        ACCubed = SquareLength * LightCubed
        Me.acCubed = ACCubed
        NeutronSpinResult = RootTwoGP / ACCubed
        Return NeutronSpinResult

    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'https://github.com/gosshawk2/MyFirstAttemptEquation
        Me.Close()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        'Calculate Rons Equation:
        Dim NeutronSpinResult As Double

        NeutronSpinResult = CalculateRonsEquation()
        TxtResultFrequency.Text = NeutronSpinResult
        Txt8root2GP.Text = Me.EightRoot2GP
        TxtacCubed.Text = Format(Me.acCubed, "###,###,#.0")
    End Sub

    Private Sub TxtNumberOfDiodes_Leave(sender As Object, e As EventArgs) Handles TxtNumberOfDiodes.Leave
        'Calculate Total Power Output of laser:
        Dim PowerResult As Double
        Dim HeightResult As Double

        PowerResult = CalculatePowerOutput()
        txtLaserIntensity.Text = CDbl(PowerResult)
        HeightResult = CalcTowerHeight()
        TxtLaserTowerHeight.Text = CDbl(HeightResult)
    End Sub

    Private Sub TxtDiodePower_Leave(sender As Object, e As EventArgs) Handles TxtDiodePower.Leave
        'Calculate Total Power Output of laser:
        Dim Result As Double

        Result = CalculatePowerOutput()
        txtLaserIntensity.Text = CDbl(Result)
    End Sub

    Private Sub TxtDiodeHeight_Leave(sender As Object, e As EventArgs) Handles TxtDiodeHeight.Leave
        'Calculate Tower Height:
        Dim Result As Double

        Result = CalcTowerHeight()
        TxtLaserTowerHeight.Text = CDbl(Result)
    End Sub
End Class
