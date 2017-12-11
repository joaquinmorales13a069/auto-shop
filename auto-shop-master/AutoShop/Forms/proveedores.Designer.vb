<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Me.DataGridView_proveedores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Insertar_button = New System.Windows.Forms.Button()
        Me.Actualizar_button = New System.Windows.Forms.Button()
        Me.Borrar_button = New System.Windows.Forms.Button()
        Me.Buscar_button = New System.Windows.Forms.Button()
        Me.IdproveedoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoproveedorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoshopDataSet_proveedores = New AutoShop.autoshopDataSet_proveedores()
        Me.ProveedoresTableAdapter = New AutoShop.autoshopDataSet_proveedoresTableAdapters.proveedoresTableAdapter()
        CType(Me.DataGridView_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoshopDataSet_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_proveedores
        '
        Me.DataGridView_proveedores.AutoGenerateColumns = False
        Me.DataGridView_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproveedoresDataGridViewTextBoxColumn, Me.NombreproveedorDataGridViewTextBoxColumn, Me.TelefonoproveedorDataGridViewTextBoxColumn, Me.DireccionproveedorDataGridViewTextBoxColumn, Me.EstadoproveedorDataGridViewCheckBoxColumn})
        Me.DataGridView_proveedores.DataSource = Me.ProveedoresBindingSource
        Me.DataGridView_proveedores.Location = New System.Drawing.Point(62, 210)
        Me.DataGridView_proveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView_proveedores.Name = "DataGridView_proveedores"
        Me.DataGridView_proveedores.Size = New System.Drawing.Size(1320, 473)
        Me.DataGridView_proveedores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id del Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(694, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(697, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(543, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(543, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(543, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(802, 37)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(378, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(802, 75)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(50, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Insertar_button
        '
        Me.Insertar_button.Location = New System.Drawing.Point(283, 170)
        Me.Insertar_button.Name = "Insertar_button"
        Me.Insertar_button.Size = New System.Drawing.Size(202, 23)
        Me.Insertar_button.TabIndex = 11
        Me.Insertar_button.Text = "Insertar"
        Me.Insertar_button.UseVisualStyleBackColor = True
        '
        'Actualizar_button
        '
        Me.Actualizar_button.Location = New System.Drawing.Point(501, 170)
        Me.Actualizar_button.Name = "Actualizar_button"
        Me.Actualizar_button.Size = New System.Drawing.Size(202, 23)
        Me.Actualizar_button.TabIndex = 12
        Me.Actualizar_button.Text = "Actualizar"
        Me.Actualizar_button.UseVisualStyleBackColor = True
        '
        'Borrar_button
        '
        Me.Borrar_button.Location = New System.Drawing.Point(718, 170)
        Me.Borrar_button.Name = "Borrar_button"
        Me.Borrar_button.Size = New System.Drawing.Size(202, 23)
        Me.Borrar_button.TabIndex = 13
        Me.Borrar_button.Text = "Borrar"
        Me.Borrar_button.UseVisualStyleBackColor = True
        '
        'Buscar_button
        '
        Me.Buscar_button.Location = New System.Drawing.Point(935, 170)
        Me.Buscar_button.Name = "Buscar_button"
        Me.Buscar_button.Size = New System.Drawing.Size(202, 23)
        Me.Buscar_button.TabIndex = 14
        Me.Buscar_button.Text = "Buscar"
        Me.Buscar_button.UseVisualStyleBackColor = True
        '
        'IdproveedoresDataGridViewTextBoxColumn
        '
        Me.IdproveedoresDataGridViewTextBoxColumn.DataPropertyName = "idproveedores"
        Me.IdproveedoresDataGridViewTextBoxColumn.HeaderText = "idproveedores"
        Me.IdproveedoresDataGridViewTextBoxColumn.Name = "IdproveedoresDataGridViewTextBoxColumn"
        '
        'NombreproveedorDataGridViewTextBoxColumn
        '
        Me.NombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombreproveedor"
        Me.NombreproveedorDataGridViewTextBoxColumn.HeaderText = "nombreproveedor"
        Me.NombreproveedorDataGridViewTextBoxColumn.Name = "NombreproveedorDataGridViewTextBoxColumn"
        '
        'TelefonoproveedorDataGridViewTextBoxColumn
        '
        Me.TelefonoproveedorDataGridViewTextBoxColumn.DataPropertyName = "telefonoproveedor"
        Me.TelefonoproveedorDataGridViewTextBoxColumn.HeaderText = "telefonoproveedor"
        Me.TelefonoproveedorDataGridViewTextBoxColumn.Name = "TelefonoproveedorDataGridViewTextBoxColumn"
        '
        'DireccionproveedorDataGridViewTextBoxColumn
        '
        Me.DireccionproveedorDataGridViewTextBoxColumn.DataPropertyName = "direccionproveedor"
        Me.DireccionproveedorDataGridViewTextBoxColumn.HeaderText = "direccionproveedor"
        Me.DireccionproveedorDataGridViewTextBoxColumn.Name = "DireccionproveedorDataGridViewTextBoxColumn"
        '
        'EstadoproveedorDataGridViewCheckBoxColumn
        '
        Me.EstadoproveedorDataGridViewCheckBoxColumn.DataPropertyName = "estadoproveedor"
        Me.EstadoproveedorDataGridViewCheckBoxColumn.HeaderText = "estadoproveedor"
        Me.EstadoproveedorDataGridViewCheckBoxColumn.Name = "EstadoproveedorDataGridViewCheckBoxColumn"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.AutoshopDataSet_proveedores
        '
        'AutoshopDataSet_proveedores
        '
        Me.AutoshopDataSet_proveedores.DataSetName = "autoshopDataSet_proveedores"
        Me.AutoshopDataSet_proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AutoShop.My.Resources.Resources.background_catalogos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1472, 698)
        Me.Controls.Add(Me.Buscar_button)
        Me.Controls.Add(Me.Borrar_button)
        Me.Controls.Add(Me.Actualizar_button)
        Me.Controls.Add(Me.Insertar_button)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_proveedores)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "proveedores"
        Me.Text = "proveedores"
        CType(Me.DataGridView_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoshopDataSet_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_proveedores As DataGridView
    Friend WithEvents AutoshopDataSet_proveedores As autoshopDataSet_proveedores
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As autoshopDataSet_proveedoresTableAdapters.proveedoresTableAdapter
    Friend WithEvents IdproveedoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoproveedorDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Insertar_button As Button
    Friend WithEvents Actualizar_button As Button
    Friend WithEvents Borrar_button As Button
    Friend WithEvents Buscar_button As Button
End Class
