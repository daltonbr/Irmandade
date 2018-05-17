namespace Irmandade.View
{
    partial class IndividualForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CPFlabel = new System.Windows.Forms.Label();
            this.RGTextBox = new System.Windows.Forms.TextBox();
            this.RGlabel = new System.Windows.Forms.Label();
            this.emissorTextBox = new System.Windows.Forms.TextBox();
            this.RGEmisssorLabel = new System.Windows.Forms.Label();
            this.telefoneFixoLabel = new System.Windows.Forms.Label();
            this.telefoneCelularLabel = new System.Windows.Forms.Label();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.observacoesLabel = new System.Windows.Forms.Label();
            this.diasCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.diasDisponiveisLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.servicosListBox = new System.Windows.Forms.ListBox();
            this.addServicoButton = new System.Windows.Forms.Button();
            this.removeServicoButton = new System.Windows.Forms.Button();
            this.servicoGroupBox = new System.Windows.Forms.GroupBox();
            this.CPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTipCPF = new System.Windows.Forms.ToolTip(this.components);
            this.telefoneFixoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneCelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.servicoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 44);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(6, 505);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 60);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "&Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(256, 505);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 60);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "&Fechar";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(132, 505);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 60);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "&Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(6, 58);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(368, 24);
            this.nomeTextBox.TabIndex = 4;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(6, 99);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(368, 24);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(4, 84);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // CPFlabel
            // 
            this.CPFlabel.AutoSize = true;
            this.CPFlabel.Location = new System.Drawing.Point(6, 4);
            this.CPFlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPFlabel.Name = "CPFlabel";
            this.CPFlabel.Size = new System.Drawing.Size(27, 13);
            this.CPFlabel.TabIndex = 7;
            this.CPFlabel.Text = "CPF";
            // 
            // RGTextBox
            // 
            this.RGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGTextBox.Location = new System.Drawing.Point(194, 17);
            this.RGTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RGTextBox.Name = "RGTextBox";
            this.RGTextBox.Size = new System.Drawing.Size(112, 24);
            this.RGTextBox.TabIndex = 2;
            this.RGTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // RGlabel
            // 
            this.RGlabel.AutoSize = true;
            this.RGlabel.Location = new System.Drawing.Point(190, 4);
            this.RGlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RGlabel.Name = "RGlabel";
            this.RGlabel.Size = new System.Drawing.Size(23, 13);
            this.RGlabel.TabIndex = 9;
            this.RGlabel.Text = "RG";
            // 
            // emissorTextBox
            // 
            this.emissorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emissorTextBox.Location = new System.Drawing.Point(308, 17);
            this.emissorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emissorTextBox.Name = "emissorTextBox";
            this.emissorTextBox.Size = new System.Drawing.Size(67, 24);
            this.emissorTextBox.TabIndex = 3;
            this.emissorTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // RGEmisssorLabel
            // 
            this.RGEmisssorLabel.AutoSize = true;
            this.RGEmisssorLabel.Location = new System.Drawing.Point(305, 4);
            this.RGEmisssorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RGEmisssorLabel.Name = "RGEmisssorLabel";
            this.RGEmisssorLabel.Size = new System.Drawing.Size(43, 13);
            this.RGEmisssorLabel.TabIndex = 11;
            this.RGEmisssorLabel.Text = "Emissor";
            // 
            // telefoneFixoLabel
            // 
            this.telefoneFixoLabel.AutoSize = true;
            this.telefoneFixoLabel.Location = new System.Drawing.Point(5, 126);
            this.telefoneFixoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefoneFixoLabel.Name = "telefoneFixoLabel";
            this.telefoneFixoLabel.Size = new System.Drawing.Size(71, 13);
            this.telefoneFixoLabel.TabIndex = 13;
            this.telefoneFixoLabel.Text = "Telefone Fixo";
            // 
            // telefoneCelularLabel
            // 
            this.telefoneCelularLabel.AutoSize = true;
            this.telefoneCelularLabel.Location = new System.Drawing.Point(192, 126);
            this.telefoneCelularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefoneCelularLabel.Name = "telefoneCelularLabel";
            this.telefoneCelularLabel.Size = new System.Drawing.Size(39, 13);
            this.telefoneCelularLabel.TabIndex = 15;
            this.telefoneCelularLabel.Text = "Celular";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.AcceptsReturn = true;
            this.observacoesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.observacoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesTextBox.Location = new System.Drawing.Point(7, 433);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacoesTextBox.Size = new System.Drawing.Size(368, 68);
            this.observacoesTextBox.TabIndex = 14;
            this.observacoesTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // observacoesLabel
            // 
            this.observacoesLabel.AutoSize = true;
            this.observacoesLabel.Location = new System.Drawing.Point(5, 419);
            this.observacoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.observacoesLabel.Name = "observacoesLabel";
            this.observacoesLabel.Size = new System.Drawing.Size(70, 13);
            this.observacoesLabel.TabIndex = 17;
            this.observacoesLabel.Text = "Observações";
            // 
            // diasCheckedListBox
            // 
            this.diasCheckedListBox.CheckOnClick = true;
            this.diasCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasCheckedListBox.FormattingEnabled = true;
            this.diasCheckedListBox.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.diasCheckedListBox.Location = new System.Drawing.Point(6, 180);
            this.diasCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.diasCheckedListBox.Name = "diasCheckedListBox";
            this.diasCheckedListBox.Size = new System.Drawing.Size(115, 99);
            this.diasCheckedListBox.TabIndex = 8;
            this.diasCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.diasCheckedListBox_SelectedIndexChanged);
            // 
            // diasDisponiveisLabel
            // 
            this.diasDisponiveisLabel.AutoSize = true;
            this.diasDisponiveisLabel.Location = new System.Drawing.Point(4, 165);
            this.diasDisponiveisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diasDisponiveisLabel.Name = "diasDisponiveisLabel";
            this.diasDisponiveisLabel.Size = new System.Drawing.Size(87, 13);
            this.diasDisponiveisLabel.TabIndex = 20;
            this.diasDisponiveisLabel.Text = "Dias Disponíveis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Início das Atividades";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 304);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(114, 24);
            this.dateTimePicker.TabIndex = 9;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(8, 347);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(366, 68);
            this.enderecoTextBox.TabIndex = 13;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(6, 332);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(53, 13);
            this.enderecoLabel.TabIndex = 23;
            this.enderecoLabel.Text = "Endereço";
            // 
            // servicosListBox
            // 
            this.servicosListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.servicosListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicosListBox.FormattingEnabled = true;
            this.servicosListBox.ItemHeight = 17;
            this.servicosListBox.Location = new System.Drawing.Point(9, 16);
            this.servicosListBox.Margin = new System.Windows.Forms.Padding(2);
            this.servicosListBox.Name = "servicosListBox";
            this.servicosListBox.Size = new System.Drawing.Size(185, 140);
            this.servicosListBox.TabIndex = 10;
            this.servicosListBox.UseTabStops = false;
            // 
            // addServicoButton
            // 
            this.addServicoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServicoButton.Location = new System.Drawing.Point(197, 31);
            this.addServicoButton.Name = "addServicoButton";
            this.addServicoButton.Size = new System.Drawing.Size(45, 47);
            this.addServicoButton.TabIndex = 11;
            this.addServicoButton.Text = "+";
            this.addServicoButton.UseVisualStyleBackColor = true;
            this.addServicoButton.Click += new System.EventHandler(this.addServicoButton_Click);
            // 
            // removeServicoButton
            // 
            this.removeServicoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeServicoButton.Location = new System.Drawing.Point(197, 83);
            this.removeServicoButton.Name = "removeServicoButton";
            this.removeServicoButton.Size = new System.Drawing.Size(45, 47);
            this.removeServicoButton.TabIndex = 12;
            this.removeServicoButton.Text = "-";
            this.removeServicoButton.UseVisualStyleBackColor = true;
            this.removeServicoButton.UseWaitCursor = true;
            this.removeServicoButton.Click += new System.EventHandler(this.removeServicoButton_Click);
            // 
            // servicoGroupBox
            // 
            this.servicoGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.servicoGroupBox.Controls.Add(this.servicosListBox);
            this.servicoGroupBox.Controls.Add(this.removeServicoButton);
            this.servicoGroupBox.Controls.Add(this.addServicoButton);
            this.servicoGroupBox.Location = new System.Drawing.Point(124, 169);
            this.servicoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.servicoGroupBox.Name = "servicoGroupBox";
            this.servicoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.servicoGroupBox.Size = new System.Drawing.Size(248, 166);
            this.servicoGroupBox.TabIndex = 29;
            this.servicoGroupBox.TabStop = false;
            this.servicoGroupBox.Text = "Serviços";
            // 
            // CPFMaskedTextBox
            // 
            this.CPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFMaskedTextBox.Location = new System.Drawing.Point(6, 17);
            this.CPFMaskedTextBox.Mask = "000.000.000-00";
            this.CPFMaskedTextBox.Name = "CPFMaskedTextBox";
            this.CPFMaskedTextBox.Size = new System.Drawing.Size(179, 24);
            this.CPFMaskedTextBox.TabIndex = 1;
            this.CPFMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPFMaskedTextBox_MaskInputRejected);
            // 
            // telefoneFixoMaskedTextBox
            // 
            this.telefoneFixoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneFixoMaskedTextBox.Location = new System.Drawing.Point(6, 141);
            this.telefoneFixoMaskedTextBox.Mask = "(99) 0000-0000";
            this.telefoneFixoMaskedTextBox.Name = "telefoneFixoMaskedTextBox";
            this.telefoneFixoMaskedTextBox.Size = new System.Drawing.Size(184, 24);
            this.telefoneFixoMaskedTextBox.TabIndex = 6;
            this.telefoneFixoMaskedTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // telefoneCelularMaskedTextBox
            // 
            this.telefoneCelularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneCelularMaskedTextBox.Location = new System.Drawing.Point(195, 141);
            this.telefoneCelularMaskedTextBox.Mask = "(99) 00000-0000";
            this.telefoneCelularMaskedTextBox.Name = "telefoneCelularMaskedTextBox";
            this.telefoneCelularMaskedTextBox.Size = new System.Drawing.Size(179, 24);
            this.telefoneCelularMaskedTextBox.TabIndex = 7;
            this.telefoneCelularMaskedTextBox.TextChanged += new System.EventHandler(this.SetHasEditionToTrue);
            // 
            // IndividualForm
            // 
            this.AccessibleName = "Ficha do Voluntário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(380, 571);
            this.Controls.Add(this.telefoneCelularMaskedTextBox);
            this.Controls.Add(this.telefoneFixoMaskedTextBox);
            this.Controls.Add(this.CPFMaskedTextBox);
            this.Controls.Add(this.servicoGroupBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diasDisponiveisLabel);
            this.Controls.Add(this.diasCheckedListBox);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.observacoesLabel);
            this.Controls.Add(this.telefoneCelularLabel);
            this.Controls.Add(this.telefoneFixoLabel);
            this.Controls.Add(this.emissorTextBox);
            this.Controls.Add(this.RGEmisssorLabel);
            this.Controls.Add(this.RGTextBox);
            this.Controls.Add(this.RGlabel);
            this.Controls.Add(this.CPFlabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 610);
            this.MinimumSize = new System.Drawing.Size(396, 610);
            this.Name = "IndividualForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha do Voluntário";
            this.Load += new System.EventHandler(this.IndividualForm_Load);
            this.servicoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label CPFlabel;
        private System.Windows.Forms.TextBox RGTextBox;
        private System.Windows.Forms.Label RGlabel;
        private System.Windows.Forms.TextBox emissorTextBox;
        private System.Windows.Forms.Label RGEmisssorLabel;
        private System.Windows.Forms.Label telefoneFixoLabel;
        private System.Windows.Forms.Label telefoneCelularLabel;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Label observacoesLabel;
        private System.Windows.Forms.CheckedListBox diasCheckedListBox;
        private System.Windows.Forms.Label diasDisponiveisLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.ListBox servicosListBox;
        private System.Windows.Forms.Button addServicoButton;
        private System.Windows.Forms.Button removeServicoButton;
        private System.Windows.Forms.GroupBox servicoGroupBox;
        private System.Windows.Forms.MaskedTextBox CPFMaskedTextBox;
        private System.Windows.Forms.ToolTip toolTipCPF;
        private System.Windows.Forms.MaskedTextBox telefoneFixoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneCelularMaskedTextBox;
    }
}