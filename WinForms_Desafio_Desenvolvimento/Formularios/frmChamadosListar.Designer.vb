﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChamadosListar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChamadosListar))
        Me.dgvChamados = New System.Windows.Forms.DataGridView()
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        CType(Me.dgvChamados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpLayoutRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvChamados
        '
        Me.dgvChamados.AllowUserToAddRows = False
        Me.dgvChamados.AllowUserToDeleteRows = False
        Me.dgvChamados.AllowUserToResizeColumns = False
        Me.dgvChamados.AllowUserToResizeRows = False
        Me.dgvChamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpLayoutRoot.SetColumnSpan(Me.dgvChamados, 4)
        Me.dgvChamados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChamados.Location = New System.Drawing.Point(3, 43)
        Me.dgvChamados.Name = "dgvChamados"
        Me.dgvChamados.RowHeadersVisible = False
        Me.dgvChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChamados.Size = New System.Drawing.Size(778, 415)
        Me.dgvChamados.TabIndex = 0
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 4
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.dgvChamados, 0, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.btnNovo, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnAbrir, 1, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnExcluir, 2, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnRelatorio, 4, 0)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 2
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(784, 461)
        Me.tlpLayoutRoot.TabIndex = 1
        '
        'btnNovo
        '
        Me.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNovo.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.document
        Me.btnNovo.Location = New System.Drawing.Point(3, 3)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(144, 34)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAbrir.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.folder_horizontal_open
        Me.btnAbrir.Location = New System.Drawing.Point(153, 3)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(144, 34)
        Me.btnAbrir.TabIndex = 1
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExcluir.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.cross
        Me.btnExcluir.Location = New System.Drawing.Point(303, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(140, 34)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.printer
        Me.btnRelatorio.Location = New System.Drawing.Point(658, 3)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(123, 34)
        Me.btnRelatorio.TabIndex = 1
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(469, 10)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(167, 21)
        Me.cmbDepartamento.TabIndex = 8
        '
        'frmChamadosListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChamadosListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        CType(Me.dgvChamados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvChamados As DataGridView
    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents cmbDepartamento As ComboBox
End Class
