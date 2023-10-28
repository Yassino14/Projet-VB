<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annul = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbl_nom.Location = New System.Drawing.Point(29, 51)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(299, 39)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "Nom D'utilisateur"
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mdp.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbl_mdp.Location = New System.Drawing.Point(77, 116)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(220, 37)
        Me.lbl_mdp.TabIndex = 1
        Me.lbl_mdp.Text = "Mot de passe"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(358, 51)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(214, 20)
        Me.txt_nom.TabIndex = 2
        '
        'txt_mdp
        '
        Me.txt_mdp.Location = New System.Drawing.Point(358, 131)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.Size = New System.Drawing.Size(214, 20)
        Me.txt_mdp.TabIndex = 3
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(269, 190)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(125, 54)
        Me.btn_valider.TabIndex = 4
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annul
        '
        Me.btn_annul.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annul.Location = New System.Drawing.Point(425, 190)
        Me.btn_annul.Name = "btn_annul"
        Me.btn_annul.Size = New System.Drawing.Size(127, 54)
        Me.btn_annul.TabIndex = 5
        Me.btn_annul.Text = "Annuler"
        Me.btn_annul.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annul)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.txt_mdp)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.lbl_nom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_mdp As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents btn_annul As Button
End Class
