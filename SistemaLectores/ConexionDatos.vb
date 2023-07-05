Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Module ConexionDatos

    Public conexion As New SqlConnection("server=NOT027; database=BD_CRUD; integrated security=true")


    Public Sub abrirConexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If

    End Sub

    Public Sub cerrarConexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If

    End Sub

    Public Sub insertarDatos()
        Dim comando As New SqlCommand
        If frmAlta.txtNombre.Text <> "" Then
            Try
                abrirConexion()

                'utilizamos el procedimiento almacenado previamente creado
                comando = New SqlCommand("Insertar_Lector", conexion)
                comando.CommandType = 4

                'pasamos los valores por parametro
                comando.Parameters.AddWithValue("@Nombre", frmAlta.txtNombre.Text.ToString)
                comando.Parameters.AddWithValue("@Telefono", frmAlta.txtTelefono.Text.ToString)
                comando.Parameters.AddWithValue("@Direccion", frmAlta.txtDireccion.Text.ToString)
                comando.Parameters.AddWithValue("@Observacion", frmAlta.txtObservacion.Text.ToString)
                comando.ExecuteNonQuery()
                MessageBox.Show("Agregado exitosamente", "Sistema de lectores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cerrarConexion()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
            End Try
        Else
            MessageBox.Show("Por favor, completar datos importantes faltantes", "Sistema de lectores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub modificarDatos()

    End Sub

    'Public Sub modificarDatos()
    '    Dim comando As New SqlCommand
    '    If frmAlta.txtNombre.Text <> "" And frmAlta.txtIdentidad.Text <> "" Then
    '        Try
    '            abrirConexion()
    '            comando = New SqlCommand("Insertar_Lector", conexion)
    '            comando.CommandType = 4

    '            comando.Parameters.AddWithValue("@IdLector", frmAlta.txtIdentidad.Text.ToString)
    '            comando.Parameters.AddWithValue("@Nombre", frmAlta.txtNombre.Text.ToString)
    '            comando.Parameters.AddWithValue("@Telefono", frmAlta.txtTelefono.Text.ToString)
    '            comando.Parameters.AddWithValue("@Direccion", frmAlta.txtDireccion.Text.ToString)
    '            comando.Parameters.AddWithValue("@Observacion", frmAlta.txtObservacion.Text.ToString)
    '            comando.ExecuteNonQuery()
    '            MessageBox.Show("Modificado exitosamente", "Sistema de lectores", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            cerrarConexion()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        Finally
    '        End Try
    '    Else
    '        MessageBox.Show("Por favor, completar datos importantes faltantes", "Sistema de lectores", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Public Sub mostrar()
        'auxiliares
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        'cargamos el dgv
        Try
            abrirConexion()
            da = New SqlDataAdapter("Mostrar_Lector", conexion)
            da.Fill(dt)
            frmLectores.dgvLectores.DataSource = dt
            cerrarConexion()

            'ancho de columnas automatico
            frmLectores.dgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Public Sub buscar()
        'auxiliares
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        'cargamos el dgv
        Try
            abrirConexion()
            da = New SqlDataAdapter("Buscar_Lector", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", frmLectores.txtBuscar.Text)
            da.Fill(dt)
            frmLectores.dgvLectores.DataSource = dt
            cerrarConexion()

            'ancho de columnas automatico
            frmLectores.dgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub limpiar()
        frmAlta.txtIdentidad.Clear()
        frmAlta.txtNombre.Clear()
        frmAlta.txtTelefono.Clear()
        frmAlta.txtDireccion.Clear()
        frmAlta.txtObservacion.Clear()
    End Sub

End Module
