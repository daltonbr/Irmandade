namespace Irmandade.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.servicosComboBox = new System.Windows.Forms.ComboBox();
            this.diasCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtroGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirVoluntárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVoluntárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirVoluntárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gerenciarServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.filtroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            resources.ApplyResources(this.gridPanel, "gridPanel");
            this.gridPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPanel.Controls.Add(this.dataGridView);
            this.gridPanel.Name = "gridPanel";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Name = "panel1";
            // 
            // editButton
            // 
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.Name = "editButton";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // insertButton
            // 
            resources.ApplyResources(this.insertButton, "insertButton");
            this.insertButton.Name = "insertButton";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Name = "panel2";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // servicosComboBox
            // 
            this.servicosComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.servicosComboBox, "servicosComboBox");
            this.servicosComboBox.Name = "servicosComboBox";
            this.servicosComboBox.SelectedIndexChanged += new System.EventHandler(this.servicosComboBox_SelectedIndexChanged);
            // 
            // diasCheckedListBox
            // 
            this.diasCheckedListBox.CheckOnClick = true;
            resources.ApplyResources(this.diasCheckedListBox, "diasCheckedListBox");
            this.diasCheckedListBox.FormattingEnabled = true;
            this.diasCheckedListBox.Items.AddRange(new object[] {
            resources.GetString("diasCheckedListBox.Items"),
            resources.GetString("diasCheckedListBox.Items1"),
            resources.GetString("diasCheckedListBox.Items2"),
            resources.GetString("diasCheckedListBox.Items3"),
            resources.GetString("diasCheckedListBox.Items4")});
            this.diasCheckedListBox.Name = "diasCheckedListBox";
            this.diasCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.diasCheckedListBox_SelectedIndexChanged);
            // 
            // filtroGroupBox
            // 
            resources.ApplyResources(this.filtroGroupBox, "filtroGroupBox");
            this.filtroGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filtroGroupBox.Controls.Add(this.pictureBox3);
            this.filtroGroupBox.Controls.Add(this.cleanButton);
            this.filtroGroupBox.Controls.Add(this.pictureBox1);
            this.filtroGroupBox.Controls.Add(this.label2);
            this.filtroGroupBox.Controls.Add(this.label1);
            this.filtroGroupBox.Controls.Add(this.searchNameLabel);
            this.filtroGroupBox.Controls.Add(this.nameSearchTextBox);
            this.filtroGroupBox.Controls.Add(this.servicosComboBox);
            this.filtroGroupBox.Controls.Add(this.diasCheckedListBox);
            this.filtroGroupBox.Name = "filtroGroupBox";
            this.filtroGroupBox.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // cleanButton
            // 
            resources.ApplyResources(this.cleanButton, "cleanButton");
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // searchNameLabel
            // 
            resources.ApplyResources(this.searchNameLabel, "searchNameLabel");
            this.searchNameLabel.Name = "searchNameLabel";
            // 
            // nameSearchTextBox
            // 
            resources.ApplyResources(this.nameSearchTextBox, "nameSearchTextBox");
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.TextChanged += new System.EventHandler(this.nameSearchTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirVoluntárioToolStripMenuItem,
            this.editarVoluntárioToolStripMenuItem,
            this.toolStripSeparator4,
            this.excluirVoluntárioToolStripMenuItem,
            this.toolStripSeparator1,
            this.gerenciarServiçosToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // inserirVoluntárioToolStripMenuItem
            // 
            this.inserirVoluntárioToolStripMenuItem.Name = "inserirVoluntárioToolStripMenuItem";
            resources.ApplyResources(this.inserirVoluntárioToolStripMenuItem, "inserirVoluntárioToolStripMenuItem");
            this.inserirVoluntárioToolStripMenuItem.Click += new System.EventHandler(this.inserirVoluntárioToolStripMenuItem_Click);
            // 
            // editarVoluntárioToolStripMenuItem
            // 
            this.editarVoluntárioToolStripMenuItem.Name = "editarVoluntárioToolStripMenuItem";
            resources.ApplyResources(this.editarVoluntárioToolStripMenuItem, "editarVoluntárioToolStripMenuItem");
            this.editarVoluntárioToolStripMenuItem.Click += new System.EventHandler(this.editarVoluntárioToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // excluirVoluntárioToolStripMenuItem
            // 
            this.excluirVoluntárioToolStripMenuItem.Name = "excluirVoluntárioToolStripMenuItem";
            resources.ApplyResources(this.excluirVoluntárioToolStripMenuItem, "excluirVoluntárioToolStripMenuItem");
            this.excluirVoluntárioToolStripMenuItem.Click += new System.EventHandler(this.excluirVoluntárioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // gerenciarServiçosToolStripMenuItem
            // 
            this.gerenciarServiçosToolStripMenuItem.Name = "gerenciarServiçosToolStripMenuItem";
            resources.ApplyResources(this.gerenciarServiçosToolStripMenuItem, "gerenciarServiçosToolStripMenuItem");
            this.gerenciarServiçosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarServiçosToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filtroGroupBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.filtroGroupBox.ResumeLayout(false);
            this.filtroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox servicosComboBox;
        private System.Windows.Forms.CheckedListBox diasCheckedListBox;
        private System.Windows.Forms.GroupBox filtroGroupBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirVoluntárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVoluntárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirVoluntárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

