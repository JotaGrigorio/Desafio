Public Class frmDepartamentosEditar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dtDepartamentos As DataTable = Dados.ListarDepartamentos()

    End Sub

    Public Sub AbrirDepartamento(ByVal idDepartamento As Integer)

        Dim drDepartamento As DataRow = Dados.ObterDepartamento(idDepartamento)

        Me.txtID.Text = CInt(drDepartamento("ID")).ToString()
        Me.txtDescricao.Text = CStr(drDepartamento("Descricao"))

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim ID As Integer = 0

        If String.IsNullOrEmpty(Me.txtID.Text) Then
            ID = 0
        Else
            ID = Integer.Parse(Me.txtID.Text)
        End If

        Dim Descricao As String = Me.txtDescricao.Text

        If String.IsNullOrEmpty(Descricao) Then

            MessageBox.Show(Me, "O campo descrição deve ser preenchido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        If Descricao.Length > 50 Then

            MessageBox.Show(Me, "Tamanho máximo permitido do campo Descrição é de 50 caracteres", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        Dim sucesso As Boolean = Dados.GravarDepartamento(ID, Descricao)

        If Not sucesso Then

            MessageBox.Show(Me, "Falha ao gravar o departamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel

        Else

            MessageBox.Show(Me, "Departamento gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK

        End If

        Me.Close()

    End Sub
End Class