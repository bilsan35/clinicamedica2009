<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvenios))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnNovo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRemover = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.btnFechar = New System.Windows.Forms.Button
        Me.txtPesquisar = New System.Windows.Forms.ToolStripTextBox
        Me.btnPesquisar = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = CType(resources.GetObject("ToolStrip2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip2.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.ToolStripSeparator1, Me.btnEditar, Me.ToolStripSeparator2, Me.btnRemover, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.txtPesquisar, Me.btnPesquisar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(424, 54)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(40, 51)
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(43, 51)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnRemover
        '
        Me.btnRemover.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnRemover.Image = CType(resources.GetObject("btnRemover.Image"), System.Drawing.Image)
        Me.btnRemover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(61, 51)
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 51)
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(12, 66)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(400, 263)
        Me.Grid.TabIndex = 11
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Location = New System.Drawing.Point(337, 335)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(100, 54)
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(26, 51)
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmConvenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 364)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.btnFechar)
        Me.Name = "frmConvenios"
        Me.Text = "Convênios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRemover As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.ToolStripButton
End Class
