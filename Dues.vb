Public Class Dues
    Public Property monthlyDues As Double

    Private golfAdditional As Double
    Private tennisAdditional As Double
    Private raqcetAdditional As Double

    Private singleSelected As Boolean
    Private famSelected As Boolean
    Private golfSelected As Boolean
    Private tennisSelected As Boolean
    Private raqcetSelected As Boolean

    Public Sub New()
        _monthlyDues = 0
        golfAdditional = 0
        tennisAdditional = 0
        raqcetAdditional = 0
    End Sub

    Public Sub New(ByRef _singleSelected As Boolean, ByRef _famSelected As Boolean, ByRef _golfSelected As Boolean,
                   ByRef _tennisSelected As Boolean, ByRef _raqcetSelected As Boolean)
        singleSelected = _singleSelected
        famSelected = _famSelected
        golfSelected = _golfSelected
        tennisSelected = _tennisSelected
        raqcetSelected = _raqcetSelected

        If (singleSelected = True) Then
            monthlyDues = 50
            golfAdditional = 25
            tennisAdditional = 30
            raqcetAdditional = 20
        ElseIf (famSelected = True) Then
            monthlyDues = 90
            golfAdditional = 35
            tennisAdditional = 50
            raqcetAdditional = 30
        End If
    End Sub

    Public Function GetMonthlyDues() As Double
        If (golfSelected = True) Then
            monthlyDues += golfAdditional
        End If
        If (tennisSelected = True) Then
            monthlyDues += tennisAdditional
        End If
        If (raqcetSelected = True) Then
            monthlyDues += raqcetAdditional
        End If
        Return monthlyDues
    End Function
End Class
