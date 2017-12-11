<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sucursales
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
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Agregar_sucursal = New System.Windows.Forms.Button()
        Me.Actualizar_sucursal = New System.Windows.Forms.Button()
        Me.Buscar_sucursal = New System.Windows.Forms.Button()
        Me.Borrar_sucursal = New System.Windows.Forms.Button()
        Me.DataGridView_sucurales = New System.Windows.Forms.DataGridView()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonosucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadosucursalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SucursalesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoshopDataSet_sucursales = New AutoShop.autoshopDataSet_sucursales()
        Me.SucursalesTableAdapter = New AutoShop.autoshopDataSet_sucursalesTableAdapters.sucursalesTableAdapter()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_sucurales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoshopDataSet_sucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "sucursales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID de la Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de la Sucursal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(884, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(902, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 50)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(247, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(339, 101)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(247, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(339, 156)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(986, 50)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(514, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(986, 96)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(55, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Agregar_sucursal
        '
        Me.Agregar_sucursal.Location = New System.Drawing.Point(320, 218)
        Me.Agregar_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.Agregar_sucursal.Name = "Agregar_sucursal"
        Me.Agregar_sucursal.Size = New System.Drawing.Size(238, 28)
        Me.Agregar_sucursal.TabIndex = 11
        Me.Agregar_sucursal.Text = "Agregar"
        Me.Agregar_sucursal.UseVisualStyleBackColor = True
        '
        'Actualizar_sucursal
        '
        Me.Actualizar_sucursal.Location = New System.Drawing.Point(567, 218)
        Me.Actualizar_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.Actualizar_sucursal.Name = "Actualizar_sucursal"
        Me.Actualizar_sucursal.Size = New System.Drawing.Size(238, 28)
        Me.Actualizar_sucursal.TabIndex = 12
        Me.Actualizar_sucursal.Text = "Actualizar"
        Me.Actualizar_sucursal.UseVisualStyleBackColor = True
        '
        'Buscar_sucursal
        '
        Me.Buscar_sucursal.Location = New System.Drawing.Point(1062, 218)
        Me.Buscar_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.Buscar_sucursal.Name = "Buscar_sucursal"
        Me.Buscar_sucursal.Size = New System.Drawing.Size(238, 28)
        Me.Buscar_sucursal.TabIndex = 14
        Me.Buscar_sucursal.Text = "Buscar"
        Me.Buscar_sucursal.UseVisualStyleBackColor = True
        '
        'Borrar_sucursal
        '
        Me.Borrar_sucursal.Location = New System.Drawing.Point(814, 218)
        Me.Borrar_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.Borrar_sucursal.Name = "Borrar_sucursal"
        Me.Borrar_sucursal.Size = New System.Drawing.Size(238, 28)
        Me.Borrar_sucursal.TabIndex = 13
        Me.Borrar_sucursal.Text = "Borrar"
        Me.Borrar_sucursal.UseVisualStyleBackColor = True
        '
        'DataGridView_sucurales
        '
        Me.DataGridView_sucurales.AutoGenerateColumns = False
        Me.DataGridView_sucurales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_sucurales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_sucurales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_sucurales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsucursalDataGridViewTextBoxColumn, Me.NombresucursalDataGridViewTextBoxColumn, Me.TelefonosucursalDataGridViewTextBoxColumn, Me.DireccionsucursalDataGridViewTextBoxColumn, Me.EstadosucursalDataGridViewCheckBoxColumn})
        Me.DataGridView_sucurales.DataSource = Me.SucursalesBindingSource1
        Me.DataGridView_sucurales.Location = New System.Drawing.Point(152, 284)
        Me.DataGridView_sucurales.Name = "DataGridView_sucurales"
        Me.DataGridView_sucurales.Size = New System.Drawing.Size(1348, 244)
        Me.DataGridView_sucurales.TabIndex = 15
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "idsucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "idsucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        '
        'NombresucursalDataGridViewTextBoxColumn
        '
        Me.NombresucursalDataGridViewTextBoxColumn.DataPropertyName = "nombresucursal"
        Me.NombresucursalDataGridViewTextBoxColumn.HeaderText = "nombresucursal"
        Me.NombresucursalDataGridViewTextBoxColumn.Name = "NombresucursalDataGridViewTextBoxColumn"
        '
        'TelefonosucursalDataGridViewTextBoxColumn
        '
        Me.TelefonosucursalDataGridViewTextBoxColumn.DataPropertyName = "telefonosucursal"
        Me.TelefonosucursalDataGridViewTextBoxColumn.HeaderText = "telefonosucursal"
        Me.TelefonosucursalDataGridViewTextBoxColumn.Name = "TelefonosucursalDataGridViewTextBoxColumn"
        '
        'DireccionsucursalDataGridViewTextBoxColumn
        '
        Me.DireccionsucursalDataGridViewTextBoxColumn.DataPropertyName = "direccionsucursal"
        Me.DireccionsucursalDataGridViewTextBoxColumn.HeaderText = "direccionsucursal"
        Me.DireccionsucursalDataGridViewTextBoxColumn.Name = "DireccionsucursalDataGridViewTextBoxColumn"
        '
        'EstadosucursalDataGridViewCheckBoxColumn
        '
        Me.EstadosucursalDataGridViewCheckBoxColumn.DataPropertyName = "estadosucursal"
        Me.EstadosucursalDataGridViewCheckBoxColumn.HeaderText = "estadosucursal"
        Me.EstadosucursalDataGridViewCheckBoxColumn.Name = "EstadosucursalDataGridViewCheckBoxColumn"
        '
        'SucursalesBindingSource1
        '
        Me.SucursalesBindingSource1.DataMember = "sucursales"
        Me.SucursalesBindingSource1.DataSource = Me.AutoshopDataSet_sucursales
        '
        'AutoshopDataSet_sucursales
        '
        Me.AutoshopDataSet_sucursales.DataSetName = "autoshopDataSet_sucursales"
        Me.AutoshopDataSet_sucursales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'sucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.AutoShop.My.Resources.Resources.background_catalogos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1605, 752)
        Me.Controls.Add(Me.DataGridView_sucurales)
        Me.Controls.Add(Me.Buscar_sucursal)
        Me.Controls.Add(Me.Borrar_sucursal)
        Me.Controls.Add(Me.Actualizar_sucursal)
        Me.Controls.Add(Me.Agregar_sucursal)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "sucursales"
        Me.Text = "sucursales"
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_sucurales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoshopDataSet_sucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SucursalesBindingSource As BindingSource
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
    Friend WithEvents Agregar_sucursal As Button
    Friend WithEvents Actualizar_sucursal As Button
    Friend WithEvents Buscar_sucursal As Button
    Friend WithEvents Borrar_sucursal As Button
    Friend WithEvents DataGridView_sucurales As DataGridView
    Friend WithEvents AutoshopDataSet_sucursales As autoshopDataSet_sucursales
    Friend WithEvents SucursalesBindingSource1 As BindingSource
    Friend WithEvents SucursalesTableAdapter As autoshopDataSet_sucursalesTableAdapters.sucursalesTableAdapter
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonosucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadosucursalDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
