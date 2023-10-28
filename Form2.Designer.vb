<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl_prod = New System.Windows.Forms.Label()
        Me.lbl_prixu = New System.Windows.Forms.Label()
        Me.lbl_qtn = New System.Windows.Forms.Label()
        Me.lbl_mntn = New System.Windows.Forms.Label()
        Me.lst_prod = New System.Windows.Forms.ListBox()
        Me.txt_prixu = New System.Windows.Forms.TextBox()
        Me.txt_mtn = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.btn_modif = New System.Windows.Forms.Button()
        Me.btn_calcul = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.txt_qtn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_qtn = New System.Windows.Forms.ListBox()
        Me.lst_mtn = New System.Windows.Forms.ListBox()
        Me.lst_prixu = New System.Windows.Forms.ListBox()
        Me.lst_pr = New System.Windows.Forms.ListBox()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.txt_totpu = New System.Windows.Forms.TextBox()
        Me.txt_totq = New System.Windows.Forms.TextBox()
        Me.txt_totmh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tva = New System.Windows.Forms.TextBox()
        Me.txt_r = New System.Windows.Forms.TextBox()
        Me.btn_payer = New System.Windows.Forms.Button()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_prod
        '
        Me.lbl_prod.AutoSize = True
        Me.lbl_prod.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod.Location = New System.Drawing.Point(55, 28)
        Me.lbl_prod.Name = "lbl_prod"
        Me.lbl_prod.Size = New System.Drawing.Size(76, 24)
        Me.lbl_prod.TabIndex = 0
        Me.lbl_prod.Text = "Produit"
        '
        'lbl_prixu
        '
        Me.lbl_prixu.AutoSize = True
        Me.lbl_prixu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_prixu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prixu.Location = New System.Drawing.Point(23, 77)
        Me.lbl_prixu.Name = "lbl_prixu"
        Me.lbl_prixu.Size = New System.Drawing.Size(123, 24)
        Me.lbl_prixu.TabIndex = 1
        Me.lbl_prixu.Text = "Prix Unitaire"
        '
        'lbl_qtn
        '
        Me.lbl_qtn.AutoSize = True
        Me.lbl_qtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_qtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtn.Location = New System.Drawing.Point(43, 139)
        Me.lbl_qtn.Name = "lbl_qtn"
        Me.lbl_qtn.Size = New System.Drawing.Size(88, 24)
        Me.lbl_qtn.TabIndex = 2
        Me.lbl_qtn.Text = "Quantité"
        '
        'lbl_mntn
        '
        Me.lbl_mntn.AutoSize = True
        Me.lbl_mntn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_mntn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mntn.Location = New System.Drawing.Point(28, 192)
        Me.lbl_mntn.Name = "lbl_mntn"
        Me.lbl_mntn.Size = New System.Drawing.Size(118, 24)
        Me.lbl_mntn.TabIndex = 3
        Me.lbl_mntn.Text = "Montant HT"
        '
        'lst_prod
        '
        Me.lst_prod.FormattingEnabled = True
        Me.lst_prod.Items.AddRange(New Object() {"Clavier", "Imprimante", "Ordinateur", "Souris"})
        Me.lst_prod.Location = New System.Drawing.Point(154, 29)
        Me.lst_prod.Name = "lst_prod"
        Me.lst_prod.Size = New System.Drawing.Size(100, 17)
        Me.lst_prod.TabIndex = 4
        '
        'txt_prixu
        '
        Me.txt_prixu.Location = New System.Drawing.Point(162, 82)
        Me.txt_prixu.Name = "txt_prixu"
        Me.txt_prixu.Size = New System.Drawing.Size(83, 20)
        Me.txt_prixu.TabIndex = 5
        '
        'txt_mtn
        '
        Me.txt_mtn.Location = New System.Drawing.Point(154, 197)
        Me.txt_mtn.Name = "txt_mtn"
        Me.txt_mtn.Size = New System.Drawing.Size(108, 20)
        Me.txt_mtn.TabIndex = 7
        '
        'btn_ajout
        '
        Me.btn_ajout.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_ajout.Location = New System.Drawing.Point(285, 22)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(100, 49)
        Me.btn_ajout.TabIndex = 8
        Me.btn_ajout.Text = "Ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = False
        '
        'btn_supp
        '
        Me.btn_supp.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supp.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_supp.Location = New System.Drawing.Point(285, 146)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(100, 49)
        Me.btn_supp.TabIndex = 9
        Me.btn_supp.Text = "Supprimer"
        Me.btn_supp.UseVisualStyleBackColor = False
        '
        'btn_modif
        '
        Me.btn_modif.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modif.Location = New System.Drawing.Point(285, 92)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(100, 48)
        Me.btn_modif.TabIndex = 10
        Me.btn_modif.Text = "Modifier"
        Me.btn_modif.UseVisualStyleBackColor = False
        '
        'btn_calcul
        '
        Me.btn_calcul.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_calcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcul.Location = New System.Drawing.Point(27, 289)
        Me.btn_calcul.Name = "btn_calcul"
        Me.btn_calcul.Size = New System.Drawing.Size(83, 62)
        Me.btn_calcul.TabIndex = 11
        Me.btn_calcul.Text = "Calculer"
        Me.btn_calcul.UseVisualStyleBackColor = False
        '
        'btn_quitter
        '
        Me.btn_quitter.BackColor = System.Drawing.Color.IndianRed
        Me.btn_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_quitter.Location = New System.Drawing.Point(154, 293)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(83, 55)
        Me.btn_quitter.TabIndex = 12
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = False
        '
        'txt_qtn
        '
        Me.txt_qtn.Location = New System.Drawing.Point(154, 139)
        Me.txt_qtn.Name = "txt_qtn"
        Me.txt_qtn.Size = New System.Drawing.Size(115, 20)
        Me.txt_qtn.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Prix Unitaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(598, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Quantité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(683, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Montant HT"
        '
        'lst_qtn
        '
        Me.lst_qtn.FormattingEnabled = True
        Me.lst_qtn.Location = New System.Drawing.Point(602, 61)
        Me.lst_qtn.Name = "lst_qtn"
        Me.lst_qtn.Size = New System.Drawing.Size(95, 82)
        Me.lst_qtn.TabIndex = 18
        '
        'lst_mtn
        '
        Me.lst_mtn.FormattingEnabled = True
        Me.lst_mtn.Location = New System.Drawing.Point(706, 61)
        Me.lst_mtn.Name = "lst_mtn"
        Me.lst_mtn.Size = New System.Drawing.Size(95, 82)
        Me.lst_mtn.TabIndex = 19
        '
        'lst_prixu
        '
        Me.lst_prixu.FormattingEnabled = True
        Me.lst_prixu.Location = New System.Drawing.Point(501, 61)
        Me.lst_prixu.Name = "lst_prixu"
        Me.lst_prixu.Size = New System.Drawing.Size(95, 82)
        Me.lst_prixu.TabIndex = 20
        '
        'lst_pr
        '
        Me.lst_pr.FormattingEnabled = True
        Me.lst_pr.Location = New System.Drawing.Point(400, 61)
        Me.lst_pr.Name = "lst_pr"
        Me.lst_pr.Size = New System.Drawing.Size(95, 82)
        Me.lst_pr.TabIndex = 21
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot.Location = New System.Drawing.Point(401, 220)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(56, 24)
        Me.lbl_tot.TabIndex = 22
        Me.lbl_tot.Text = "Total"
        '
        'txt_totpu
        '
        Me.txt_totpu.Location = New System.Drawing.Point(501, 220)
        Me.txt_totpu.Name = "txt_totpu"
        Me.txt_totpu.Size = New System.Drawing.Size(83, 20)
        Me.txt_totpu.TabIndex = 23
        '
        'txt_totq
        '
        Me.txt_totq.Location = New System.Drawing.Point(603, 220)
        Me.txt_totq.Name = "txt_totq"
        Me.txt_totq.Size = New System.Drawing.Size(83, 20)
        Me.txt_totq.TabIndex = 24
        '
        'txt_totmh
        '
        Me.txt_totmh.Location = New System.Drawing.Point(706, 220)
        Me.txt_totmh.Name = "txt_totmh"
        Me.txt_totmh.Size = New System.Drawing.Size(83, 20)
        Me.txt_totmh.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 24)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "TVA(20%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(396, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Remise"
        '
        'txt_tva
        '
        Me.txt_tva.Location = New System.Drawing.Point(543, 278)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.Size = New System.Drawing.Size(202, 20)
        Me.txt_tva.TabIndex = 28
        '
        'txt_r
        '
        Me.txt_r.Location = New System.Drawing.Point(543, 328)
        Me.txt_r.Name = "txt_r"
        Me.txt_r.Size = New System.Drawing.Size(202, 20)
        Me.txt_r.TabIndex = 29
        '
        'btn_payer
        '
        Me.btn_payer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_payer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payer.Location = New System.Drawing.Point(299, 272)
        Me.btn_payer.Name = "btn_payer"
        Me.btn_payer.Size = New System.Drawing.Size(65, 31)
        Me.btn_payer.TabIndex = 30
        Me.btn_payer.Text = "Payer"
        Me.btn_payer.UseVisualStyleBackColor = False
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(277, 311)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(108, 20)
        Me.txt_code.TabIndex = 31
        Me.txt_code.Text = "4500DT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Solde Bancaire"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.btn_payer)
        Me.Controls.Add(Me.txt_r)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_totmh)
        Me.Controls.Add(Me.txt_totq)
        Me.Controls.Add(Me.txt_totpu)
        Me.Controls.Add(Me.lbl_tot)
        Me.Controls.Add(Me.lst_pr)
        Me.Controls.Add(Me.lst_prixu)
        Me.Controls.Add(Me.lst_mtn)
        Me.Controls.Add(Me.lst_qtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_qtn)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_calcul)
        Me.Controls.Add(Me.btn_modif)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.txt_mtn)
        Me.Controls.Add(Me.txt_prixu)
        Me.Controls.Add(Me.lst_prod)
        Me.Controls.Add(Me.lbl_mntn)
        Me.Controls.Add(Me.lbl_qtn)
        Me.Controls.Add(Me.lbl_prixu)
        Me.Controls.Add(Me.lbl_prod)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_prod As Label
    Friend WithEvents lbl_prixu As Label
    Friend WithEvents lbl_qtn As Label
    Friend WithEvents lbl_mntn As Label
    Friend WithEvents lst_prod As ListBox
    Friend WithEvents txt_prixu As TextBox
    Friend WithEvents txt_mtn As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents btn_modif As Button
    Friend WithEvents btn_calcul As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents txt_qtn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lst_qtn As ListBox
    Friend WithEvents lst_mtn As ListBox
    Friend WithEvents lst_prixu As ListBox
    Friend WithEvents lst_pr As ListBox
    Friend WithEvents lbl_tot As Label
    Friend WithEvents txt_totpu As TextBox
    Friend WithEvents txt_totq As TextBox
    Friend WithEvents txt_totmh As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tva As TextBox
    Friend WithEvents txt_r As TextBox
    Friend WithEvents btn_payer As Button
    Friend WithEvents txt_code As TextBox
    Friend WithEvents Label7 As Label
End Class
