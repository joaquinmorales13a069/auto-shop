Public Class productos
    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutoshopDataSet_productos.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.AutoshopDataSet_productos.productos)

    End Sub

    Private Sub Insertar_productos_Click(sender As Object, e As EventArgs) Handles Insertar_productos.Click
        Me.ProductosTableAdapter.insertar_productos_query(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text)
        Me.ProductosTableAdapter.Fill(Me.AutoshopDataSet_productos.productos)
    End Sub

    Private Sub Actualizar_productos_Click(sender As Object, e As EventArgs) Handles Actualizar_productos.Click
        Me.ProductosTableAdapter.actualizar_productos_query(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text)
        Me.ProductosTableAdapter.Fill(Me.AutoshopDataSet_productos.productos)
    End Sub

    Private Sub Borrar_productos_Click(sender As Object, e As EventArgs) Handles Borrar_productos.Click
        Me.ProductosTableAdapter.borrar_productos_query(TextBox1.Text)
        Me.ProductosTableAdapter.Fill(Me.AutoshopDataSet_productos.productos)
    End Sub

    Private Sub Buscar_productos_Click(sender As Object, e As EventArgs) Handles Buscar_productos.Click
        Me.ProductosTableAdapter.FillBy(Me.AutoshopDataSet_productos.productos, TextBox1.Text)
    End Sub
End Class