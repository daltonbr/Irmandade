namespace Irmandade
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
            this.exitButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(28, 359);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Adicionar Serviço";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Location = new System.Drawing.Point(28, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 184);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(229, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&OK";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(319, 173);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(32, 261);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(123, 20);
            this.textBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(224, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(127, 46);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "&Editar Serviço";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(384, 417);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Name = "ServicoForm";
            this.Text = "Gerenciar Serviços";
            this.Load += new System.EventHandler(this.ServicoForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button editButton;
    }
}