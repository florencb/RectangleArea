Public Class Form1

    Dim area As Decimal
    Dim numberOfRectangles As Integer
    Dim smallestRectangle As Decimal = 999999999

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Dim length As Decimal = CDec(txtLength.Text)
        Dim width As Decimal = CDec(txtWidth.Text)

        area = width * length
        numberOfRectangles = numberOfRectangles + 1
        smallestRectangle = Math.Min(smallestRectangle, area)

        txtArea.Text = area.ToString
        txtNumberOfRectangles.Text = numberOfRectangles.ToString
        txtSmallestRectangle.Text = smallestRectangle.ToString

        txtLength.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        numberOfRectangles = 0
        area = 0D
        smallestRectangle = 999999999

        txtLength.Text = ""
        txtWidth.Text = ""
        txtArea.Text = ""
        txtNumberOfRectangles.Text = ""
        txtSmallestRectangle.Text = ""

        txtLength.Select()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
