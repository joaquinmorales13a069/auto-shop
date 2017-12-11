Public Class proveedores
    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutoshopDataSet_proveedores.proveedores' table. You can move, or remove it, as needed.
        Me.ProveedoresTableAdapter.Fill(Me.AutoshopDataSet_proveedores.proveedores)

    End Sub

    Private Sub Insertar_button_Click(sender As Object, e As EventArgs) Handles Insertar_button.Click
        Me.ProveedoresTableAdapter.insertarquery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.ProveedoresTableAdapter.Fill(Me.AutoshopDataSet_proveedores.proveedores)
    End Sub

    Private Sub Actualizar_button_Click(sender As Object, e As EventArgs) Handles Actualizar_button.Click
        Me.ProveedoresTableAdapter.actualizar_proveedores_query(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.ProveedoresTableAdapter.Fill(Me.AutoshopDataSet_proveedores.proveedores)
    End Sub

    Private Sub Borrar_button_Click(sender As Object, e As EventArgs) Handles Borrar_button.Click
        Me.ProveedoresTableAdapter.borrar_proveedores_query(TextBox1.Text)
        Me.ProveedoresTableAdapter.Fill(Me.AutoshopDataSet_proveedores.proveedores)
    End Sub

    Private Sub Buscar_button_Click(sender As Object, e As EventArgs) Handles Buscar_button.Click
        Me.ProveedoresTableAdapter.FillBy(Me.AutoshopDataSet_proveedores.proveedores, TextBox1.Text)
    End Sub
End Class