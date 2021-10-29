Public Class Canvas
    'Class wide variables allow access from class methods.
    Dim x1 As Integer = 0
    Dim y1 As Integer = 0
    Dim x2 As Integer = 0
    Dim y2 As Integer = 0
    Dim penColor As Color = Color.Black
    Dim lineStart As Boolean = True

    Public Sub drawLine()

        Dim canvasToDraw As Graphics
        canvasToDraw = Graphics.FromImage(picDrawing.Image)
        Dim myPen As Pen = New Pen(penColor)

        canvasToDraw.DrawLine(myPen, x1, y1, x2, y2)

    End Sub

    Private Sub Canvas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        penColor = Color.Red
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        penColor = Color.Green
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        penColor = Color.Blue
    End Sub

    Private Sub picDrawing_Click(sender As Object, e As EventArgs) Handles picDrawing.Click

        Dim canvasTop As Integer = Me.Top + picDrawing.Top
        Dim canvasLeft As Integer = Me.Left + picDrawing.Left
        Dim xCoOrd As Integer = MousePosition.X
        Dim yCoOrd As Integer = MousePosition.Y

        If (canvasTop < xCoOrd) Then
            xCoOrd = xCoOrd - canvasTop
        Else
            xCoOrd = canvasTop
        End If
        If (canvasLeft < yCoOrd) Then
            yCoOrd = yCoOrd - canvasLeft
        Else
            yCoOrd = canvasLeft
        End If

        If (True = lineStart) Then
            x1 = xCoOrd
            y1 = yCoOrd
            lineStart = False
        Else
            x2 = xCoOrd
            y2 = yCoOrd
            drawLine()
            picDrawing.Refresh()
            lineStart = True
        End If

    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        penColor = Color.Black
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim canvasToDraw As Graphics
        canvasToDraw = Graphics.FromImage(picDrawing.Image)
        canvasToDraw.Clear(Color.White)
        Me.Refresh()

    End Sub
End Class
