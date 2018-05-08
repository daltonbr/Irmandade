namespace Irmandade
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CPFTextBox = new System.Windows.Forms.TextBox();
            this.CPFlabel = new System.Windows.Forms.Label();
            this.RGTextBox = new System.Windows.Forms.TextBox();
            this.RGlabel = new System.Windows.Forms.Label();
            this.emissorTextBox = new System.Windows.Forms.TextBox();
            this.RGEmisssorLabel = new System.Windows.Forms.Label();
            this.telefoneFixoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneFixoLabel = new System.Windows.Forms.Label();
            this.telefoneCelularTextBox = new System.Windows.Forms.TextBox();
            this.telefoneCelularLabel = new System.Windows.Forms.Label();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.observacoesLabel = new System.Windows.Forms.Label();
            this.diasCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.diasDisponiveisLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.servicosLabel = new System.Windows.Forms.Label();
            this.servicosListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 26);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(35, 531);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 60);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(304, 531);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "S&air";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(159, 531);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 60);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "&Editar";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(34, 40);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(390, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(34, 82);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(390, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(32, 68);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.Location = new System.Drawing.Point(241, 352);
            this.CPFTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(183, 20);
            this.CPFTextBox.TabIndex = 8;
            // 
            // CPFlabel
            // 
            this.CPFlabel.AutoSize = true;
            this.CPFlabel.Location = new System.Drawing.Point(239, 338);
            this.CPFlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPFlabel.Name = "CPFlabel";
            this.CPFlabel.Size = new System.Drawing.Size(27, 13);
            this.CPFlabel.TabIndex = 7;
            this.CPFlabel.Text = "CPF";
            // 
            // RGTextBox
            // 
            this.RGTextBox.Location = new System.Drawing.Point(242, 400);
            this.RGTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RGTextBox.Name = "RGTextBox";
            this.RGTextBox.Size = new System.Drawing.Size(112, 20);
            this.RGTextBox.TabIndex = 10;
            // 
            // RGlabel
            // 
            this.RGlabel.AutoSize = true;
            this.RGlabel.Location = new System.Drawing.Point(239, 386);
            this.RGlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RGlabel.Name = "RGlabel";
            this.RGlabel.Size = new System.Drawing.Size(23, 13);
            this.RGlabel.TabIndex = 9;
            this.RGlabel.Text = "RG";
            this.RGlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // emissorTextBox
            // 
            this.emissorTextBox.Location = new System.Drawing.Point(357, 400);
            this.emissorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emissorTextBox.Name = "emissorTextBox";
            this.emissorTextBox.Size = new System.Drawing.Size(67, 20);
            this.emissorTextBox.TabIndex = 12;
            // 
            // RGEmisssorLabel
            // 
            this.RGEmisssorLabel.AutoSize = true;
            this.RGEmisssorLabel.Location = new System.Drawing.Point(354, 386);
            this.RGEmisssorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RGEmisssorLabel.Name = "RGEmisssorLabel";
            this.RGEmisssorLabel.Size = new System.Drawing.Size(43, 13);
            this.RGEmisssorLabel.TabIndex = 11;
            this.RGEmisssorLabel.Text = "Emissor";
            // 
            // telefoneFixoTextBox
            // 
            this.telefoneFixoTextBox.Location = new System.Drawing.Point(34, 133);
            this.telefoneFixoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefoneFixoTextBox.Name = "telefoneFixoTextBox";
            this.telefoneFixoTextBox.Size = new System.Drawing.Size(192, 20);
            this.telefoneFixoTextBox.TabIndex = 14;
            // 
            // telefoneFixoLabel
            // 
            this.telefoneFixoLabel.AutoSize = true;
            this.telefoneFixoLabel.Location = new System.Drawing.Point(32, 119);
            this.telefoneFixoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefoneFixoLabel.Name = "telefoneFixoLabel";
            this.telefoneFixoLabel.Size = new System.Drawing.Size(71, 13);
            this.telefoneFixoLabel.TabIndex = 13;
            this.telefoneFixoLabel.Text = "Telefone Fixo";
            // 
            // telefoneCelularTextBox
            // 
            this.telefoneCelularTextBox.Location = new System.Drawing.Point(234, 133);
            this.telefoneCelularTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefoneCelularTextBox.Name = "telefoneCelularTextBox";
            this.telefoneCelularTextBox.Size = new System.Drawing.Size(190, 20);
            this.telefoneCelularTextBox.TabIndex = 16;
            // 
            // telefoneCelularLabel
            // 
            this.telefoneCelularLabel.AutoSize = true;
            this.telefoneCelularLabel.Location = new System.Drawing.Point(229, 118);
            this.telefoneCelularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefoneCelularLabel.Name = "telefoneCelularLabel";
            this.telefoneCelularLabel.Size = new System.Drawing.Size(39, 13);
            this.telefoneCelularLabel.TabIndex = 15;
            this.telefoneCelularLabel.Text = "Celular";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.AcceptsReturn = true;
            this.observacoesTextBox.AcceptsTab = true;
            this.observacoesTextBox.Location = new System.Drawing.Point(34, 449);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacoesTextBox.Size = new System.Drawing.Size(390, 68);
            this.observacoesTextBox.TabIndex = 18;
            // 
            // observacoesLabel
            // 
            this.observacoesLabel.AutoSize = true;
            this.observacoesLabel.Location = new System.Drawing.Point(32, 434);
            this.observacoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.observacoesLabel.Name = "observacoesLabel";
            this.observacoesLabel.Size = new System.Drawing.Size(70, 13);
            this.observacoesLabel.TabIndex = 17;
            this.observacoesLabel.Text = "Observações";
            // 
            // diasCheckedListBox
            // 
            this.diasCheckedListBox.CheckOnClick = true;
            this.diasCheckedListBox.FormattingEnabled = true;
            this.diasCheckedListBox.Location = new System.Drawing.Point(292, 187);
            this.diasCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diasCheckedListBox.Name = "diasCheckedListBox";
            this.diasCheckedListBox.Size = new System.Drawing.Size(132, 79);
            this.diasCheckedListBox.TabIndex = 19;
            // 
            // diasDisponiveisLabel
            // 
            this.diasDisponiveisLabel.AutoSize = true;
            this.diasDisponiveisLabel.Location = new System.Drawing.Point(289, 172);
            this.diasDisponiveisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diasDisponiveisLabel.Name = "diasDisponiveisLabel";
            this.diasDisponiveisLabel.Size = new System.Drawing.Size(87, 13);
            this.diasDisponiveisLabel.TabIndex = 20;
            this.diasDisponiveisLabel.Text = "Dias Disponíveis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Início das Atividades";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(278, 288);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(35, 352);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 68);
            this.enderecoTextBox.TabIndex = 24;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(32, 337);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(53, 13);
            this.enderecoLabel.TabIndex = 23;
            this.enderecoLabel.Text = "Endereço";
            // 
            // servicosLabel
            // 
            this.servicosLabel.AutoSize = true;
            this.servicosLabel.Location = new System.Drawing.Point(31, 173);
            this.servicosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicosLabel.Name = "servicosLabel";
            this.servicosLabel.Size = new System.Drawing.Size(48, 13);
            this.servicosLabel.TabIndex = 25;
            this.servicosLabel.Text = "Serviços";
            // 
            // servicosListBox
            // 
            this.servicosListBox.FormattingEnabled = true;
            this.servicosListBox.Location = new System.Drawing.Point(34, 187);
            this.servicosListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicosListBox.Name = "servicosListBox";
            this.servicosListBox.Size = new System.Drawing.Size(201, 108);
            this.servicosListBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IndividualForm
            // 
            this.AccessibleName = "Ficha do Voluntário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(474, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.servicosListBox);
            this.Controls.Add(this.servicosLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diasDisponiveisLabel);
            this.Controls.Add(this.diasCheckedListBox);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.observacoesLabel);
            this.Controls.Add(this.telefoneCelularTextBox);
            this.Controls.Add(this.telefoneCelularLabel);
            this.Controls.Add(this.telefoneFixoTextBox);
            this.Controls.Add(this.telefoneFixoLabel);
            this.Controls.Add(this.emissorTextBox);
            this.Controls.Add(this.RGEmisssorLabel);
            this.Controls.Add(this.RGTextBox);
            this.Controls.Add(this.RGlabel);
            this.Controls.Add(this.CPFTextBox);
            this.Controls.Add(this.CPFlabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 650);
            this.MinimumSize = new System.Drawing.Size(490, 650);
            this.Name = "IndividualForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ficha do Voluntário";
            this.Load += new System.EventHandler(this.IndividualForm_Load);
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
        private System.Windows.Forms.TextBox CPFTextBox;
        private System.Windows.Forms.Label CPFlabel;
        private System.Windows.Forms.TextBox RGTextBox;
        private System.Windows.Forms.Label RGlabel;
        private System.Windows.Forms.TextBox emissorTextBox;
        private System.Windows.Forms.Label RGEmisssorLabel;
        private System.Windows.Forms.TextBox telefoneFixoTextBox;
        private System.Windows.Forms.Label telefoneFixoLabel;
        private System.Windows.Forms.TextBox telefoneCelularTextBox;
        private System.Windows.Forms.Label telefoneCelularLabel;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Label observacoesLabel;
        private System.Windows.Forms.CheckedListBox diasCheckedListBox;
        private System.Windows.Forms.Label diasDisponiveisLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label servicosLabel;
        private System.Windows.Forms.ListBox servicosListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}