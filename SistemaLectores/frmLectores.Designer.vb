<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLectores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.dgvLectores = New System.Windows.Forms.DataGridView()
        Me.btnVer = New System.Windows.Forms.Button()
        CType(Me.dgvLectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(15, 50)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(744, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(232, 282)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(95, 34)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(444, 282)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(95, 34)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(15, 27)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(61, 13)
        Me.lblFiltro.TabIndex = 14
        Me.lblFiltro.Text = "Filtro rapido"
        '
        'dgvLectores
        '
        Me.dgvLectores.AllowUserToAddRows = False
        Me.dgvLectores.AllowUserToDeleteRows = False
        Me.dgvLectores.AllowUserToResizeColumns = False
        Me.dgvLectores.AllowUserToResizeRows = False
        Me.dgvLectores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLectores.Location = New System.Drawing.Point(15, 87)
        Me.dgvLectores.MultiSelect = False
        Me.dgvLectores.Name = "dgvLectores"
        Me.dgvLectores.ReadOnly = True
        Me.dgvLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLectores.Size = New System.Drawing.Size(744, 151)
        Me.dgvLectores.TabIndex = 1
        '
        'btnVer
        '
        Me.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnVer.BackColor = System.Drawing.Color.White
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Location = New System.Drawing.Point(338, 282)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(95, 34)
        Me.btnVer.TabIndex = 15
        Me.btnVer.Text = "Ver detalle"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'frmLectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(771, 367)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvLectores)
        Me.Controls.Add(Me.txtBuscar)
        Me.MaximumSize = New System.Drawing.Size(787, 560)
        Me.MinimumSize = New System.Drawing.Size(787, 406)
        Me.Name = "frmLectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lectores"
        CType(Me.dgvLectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblFiltro As Label
    Friend WithEvents dgvLectores As DataGridView
    Friend WithEvents btnVer As Button
End Class
