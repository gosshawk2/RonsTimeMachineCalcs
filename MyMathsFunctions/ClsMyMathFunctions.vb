Public Class ClsMyMathFunctions
    Private _RootIndicie As Integer
    Private _RootNumberEntry As Double
    Private _RootAnswer As Double
    Private _ErrorMessage As String

    Property RootIndicie As Integer
        Get
            Return _RootIndicie
        End Get
        Set(value As Integer)
            _RootIndicie = value
        End Set
    End Property

    Property RootNumberEntry As Double
        Get
            Return _RootNumberEntry
        End Get
        Set(value As Double)
            _RootNumberEntry = value
        End Set
    End Property

    Property RootAnswer As Double
        Get
            Return _RootAnswer
        End Get
        Set(value As Double)
            _RootAnswer = value
        End Set
    End Property

    Property GetErrorMessage As String
        Get
            Return _ErrorMessage
        End Get
        Set(value As String)
            _ErrorMessage = value
        End Set
    End Property

    Function RootCalc(Number As Double, Indicie As Integer) As Double
        Dim Result As Double = 0

        RootCalc = 0
        If Indicie = 0 Or Indicie = 1 Then
            Indicie = 2
        End If
        Me.GetErrorMessage = ""
        If Number = 0 Then
            Me.GetErrorMessage = "Cannot perform calc on 0"
            Return Result
        End If

        Result = Number
        If Indicie > 2 Then
            For nn As Integer = 0 To Indicie - 1
                Result = System.Math.Sqrt(Result)
            Next
        End If
        Me.RootNumberEntry = Number
        Me.RootIndicie = Indicie
        Me.RootAnswer = Result
        Return Result
    End Function

    Function PowerCalc(Number As Double, PowerIndicie As Double) As Double
        Dim Result As Double = 0

        PowerCalc = 0
        Me.GetErrorMessage = ""
        Result = System.Math.Pow(Number, PowerIndicie)
        Return Result

    End Function

End Class
