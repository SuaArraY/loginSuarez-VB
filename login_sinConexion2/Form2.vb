Imports System.Reflection

Public Class Form2

#Region "Usuarios"

    Public user As String = "t"
    Public contra As String = "1"
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (txtUser.Text = user) Or (txtContra.Text = contra) Then

            Me.Hide()

            MsgBox("Usuario y Contraseña Correcto", MsgBoxStyle.Information, "Confirmar")
            limpiar()
            Form1.Show()

        Else
            limpiar()
            MsgBox("Usuario y Contraseña Incorrecto", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Public Sub limpiar()
        txtUser.Text = ""
        txtContra.Text = ""
    End Sub
End Class