<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
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
        Me.DataGridView_productos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Insertar_productos = New System.Windows.Forms.Button()
        Me.Actualizar_productos = New System.Windows.Forms.Button()
        Me.Borrar_productos = New System.Windows.Forms.Button()
        Me.Buscar_productos = New System.Windows.Forms.Button()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoproductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoshopDataSet_productos = New AutoShop.autoshopDataSet_productos()
        Me.ProductosTableAdapter = New AutoShop.autoshopDataSet_productosTableAdapters.productosTableAdapter()
        CType(Me.DataGridView_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoshopDataSet_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_productos
        '
        Me.DataGridView_productos.AutoGenerateColumns = False
        Me.DataGridView_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.NombreproductoDataGridViewTextBoxColumn, Me.TipoproductoDataGridViewTextBoxColumn, Me.PrecioproductoDataGridViewTextBoxColumn, Me.CantidadproductoDataGridViewTextBoxColumn, Me.MarcaproductoDataGridViewTextBoxColumn, Me.IdproveedorDataGridViewTextBoxColumn, Me.EstadoproductoDataGridViewCheckBoxColumn})
        Me.DataGridView_productos.DataSource = Me.ProductosBindingSource
        Me.DataGridView_productos.Location = New System.Drawing.Point(203, 278)
        Me.DataGridView_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView_productos.Name = "DataGridView_productos"
        Me.DataGridView_productos.Size = New System.Drawing.Size(1617, 356)
        Me.DataGridView_productos.TabIndex = 0
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(398, 62)
        Me.ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(120, 16)
        Me.ID.TabIndex = 1
        Me.ID.Text = "ID del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo de Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(986, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(971, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(991, 167)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Marca"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1448, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ID del proveedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1423, 111)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Estado del Producto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(530, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(530, 164)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 22)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(530, 111)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(294, 22)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1055, 58)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(94, 22)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1055, 107)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(94, 22)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1055, 164)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(223, 22)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1586, 58)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(44, 22)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1586, 107)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(44, 22)
        Me.TextBox8.TabIndex = 15
        '
        'Insertar_productos
        '
        Me.Insertar_productos.Location = New System.Drawing.Point(494, 226)
        Me.Insertar_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Insertar_productos.Name = "Insertar_productos"
        Me.Insertar_productos.Size = New System.Drawing.Size(244, 28)
        Me.Insertar_productos.TabIndex = 16
        Me.Insertar_productos.Text = "Insertar"
        Me.Insertar_productos.UseVisualStyleBackColor = True
        '
        'Actualizar_productos
        '
        Me.Actualizar_productos.Location = New System.Drawing.Point(747, 226)
        Me.Actualizar_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Actualizar_productos.Name = "Actualizar_productos"
        Me.Actualizar_productos.Size = New System.Drawing.Size(244, 28)
        Me.Actualizar_productos.TabIndex = 17
        Me.Actualizar_productos.Text = "Actualizar"
        Me.Actualizar_productos.UseVisualStyleBackColor = True
        '
        'Borrar_productos
        '
        Me.Borrar_productos.Location = New System.Drawing.Point(1001, 226)
        Me.Borrar_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Borrar_productos.Name = "Borrar_productos"
        Me.Borrar_productos.Size = New System.Drawing.Size(244, 28)
        Me.Borrar_productos.TabIndex = 18
        Me.Borrar_productos.Text = "Borrar"
        Me.Borrar_productos.UseVisualStyleBackColor = True
        '
        'Buscar_productos
        '
        Me.Buscar_productos.Location = New System.Drawing.Point(1255, 226)
        Me.Buscar_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Buscar_productos.Name = "Buscar_productos"
        Me.Buscar_productos.Size = New System.Drawing.Size(244, 28)
        Me.Buscar_productos.TabIndex = 19
        Me.Buscar_productos.Text = "Buscar"
        Me.Buscar_productos.UseVisualStyleBackColor = True
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        '
        'NombreproductoDataGridViewTextBoxColumn
        '
        Me.NombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombreproducto"
        Me.NombreproductoDataGridViewTextBoxColumn.HeaderText = "nombreproducto"
        Me.NombreproductoDataGridViewTextBoxColumn.Name = "NombreproductoDataGridViewTextBoxColumn"
        '
        'TipoproductoDataGridViewTextBoxColumn
        '
        Me.TipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipoproducto"
        Me.TipoproductoDataGridViewTextBoxColumn.HeaderText = "tipoproducto"
        Me.TipoproductoDataGridViewTextBoxColumn.Name = "TipoproductoDataGridViewTextBoxColumn"
        '
        'PrecioproductoDataGridViewTextBoxColumn
        '
        Me.PrecioproductoDataGridViewTextBoxColumn.DataPropertyName = "precioproducto"
        Me.PrecioproductoDataGridViewTextBoxColumn.HeaderText = "precioproducto"
        Me.PrecioproductoDataGridViewTextBoxColumn.Name = "PrecioproductoDataGridViewTextBoxColumn"
        '
        'CantidadproductoDataGridViewTextBoxColumn
        '
        Me.CantidadproductoDataGridViewTextBoxColumn.DataPropertyName = "cantidadproducto"
        Me.CantidadproductoDataGridViewTextBoxColumn.HeaderText = "cantidadproducto"
        Me.CantidadproductoDataGridViewTextBoxColumn.Name = "CantidadproductoDataGridViewTextBoxColumn"
        '
        'MarcaproductoDataGridViewTextBoxColumn
        '
        Me.MarcaproductoDataGridViewTextBoxColumn.DataPropertyName = "marcaproducto"
        Me.MarcaproductoDataGridViewTextBoxColumn.HeaderText = "marcaproducto"
        Me.MarcaproductoDataGridViewTextBoxColumn.Name = "MarcaproductoDataGridViewTextBoxColumn"
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        '
        'EstadoproductoDataGridViewCheckBoxColumn
        '
        Me.EstadoproductoDataGridViewCheckBoxColumn.DataPropertyName = "estadoproducto"
        Me.EstadoproductoDataGridViewCheckBoxColumn.HeaderText = "estadoproducto"
        Me.EstadoproductoDataGridViewCheckBoxColumn.Name = "EstadoproductoDataGridViewCheckBoxColumn"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.AutoshopDataSet_productos
        '
        'AutoshopDataSet_productos
        '
        Me.AutoshopDataSet_productos.DataSetName = "autoshopDataSet_productos"
        Me.AutoshopDataSet_productos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.AutoShop.My.Resources.Resources.background_catalogos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 753)
        Me.Controls.Add(Me.Buscar_productos)
        Me.Controls.Add(Me.Borrar_productos)
        Me.Controls.Add(Me.Actualizar_productos)
        Me.Controls.Add(Me.Insertar_productos)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.DataGridView_productos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "productos"
        Me.Text = "productos"
        CType(Me.DataGridView_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoshopDataSet_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_productos As DataGridView
    Friend WithEvents AutoshopDataSet_productos As autoshopDataSet_productos
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As autoshopDataSet_productosTableAdapters.productosTableAdapter
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoproductoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Insertar_productos As Button
    Friend WithEvents Actualizar_productos As Button
    Friend WithEvents Borrar_productos As Button
    Friend WithEvents Buscar_productos As Button
End Class
