Imports System.IO

Module Module1

    Function GenerateLetter()

        Dim RandomNumber, MaxValue, MinValue As Integer
        Dim Letter As Char
        MaxValue = 90
        MinValue = 65



        RandomNumber = Int((MaxValue - MinValue + 1) * Rnd()) + MinValue

        Letter = Chr(RandomNumber)
        Return Letter

    End Function

    Function TestSelected(ByVal Cell As Label)

        If Cell.BackColor = Color.SteelBlue Then
            Return False
        Else
            Return True
        End If

    End Function








End Module
