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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(92, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(97, 913);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(279, 121);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(939, 913);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(279, 121);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "S&air";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(495, 913);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(279, 121);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "&Editar";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(97, 91);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(1121, 31);
            this.nomeTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(97, 635);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(1121, 31);
            this.emailTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(92, 607);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(65, 25);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.Location = new System.Drawing.Point(97, 185);
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(401, 31);
            this.CPFTextBox.TabIndex = 8;
            // 
            // CPFlabel
            // 
            this.CPFlabel.AutoSize = true;
            this.CPFlabel.Location = new System.Drawing.Point(92, 157);
            this.CPFlabel.Name = "CPFlabel";
            this.CPFlabel.Size = new System.Drawing.Size(54, 25);
            this.CPFlabel.TabIndex = 7;
            this.CPFlabel.Text = "CPF";
            // 
            // RGTextBox
            // 
            this.RGTextBox.Location = new System.Drawing.Point(543, 185);
            this.RGTextBox.Name = "RGTextBox";
            this.RGTextBox.Size = new System.Drawing.Size(327, 31);
            this.RGTextBox.TabIndex = 10;
            // 
            // RGlabel
            // 
            this.RGlabel.AutoSize = true;
            this.RGlabel.Location = new System.Drawing.Point(538, 157);
            this.RGlabel.Name = "RGlabel";
            this.RGlabel.Size = new System.Drawing.Size(43, 25);
            this.RGlabel.TabIndex = 9;
            this.RGlabel.Text = "RG";
            this.RGlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // emissorTextBox
            // 
            this.emissorTextBox.Location = new System.Drawing.Point(899, 185);
            this.emissorTextBox.Name = "emissorTextBox";
            this.emissorTextBox.Size = new System.Drawing.Size(319, 31);
            this.emissorTextBox.TabIndex = 12;
            // 
            // RGEmisssorLabel
            // 
            this.RGEmisssorLabel.AutoSize = true;
            this.RGEmisssorLabel.Location = new System.Drawing.Point(894, 157);
            this.RGEmisssorLabel.Name = "RGEmisssorLabel";
            this.RGEmisssorLabel.Size = new System.Drawing.Size(89, 25);
            this.RGEmisssorLabel.TabIndex = 11;
            this.RGEmisssorLabel.Text = "Emissor";
            // 
            // telefoneFixoTextBox
            // 
            this.telefoneFixoTextBox.Location = new System.Drawing.Point(97, 281);
            this.telefoneFixoTextBox.Name = "telefoneFixoTextBox";
            this.telefoneFixoTextBox.Size = new System.Drawing.Size(401, 31);
            this.telefoneFixoTextBox.TabIndex = 14;
            // 
            // telefoneFixoLabel
            // 
            this.telefoneFixoLabel.AutoSize = true;
            this.telefoneFixoLabel.Location = new System.Drawing.Point(92, 253);
            this.telefoneFixoLabel.Name = "telefoneFixoLabel";
            this.telefoneFixoLabel.Size = new System.Drawing.Size(143, 25);
            this.telefoneFixoLabel.TabIndex = 13;
            this.telefoneFixoLabel.Text = "Telefone Fixo";
            // 
            // telefoneCelularTextBox
            // 
            this.telefoneCelularTextBox.Location = new System.Drawing.Point(543, 283);
            this.telefoneCelularTextBox.Name = "telefoneCelularTextBox";
            this.telefoneCelularTextBox.Size = new System.Drawing.Size(327, 31);
            this.telefoneCelularTextBox.TabIndex = 16;
            // 
            // telefoneCelularLabel
            // 
            this.telefoneCelularLabel.AutoSize = true;
            this.telefoneCelularLabel.Location = new System.Drawing.Point(538, 253);
            this.telefoneCelularLabel.Name = "telefoneCelularLabel";
            this.telefoneCelularLabel.Size = new System.Drawing.Size(80, 25);
            this.telefoneCelularLabel.TabIndex = 15;
            this.telefoneCelularLabel.Text = "Celular";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.AcceptsReturn = true;
            this.observacoesTextBox.AcceptsTab = true;
            this.observacoesTextBox.Location = new System.Drawing.Point(97, 721);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacoesTextBox.Size = new System.Drawing.Size(1121, 128);
            this.observacoesTextBox.TabIndex = 18;
            // 
            // observacoesLabel
            // 
            this.observacoesLabel.AutoSize = true;
            this.observacoesLabel.Location = new System.Drawing.Point(92, 693);
            this.observacoesLabel.Name = "observacoesLabel";
            this.observacoesLabel.Size = new System.Drawing.Size(139, 25);
            this.observacoesLabel.TabIndex = 17;
            this.observacoesLabel.Text = "Observações";
            // 
            // diasCheckedListBox
            // 
            this.diasCheckedListBox.CheckOnClick = true;
            this.diasCheckedListBox.FormattingEnabled = true;
            this.diasCheckedListBox.Location = new System.Drawing.Point(899, 385);
            this.diasCheckedListBox.Name = "diasCheckedListBox";
            this.diasCheckedListBox.Size = new System.Drawing.Size(319, 160);
            this.diasCheckedListBox.TabIndex = 19;
            // 
            // diasDisponiveisLabel
            // 
            this.diasDisponiveisLabel.AutoSize = true;
            this.diasDisponiveisLabel.Location = new System.Drawing.Point(894, 357);
            this.diasDisponiveisLabel.Name = "diasDisponiveisLabel";
            this.diasDisponiveisLabel.Size = new System.Drawing.Size(172, 25);
            this.diasDisponiveisLabel.TabIndex = 20;
            this.diasDisponiveisLabel.Text = "Dias Disponíveis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Início das Atividades";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(899, 281);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(319, 31);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(97, 385);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(401, 179);
            this.enderecoTextBox.TabIndex = 24;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(92, 357);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(104, 25);
            this.enderecoLabel.TabIndex = 23;
            this.enderecoLabel.Text = "Endereço";
            // 
            // servicosLabel
            // 
            this.servicosLabel.AutoSize = true;
            this.servicosLabel.Location = new System.Drawing.Point(538, 357);
            this.servicosLabel.Name = "servicosLabel";
            this.servicosLabel.Size = new System.Drawing.Size(95, 25);
            this.servicosLabel.TabIndex = 25;
            this.servicosLabel.Text = "Serviços";
            // 
            // servicosListBox
            // 
            this.servicosListBox.FormattingEnabled = true;
            this.servicosListBox.ItemHeight = 25;
            this.servicosListBox.Location = new System.Drawing.Point(543, 385);
            this.servicosListBox.Name = "servicosListBox";
            this.servicosListBox.Size = new System.Drawing.Size(327, 179);
            this.servicosListBox.TabIndex = 26;
            // 
            // IndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1081);
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
            this.Name = "IndividualForm";
            this.Text = "IndividualForm";
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
    }
}