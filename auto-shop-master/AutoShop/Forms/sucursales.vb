Public Class sucursales
    Private Sub sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutoshopDataSet_sucursales.sucursales' table. You can move, or remove it, as needed.
        Me.SucursalesTableAdapter.Fill(Me.AutoshopDataSet_sucursales.sucursales)
        'TODO: This line of code loads data into the 'AutoshopDataSet1.sucursales' table. You can move, or remove it, as needed.
        Me.SucursalesTableAdapter.Fill(Me.AutoshopDataSet_sucursales.sucursales)

    End Sub

    Private Sub Agregar_sucursal_Click(sender As Object, e As EventArgs) Handles Agregar_sucursal.Click
        Me.SucursalesTableAdapter.insertar_sucursal_query(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.SucursalesTableAdapter.Fill(Me.AutoshopDataSet_sucursales.sucursales)
    End Sub

    Private Sub Actualizar_sucursal_Click(sender As Object, e As EventArgs) Handles Actualizar_sucursal.Click
        Me.SucursalesTableAdapter.actualizar_sucursal_query(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.SucursalesTableAdapter.Fill(Me.AutoshopDataSet_sucursales.sucursales)
    End Sub

    Private Sub Borrar_sucursal_Click(sender As Object, e As EventArgs) Handles Borrar_sucursal.Click
        Me.SucursalesTableAdapter.borrar_sucursal_query(TextBox1.Text)
        Me.SucursalesTableAdapter.Fill(Me.AutoshopDataSet_sucursales.sucursales)
    End Sub

    Private Sub Buscar_sucursal_Click(sender As Object, e As EventArgs) Handles Buscar_sucursal.Click
        Me.SucursalesTableAdapter.FillBy(Me.AutoshopDataSet_sucursales.sucursales, TextBox1.Text)
    End Sub
End Class