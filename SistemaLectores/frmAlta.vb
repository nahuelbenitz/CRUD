Imports System.Data.SqlClient
Public Class frmAlta

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        insertarDatos()
        Close()
        mostrar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'Solo letras y espacio
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        'solo números
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarDatos()
        Close()
        mostrar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If frmLectores.dgvLectores.SelectedRows.Count > 0 Then
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("¿Seguro que querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (respuesta = DialogResult.Yes) Then
                eliminar()
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila", "Sistema de lectores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Close()
        mostrar()
    End Sub
End Class