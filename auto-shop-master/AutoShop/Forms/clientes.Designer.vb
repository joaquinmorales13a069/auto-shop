<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.datagridview_clientes = New System.Windows.Forms.DataGridView()
        Me.IdclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoclienteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoshopDataSet = New AutoShop.autoshopDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox02 = New System.Windows.Forms.TextBox()
        Me.TextBox03 = New System.Windows.Forms.TextBox()
        Me.TextBox04 = New System.Windows.Forms.TextBox()
        Me.TextBox05 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Insertar_button = New System.Windows.Forms.Button()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.eliminar_button = New System.Windows.Forms.Button()
        Me.buscar_button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox01 = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New AutoShop.autoshopDataSetTableAdapters.clientesTableAdapter()
        CType(Me.datagridview_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoshopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridview_clientes
        '
        Me.datagridview_clientes.AutoGenerateColumns = False
        Me.datagridview_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridview_clientes.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagridview_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdclientesDataGridViewTextBoxColumn, Me.NombreclienteDataGridViewTextBoxColumn, Me.TelefonoclienteDataGridViewTextBoxColumn, Me.DireccionclienteDataGridViewTextBoxColumn, Me.EstadoclienteDataGridViewCheckBoxColumn})
        Me.datagridview_clientes.DataSource = Me.ClientesBindingSource
        Me.datagridview_clientes.Location = New System.Drawing.Point(243, 294)
        Me.datagridview_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview_clientes.Name = "datagridview_clientes"
        Me.datagridview_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview_clientes.Size = New System.Drawing.Size(1176, 325)
        Me.datagridview_clientes.TabIndex = 0
        '
        'IdclientesDataGridViewTextBoxColumn
        '
        Me.IdclientesDataGridViewTextBoxColumn.DataPropertyName = "idclientes"
        Me.IdclientesDataGridViewTextBoxColumn.HeaderText = "idclientes"
        Me.IdclientesDataGridViewTextBoxColumn.Name = "IdclientesDataGridViewTextBoxColumn"
        '
        'NombreclienteDataGridViewTextBoxColumn
        '
        Me.NombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombrecliente"
        Me.NombreclienteDataGridViewTextBoxColumn.HeaderText = "nombrecliente"
        Me.NombreclienteDataGridViewTextBoxColumn.Name = "NombreclienteDataGridViewTextBoxColumn"
        '
        'TelefonoclienteDataGridViewTextBoxColumn
        '
        Me.TelefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefonocliente"
        Me.TelefonoclienteDataGridViewTextBoxColumn.HeaderText = "telefonocliente"
        Me.TelefonoclienteDataGridViewTextBoxColumn.Name = "TelefonoclienteDataGridViewTextBoxColumn"
        '
        'DireccionclienteDataGridViewTextBoxColumn
        '
        Me.DireccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccioncliente"
        Me.DireccionclienteDataGridViewTextBoxColumn.HeaderText = "direccioncliente"
        Me.DireccionclienteDataGridViewTextBoxColumn.Name = "DireccionclienteDataGridViewTextBoxColumn"
        '
        'EstadoclienteDataGridViewCheckBoxColumn
        '
        Me.EstadoclienteDataGridViewCheckBoxColumn.DataPropertyName = "estadocliente"
        Me.EstadoclienteDataGridViewCheckBoxColumn.HeaderText = "estadocliente"
        Me.EstadoclienteDataGridViewCheckBoxColumn.Name = "EstadoclienteDataGridViewCheckBoxColumn"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.AutoshopDataSet
        '
        'AutoshopDataSet
        '
        Me.AutoshopDataSet.DataSetName = "autoshopDataSet"
        Me.AutoshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(530, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(955, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Direccion"
        '
        'TextBox02
        '
        Me.TextBox02.Location = New System.Drawing.Point(622, 102)
        Me.TextBox02.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox02.Name = "TextBox02"
        Me.TextBox02.Size = New System.Drawing.Size(148, 22)
        Me.TextBox02.TabIndex = 4
        '
        'TextBox03
        '
        Me.TextBox03.Location = New System.Drawing.Point(622, 156)
        Me.TextBox03.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox03.Name = "TextBox03"
        Me.TextBox03.Size = New System.Drawing.Size(148, 22)
        Me.TextBox03.TabIndex = 5
        '
        'TextBox04
        '
        Me.TextBox04.Location = New System.Drawing.Point(1043, 95)
        Me.TextBox04.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox04.Name = "TextBox04"
        Me.TextBox04.Size = New System.Drawing.Size(247, 22)
        Me.TextBox04.TabIndex = 6
        '
        'TextBox05
        '
        Me.TextBox05.Location = New System.Drawing.Point(1043, 146)
        Me.TextBox05.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox05.Name = "TextBox05"
        Me.TextBox05.Size = New System.Drawing.Size(40, 22)
        Me.TextBox05.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(955, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'Insertar_button
        '
        Me.Insertar_button.Location = New System.Drawing.Point(348, 218)
        Me.Insertar_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Insertar_button.Name = "Insertar_button"
        Me.Insertar_button.Size = New System.Drawing.Size(249, 28)
        Me.Insertar_button.TabIndex = 9
        Me.Insertar_button.Text = "Insertar"
        Me.Insertar_button.UseVisualStyleBackColor = True
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(598, 218)
        Me.Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(249, 28)
        Me.Actualizar.TabIndex = 10
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'eliminar_button
        '
        Me.eliminar_button.Location = New System.Drawing.Point(852, 218)
        Me.eliminar_button.Margin = New System.Windows.Forms.Padding(4)
        Me.eliminar_button.Name = "eliminar_button"
        Me.eliminar_button.Size = New System.Drawing.Size(249, 28)
        Me.eliminar_button.TabIndex = 11
        Me.eliminar_button.Text = "Borrar"
        Me.eliminar_button.UseVisualStyleBackColor = True
        '
        'buscar_button
        '
        Me.buscar_button.Location = New System.Drawing.Point(1106, 218)
        Me.buscar_button.Margin = New System.Windows.Forms.Padding(4)
        Me.buscar_button.Name = "buscar_button"
        Me.buscar_button.Size = New System.Drawing.Size(249, 28)
        Me.buscar_button.TabIndex = 12
        Me.buscar_button.Text = "Buscar"
        Me.buscar_button.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(510, 54)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID del cliente"
        '
        'TextBox01
        '
        Me.TextBox01.Location = New System.Drawing.Point(622, 54)
        Me.TextBox01.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox01.Name = "TextBox01"
        Me.TextBox01.Size = New System.Drawing.Size(148, 22)
        Me.TextBox01.TabIndex = 15
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.AutoShop.My.Resources.Resources.background_catalogos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1632, 661)
        Me.Controls.Add(Me.TextBox01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.buscar_button)
        Me.Controls.Add(Me.eliminar_button)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Insertar_button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox05)
        Me.Controls.Add(Me.TextBox04)
        Me.Controls.Add(Me.TextBox03)
        Me.Controls.Add(Me.TextBox02)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datagridview_clientes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "clientes"
        Me.Text = "Catalogo Clientes"
        CType(Me.datagridview_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoshopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagridview_clientes As DataGridView
    Friend WithEvents AutoshopDataSet As autoshopDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As autoshopDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents IdclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoclienteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox02 As TextBox
    Friend WithEvents TextBox03 As TextBox
    Friend WithEvents TextBox04 As TextBox
    Friend WithEvents TextBox05 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Insertar_button As Button
    Friend WithEvents Actualizar As Button
    Friend WithEvents eliminar_button As Button
    Friend WithEvents buscar_button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox01 As TextBox
End Class
