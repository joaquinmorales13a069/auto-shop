
Public Class clientes
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview_clientes.CellContentClick

    End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutoshopDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.AutoshopDataSet.clientes)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Me.ClientesTableAdapter.actualizarquery(TextBox01.Text, TextBox02.Text, TextBox03.Text, TextBox04.Text, TextBox05.Text)
        Me.ClientesTableAdapter.Fill(AutoshopDataSet.clientes)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles buscar_button.Click
        Me.ClientesTableAdapter.FillBy(Me.AutoshopDataSet.clientes, TextBox01.Text)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Insertar_button.Click
        Me.ClientesTableAdapter.Insertar(TextBox01.Text, TextBox02.Text, TextBox03.Text, TextBox04.Text, TextBox05.Text)
        Me.ClientesTableAdapter.Fill(Me.AutoshopDataSet.clientes)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox04_TextChanged(sender As Object, e As EventArgs) Handles TextBox04.TextChanged

    End Sub

    Private Sub eliminar_button_Click(sender As Object, e As EventArgs) Handles eliminar_button.Click
        Me.ClientesTableAdapter.eliminarquery(TextBox01.Text)
        Me.ClientesTableAdapter.Fill(Me.AutoshopDataSet.clientes)
    End Sub
End Class