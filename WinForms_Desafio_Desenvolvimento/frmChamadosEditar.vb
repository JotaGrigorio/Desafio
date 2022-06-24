Public Class frmChamadosEditar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dtDepartamentos As DataTable = Dados.ListarDepartamentos()

        Me.cmbDepartamento.DisplayMember = "Descricao"
        Me.cmbDepartamento.ValueMember = "ID"
        Me.cmbDepartamento.DataSource = dtDepartamentos

    End Sub

    Public Sub AbrirChamado(ByVal idChamado As Integer)

        Dim drChamado As DataRow = Dados.ObterChamado(idChamado)

        Me.txtID.Text = CInt(drChamado("ID")).ToString()
        Me.txtAssunto.Text = CStr(drChamado("Assunto"))
        Me.txtSolicitante.Text = CStr(drChamado("Solicitante"))

        Me.cmbDepartamento.SelectedValue = CInt(drChamado("Departamento"))

        Dim strDataAbertura As String = CStr(drChamado("DataAbertura"))
        Me.dtpDataAbertura.Value = DateTime.Parse(strDataAbertura)

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

        Dim Assunto As String = Me.txtAssunto.Text
        Dim Solicitante As String = Me.txtSolicitante.Text
        Dim Departamento As Integer = CInt(Me.cmbDepartamento.SelectedValue)
        Dim DataAbertura As DateTime = Me.dtpDataAbertura.Value

        If String.IsNullOrEmpty(Assunto) Or String.IsNullOrEmpty(Solicitante) Then

            MessageBox.Show(Me, "Todos os campos devem ser preenchidos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        If Assunto.Length > 50 Then

            MessageBox.Show(Me, "Tamanho máximo permitido do campo Assunto é de 50 caracteres", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        If DataAbertura < DateTime.Today Then

            MessageBox.Show(Me, "Não é permitido abrir chamado com data retroativa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        Dim sucesso As Boolean = Dados.GravarChamado(ID, Assunto, Solicitante, Departamento, DataAbertura)

        If Not sucesso Then

            MessageBox.Show(Me, "Falha ao gravar o chamado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel

        Else

            MessageBox.Show(Me, "Chamado gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK

        End If

        Me.Close()

    End Sub

End Class