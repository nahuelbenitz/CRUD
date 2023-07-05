Imports System.Data.SqlClient
Public Class frmLectores
    Private Sub frmLectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'no permita ingresar id en caso de agregar y deshabilita el modificar
        frmAlta.txtIdentidad.Visible = False
        frmAlta.lblIdentidad.Visible = False
        frmAlta.btnModificar.Enabled = False
        frmAlta.btnEliminar.Enabled = False
        limpiar()
        frmAlta.ShowDialog()
        frmAlta.btnModificar.Enabled = True
        frmAlta.txtIdentidad.Visible = True
        frmAlta.lblIdentidad.Visible = True
        frmAlta.btnEliminar.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        frmAlta.txtIdentidad.Text = dgvLectores.SelectedCells(0).Value
        frmAlta.txtNombre.Text = dgvLectores.SelectedCells(1).Value
        frmAlta.txtTelefono.Text = dgvLectores.SelectedCells(2).Value
        frmAlta.txtDireccion.Text = dgvLectores.SelectedCells(3).Value
        frmAlta.txtObservacion.Text = dgvLectores.SelectedCells(4).Value
        frmAlta.btnAceptar.Enabled = False
        frmAlta.txtIdentidad.ReadOnly = True
        frmAlta.ShowDialog()
        frmAlta.btnAceptar.Enabled = True
    End Sub
End Class
