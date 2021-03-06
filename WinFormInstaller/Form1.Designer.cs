﻿namespace WinFormInstaller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.currentWeatherMenu = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorMessage = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.currentWeatherMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(474, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // submitLocation
            // 
            this.submitLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitLocation.Location = new System.Drawing.Point(557, 391);
            this.submitLocation.Name = "submitLocation";
            this.submitLocation.Size = new System.Drawing.Size(75, 23);
            this.submitLocation.TabIndex = 1;
            this.submitLocation.Text = "Submit";
            this.submitLocation.UseVisualStyleBackColor = true;
            this.submitLocation.Click += new System.EventHandler(this.submitLocation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Location = new System.Drawing.Point(24, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 250);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // currentWeatherMenu
            // 
            this.currentWeatherMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.currentWeatherMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.currentWeatherMenu.Location = new System.Drawing.Point(0, 0);
            this.currentWeatherMenu.Name = "currentWeatherMenu";
            this.currentWeatherMenu.Size = new System.Drawing.Size(738, 28);
            this.currentWeatherMenu.TabIndex = 5;
            this.currentWeatherMenu.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalInfoToolStripMenuItem,
            this.chartsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // generalInfoToolStripMenuItem
            // 
            this.generalInfoToolStripMenuItem.Name = "generalInfoToolStripMenuItem";
            this.generalInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.generalInfoToolStripMenuItem.Text = "General Info";
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.chartsToolStripMenuItem.Text = "Charts";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.debugModeMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.themeToolStripMenuItem.Text = "Themes";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // debugModeMenuItem
            // 
            this.debugModeMenuItem.Name = "debugModeMenuItem";
            this.debugModeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.debugModeMenuItem.Text = "Debug Mode";
            this.debugModeMenuItem.Click += new System.EventHandler(this.setDebugMode_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(492, 316);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(206, 17);
            this.errorMessage.TabIndex = 6;
            this.errorMessage.Text = "Error: Invalid location submitted";
            this.errorMessage.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(475, 351);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(117, 17);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Current Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(738, 476);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentWeatherMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.currentWeatherMenu;
            this.Name = "Form1";
            this.Text = "Current Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.currentWeatherMenu.ResumeLayout(false);
            this.currentWeatherMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submitLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip currentWeatherMenu;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.ToolStripMenuItem debugModeMenuItem;
        private System.Windows.Forms.Label locationLabel;
    }
}

