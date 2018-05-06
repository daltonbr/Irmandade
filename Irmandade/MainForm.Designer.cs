﻿namespace Irmandade
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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dataGridView);
            resources.ApplyResources(this.gridPanel, "gridPanel");
            this.gridPanel.Name = "gridPanel";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.insertButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            this.panel2.Controls.Add(this.exitButton);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.listBox);
            this.panel3.Controls.Add(this.comboBox);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            resources.ApplyResources(this.listBox, "listBox");
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox, "comboBox");
            this.comboBox.Name = "comboBox";
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox, "checkedListBox");
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label;
    }
}
