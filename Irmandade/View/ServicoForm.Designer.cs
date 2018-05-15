namespace Irmandade.View
{
    partial class ServicoForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.editGroup = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.editGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(16, 184);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 73);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Adicionar Serviço ao Voluntário";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 165);
            this.panel1.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(2, 3);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(297, 157);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(172, 184);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 73);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Fechar";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(4, 28);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(291, 24);
            this.textBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(101, 55);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 46);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "&Editar Serviço";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Enabled = false;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(4, 55);
            this.newButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(95, 46);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "&Criar Novo Serviço";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editGroup
            // 
            this.editGroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editGroup.Controls.Add(this.deleteButton);
            this.editGroup.Controls.Add(this.textBox);
            this.editGroup.Controls.Add(this.editButton);
            this.editGroup.Controls.Add(this.newButton);
            this.editGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroup.Location = new System.Drawing.Point(16, 331);
            this.editGroup.Margin = new System.Windows.Forms.Padding(2);
            this.editGroup.Name = "editGroup";
            this.editGroup.Padding = new System.Windows.Forms.Padding(2);
            this.editGroup.Size = new System.Drawing.Size(301, 109);
            this.editGroup.TabIndex = 7;
            this.editGroup.TabStop = false;
            this.editGroup.Text = "Criar e Editar Serviços";
            this.editGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(200, 55);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 46);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "E&xcluir Serviço";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandButton.Location = new System.Drawing.Point(16, 278);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(301, 39);
            this.expandButton.TabIndex = 3;
            this.expandButton.Text = "Mais Opções >>";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // ServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(333, 454);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.editGroup);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(360, 493);
            this.MinimumSize = new System.Drawing.Size(349, 368);
            this.Name = "ServicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Serviços";
            this.Load += new System.EventHandler(this.ServicoForm_Load);
            this.panel1.ResumeLayout(false);
            this.editGroup.ResumeLayout(false);
            this.editGroup.PerformLayout();
            this.ResumeLayout(false);

        }        

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox editGroup;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Button deleteButton;
    }
}