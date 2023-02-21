Imports System.ComponentModel
Imports System.Reflection.PortableExecutable

Public Class frmAirbnb
    Const cdecCostPerNight As Decimal = 79D
    Private Sub frmAirbnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrice.Text = "Only " & cdecCostPerNight.ToString("C") & " per night"
        lblTotal.Text = ""
        txtNights.Clear()
        txtNights.Focus()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal
        strNumNights = txtNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * cdecCostPerNight
        lblTotal.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotal.Text = ""
        txtNights.Clear()
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
