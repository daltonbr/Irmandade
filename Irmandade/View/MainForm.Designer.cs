namespace Irmandade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.servicosComboBox = new System.Windows.Forms.ComboBox();
            this.diasCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtroGroupBox = new System.Windows.Forms.GroupBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.filtroGroupBox.SuspendLayout();
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Name = "panel1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.filtroGroupBox.Controls.Add(this.cleanButton);
            this.filtroGroupBox.Controls.Add(this.label2);
            this.filtroGroupBox.Controls.Add(this.label1);
            this.filtroGroupBox.Controls.Add(this.searchNameLabel);
            this.filtroGroupBox.Controls.Add(this.nameSearchTextBox);
            this.filtroGroupBox.Controls.Add(this.servicosComboBox);
            this.filtroGroupBox.Controls.Add(this.diasCheckedListBox);
            this.filtroGroupBox.Name = "filtroGroupBox";
            this.filtroGroupBox.TabStop = false;
            // 
            // cleanButton
            // 
            resources.ApplyResources(this.cleanButton, "cleanButton");
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filtroGroupBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.filtroGroupBox.ResumeLayout(false);
            this.filtroGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
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
    }
}

