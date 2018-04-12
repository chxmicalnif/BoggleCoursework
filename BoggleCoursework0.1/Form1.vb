Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click



        For Row = 0 To 6
            For Col = 0 To 6
                Grid(Row, Col).Text = GenerateLetter()
            Next
        Next




        'Row1Col1.Text = GenerateLetter()
        'Row1Col2.Text = GenerateLetter()
        'Row1Col3.Text = GenerateLetter()
        'Row1Col4.Text = GenerateLetter()
        'Row1Col5.Text = GenerateLetter()
        'Row1Col6.Text = GenerateLetter()
        'Row1Col7.Text = GenerateLetter()

        'Row2Col1
        'Row2Col2
        'Row2Col3
        'Row2Col4
        'Row2Col5
        'Row2Col6
        'Row2Col7

        'Row3Col1
        'Row3col2
        'Row3Col3
        'Row3Col4
        'Row3Col5
        'Row3Col6
        'Row3Col7

        'Row4Col1
        'Row4Col2
        'Row4Col3
        'Row4Col4
        'Row4Col5
        'Row4Col6
        'Row4Col7



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid(0, 0) = Me.Row1Col1
        Grid(0, 1) = Me.Row1Col2
        Grid(0, 2) = Me.Row1Col3
        Grid(0, 3) = Me.Row1Col4
        Grid(0, 4) = Me.Row1Col5
        Grid(0, 5) = Me.Row1Col6
        Grid(0, 6) = Me.Row1Col7

        Grid(1, 0) = Me.Row2Col1
        Grid(1, 1) = Me.Row2Col2
        Grid(1, 2) = Me.Row2Col3
        Grid(1, 3) = Me.Row2Col4
        Grid(1, 4) = Me.Row2Col5
        Grid(1, 5) = Me.Row2Col6
        Grid(1, 6) = Me.Row2Col7

        Grid(2, 0) = Me.Row3Col1
        Grid(2, 1) = Me.Row3col2
        Grid(2, 2) = Me.Row3Col3
        Grid(2, 3) = Me.Row3Col4
        Grid(2, 4) = Me.Row3Col5
        Grid(2, 5) = Me.Row3Col6
        Grid(2, 6) = Me.Row3Col7

        Grid(3, 0) = Me.Row4Col1
        Grid(3, 1) = Me.Row4Col2
        Grid(3, 2) = Me.Row4Col3
        Grid(3, 3) = Me.Row4Col4
        Grid(3, 4) = Me.Row4Col5
        Grid(3, 5) = Me.Row4Col6
        Grid(3, 6) = Me.Row4Col7

        Grid(4, 0) = Me.Row5Col1
        Grid(4, 1) = Me.Row5Col2
        Grid(4, 2) = Me.Row5Col3
        Grid(4, 3) = Me.Row5Col4
        Grid(4, 4) = Me.Row5Col5
        Grid(4, 5) = Me.Row5Col6
        Grid(4, 6) = Me.Row5Col7

        Grid(5, 0) = Me.Row6Col1
        Grid(5, 1) = Me.Row6Col2
        Grid(5, 2) = Me.Row6Col3
        Grid(5, 3) = Me.Row6Col4
        Grid(5, 4) = Me.Row6Col5
        Grid(5, 5) = Me.Row6Col6
        Grid(5, 6) = Me.Row6Col7

        Grid(6, 0) = Me.Row7Col1
        Grid(6, 1) = Me.Row7Col2
        Grid(6, 2) = Me.Row7Col3
        Grid(6, 3) = Me.Row7Col4
        Grid(6, 4) = Me.Row7Col5
        Grid(6, 5) = Me.Row7Col6
        Grid(6, 6) = Me.Row7Col7








    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Row = 0 To 6
            For Col = 0 To 6
                Grid(Row, Col).Text = ""
            Next
        Next

    End Sub

    Private Sub Row1Col1_Click(sender As Object, e As EventArgs) Handles Row1Col1.Click
        Dim Selected As Boolean

        Selected = TestSelected(Row1Col1)

        If Selected Then
            Row1Col1.BackColor = Color.SteelBlue
            Selected = False
        Else
            Row1Col1.BackColor = Color.Turquoise
            Selected = True

        End If
    End Sub
End Class
