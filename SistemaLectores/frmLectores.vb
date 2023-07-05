Imports System.Data.SqlClient
Public Class frmLectores
    Private Sub frmLectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'no permita ingresar id en caso de agregar ya que se autocompleta 
        frmAlta.txtIdentidad.Visible = False
        frmAlta.lblIdentidad.Visible = False
        frmAlta.ShowDialog()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmAlta.ShowDialog()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
End Class
