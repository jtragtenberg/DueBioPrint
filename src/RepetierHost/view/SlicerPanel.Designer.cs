﻿namespace RepetierHost.view
{
    partial class SlicerPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlicerPanel));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSetupSlic3r = new System.Windows.Forms.Button();
            this.buttonSlic3rConfigure = new System.Windows.Forms.Button();
            this.comboSlic3rPrinterSettings = new System.Windows.Forms.ComboBox();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboSlic3rFilamentSettings2 = new System.Windows.Forms.ComboBox();
            this.comboSlic3rFilamentSettings = new System.Windows.Forms.ComboBox();
            this.comboSlic3rPrintSettings = new System.Windows.Forms.ComboBox();
            this.labelSlic3rExtruder2 = new System.Windows.Forms.Label();
            this.switchSlic3rActive = new RepetierHost.view.SwitchButton();
            this.labelSlic3rExtruder1 = new System.Windows.Forms.Label();
            this.labelPrinterSettings = new System.Windows.Forms.Label();
            this.labelFilamentSettings = new System.Windows.Forms.Label();
            this.labelPrintSettings = new System.Windows.Forms.Label();
            this.buttonStartSlicing = new System.Windows.Forms.Button();
            this.buttonKillSlicing = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSlic3rPos = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelSlic3rPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonSetupSlic3r);
            this.groupBox2.Controls.Add(this.buttonSlic3rConfigure);
            this.groupBox2.Controls.Add(this.comboSlic3rPrinterSettings);
            this.groupBox2.Controls.Add(this.comboSlic3rFilamentSettings2);
            this.groupBox2.Controls.Add(this.comboSlic3rFilamentSettings);
            this.groupBox2.Controls.Add(this.comboSlic3rPrintSettings);
            this.groupBox2.Controls.Add(this.labelSlic3rExtruder2);
            this.groupBox2.Controls.Add(this.switchSlic3rActive);
            this.groupBox2.Controls.Add(this.labelSlic3rExtruder1);
            this.groupBox2.Controls.Add(this.labelPrinterSettings);
            this.groupBox2.Controls.Add(this.labelFilamentSettings);
            this.groupBox2.Controls.Add(this.labelPrintSettings);
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slic3r";
            // 
            // buttonSetupSlic3r
            // 
            this.buttonSetupSlic3r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetupSlic3r.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetupSlic3r.Image")));
            this.buttonSetupSlic3r.Location = new System.Drawing.Point(481, 150);
            this.buttonSetupSlic3r.Name = "buttonSetupSlic3r";
            this.buttonSetupSlic3r.Size = new System.Drawing.Size(111, 23);
            this.buttonSetupSlic3r.TabIndex = 3;
            this.buttonSetupSlic3r.Text = "Setup";
            this.buttonSetupSlic3r.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetupSlic3r.UseVisualStyleBackColor = true;
            this.buttonSetupSlic3r.Click += new System.EventHandler(this.buttonSetupSlic3r_Click);
            // 
            // buttonSlic3rConfigure
            // 
            this.buttonSlic3rConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSlic3rConfigure.Image = ((System.Drawing.Image)(resources.GetObject("buttonSlic3rConfigure.Image")));
            this.buttonSlic3rConfigure.Location = new System.Drawing.Point(481, 20);
            this.buttonSlic3rConfigure.Name = "buttonSlic3rConfigure";
            this.buttonSlic3rConfigure.Size = new System.Drawing.Size(111, 23);
            this.buttonSlic3rConfigure.TabIndex = 2;
            this.buttonSlic3rConfigure.Text = "Configure";
            this.buttonSlic3rConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSlic3rConfigure.UseVisualStyleBackColor = true;
            this.buttonSlic3rConfigure.Click += new System.EventHandler(this.buttonSlic3rConfigure_Click);
            // 
            // comboSlic3rPrinterSettings
            // 
            this.comboSlic3rPrinterSettings.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainBindingSource, "Slic3rPrinter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rPrinterSettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Slic3rPrinter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rPrinterSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rPrinterSettings.FormattingEnabled = true;
            this.comboSlic3rPrinterSettings.Location = new System.Drawing.Point(126, 73);
            this.comboSlic3rPrinterSettings.Name = "comboSlic3rPrinterSettings";
            this.comboSlic3rPrinterSettings.Size = new System.Drawing.Size(163, 21);
            this.comboSlic3rPrinterSettings.TabIndex = 1;
            this.comboSlic3rPrinterSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rPrinterSettings_SelectedIndexChanged);
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(RepetierHost.model.PrinterModel);
            // 
            // comboSlic3rFilamentSettings2
            // 
            this.comboSlic3rFilamentSettings2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainBindingSource, "Slic3rFilament2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rFilamentSettings2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Slic3rFilament2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rFilamentSettings2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rFilamentSettings2.FormattingEnabled = true;
            this.comboSlic3rFilamentSettings2.Location = new System.Drawing.Point(126, 152);
            this.comboSlic3rFilamentSettings2.Name = "comboSlic3rFilamentSettings2";
            this.comboSlic3rFilamentSettings2.Size = new System.Drawing.Size(163, 21);
            this.comboSlic3rFilamentSettings2.TabIndex = 1;
            this.comboSlic3rFilamentSettings2.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rFilamentSettings2_SelectedIndexChanged);
            // 
            // comboSlic3rFilamentSettings
            // 
            this.comboSlic3rFilamentSettings.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainBindingSource, "Slic3rFilament1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rFilamentSettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Slic3rFilament1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rFilamentSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rFilamentSettings.FormattingEnabled = true;
            this.comboSlic3rFilamentSettings.Location = new System.Drawing.Point(126, 127);
            this.comboSlic3rFilamentSettings.Name = "comboSlic3rFilamentSettings";
            this.comboSlic3rFilamentSettings.Size = new System.Drawing.Size(163, 21);
            this.comboSlic3rFilamentSettings.TabIndex = 1;
            this.comboSlic3rFilamentSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rFilamentSettings_SelectedIndexChanged);
            // 
            // comboSlic3rPrintSettings
            // 
            this.comboSlic3rPrintSettings.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainBindingSource, "Slic3rPrint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rPrintSettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Slic3rPrint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboSlic3rPrintSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rPrintSettings.FormattingEnabled = true;
            this.comboSlic3rPrintSettings.Location = new System.Drawing.Point(126, 46);
            this.comboSlic3rPrintSettings.Name = "comboSlic3rPrintSettings";
            this.comboSlic3rPrintSettings.Size = new System.Drawing.Size(163, 21);
            this.comboSlic3rPrintSettings.TabIndex = 1;
            this.comboSlic3rPrintSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rPrintSettings_SelectedIndexChanged);
            // 
            // labelSlic3rExtruder2
            // 
            this.labelSlic3rExtruder2.AutoSize = true;
            this.labelSlic3rExtruder2.Location = new System.Drawing.Point(10, 155);
            this.labelSlic3rExtruder2.Name = "labelSlic3rExtruder2";
            this.labelSlic3rExtruder2.Size = new System.Drawing.Size(58, 13);
            this.labelSlic3rExtruder2.TabIndex = 0;
            this.labelSlic3rExtruder2.Text = "Extruder 2:";
            // 
            // switchSlic3rActive
            // 
            this.switchSlic3rActive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchSlic3rActive.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchSlic3rActive.ButtonFlatBorderSize = 1;
            this.switchSlic3rActive.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchSlic3rActive.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchSlic3rActive.Location = new System.Drawing.Point(10, 20);
            this.switchSlic3rActive.MinimumSize = new System.Drawing.Size(90, 23);
            this.switchSlic3rActive.Name = "switchSlic3rActive";
            this.switchSlic3rActive.On = false;
            this.switchSlic3rActive.Size = new System.Drawing.Size(100, 23);
            this.switchSlic3rActive.TabIndex = 0;
            this.switchSlic3rActive.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchSlic3rActive.TextOff = "Active";
            this.switchSlic3rActive.TextOn = "Active";
            this.switchSlic3rActive.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchSlic3rActive_OnChange);
            // 
            // labelSlic3rExtruder1
            // 
            this.labelSlic3rExtruder1.AutoSize = true;
            this.labelSlic3rExtruder1.Location = new System.Drawing.Point(10, 130);
            this.labelSlic3rExtruder1.Name = "labelSlic3rExtruder1";
            this.labelSlic3rExtruder1.Size = new System.Drawing.Size(58, 13);
            this.labelSlic3rExtruder1.TabIndex = 0;
            this.labelSlic3rExtruder1.Text = "Extruder 1:";
            // 
            // labelPrinterSettings
            // 
            this.labelPrinterSettings.AutoSize = true;
            this.labelPrinterSettings.Location = new System.Drawing.Point(10, 76);
            this.labelPrinterSettings.Name = "labelPrinterSettings";
            this.labelPrinterSettings.Size = new System.Drawing.Size(79, 13);
            this.labelPrinterSettings.TabIndex = 0;
            this.labelPrinterSettings.Text = "Printer settings:";
            // 
            // labelFilamentSettings
            // 
            this.labelFilamentSettings.AutoSize = true;
            this.labelFilamentSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilamentSettings.Location = new System.Drawing.Point(10, 103);
            this.labelFilamentSettings.Name = "labelFilamentSettings";
            this.labelFilamentSettings.Size = new System.Drawing.Size(106, 13);
            this.labelFilamentSettings.TabIndex = 0;
            this.labelFilamentSettings.Text = "Filament settings:";
            // 
            // labelPrintSettings
            // 
            this.labelPrintSettings.AutoSize = true;
            this.labelPrintSettings.Location = new System.Drawing.Point(10, 49);
            this.labelPrintSettings.Name = "labelPrintSettings";
            this.labelPrintSettings.Size = new System.Drawing.Size(70, 13);
            this.labelPrintSettings.TabIndex = 0;
            this.labelPrintSettings.Text = "Print settings:";
            // 
            // buttonStartSlicing
            // 
            this.buttonStartSlicing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartSlicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSlicing.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartSlicing.Image")));
            this.buttonStartSlicing.Location = new System.Drawing.Point(6, 3);
            this.buttonStartSlicing.Name = "buttonStartSlicing";
            this.buttonStartSlicing.Size = new System.Drawing.Size(476, 67);
            this.buttonStartSlicing.TabIndex = 1;
            this.buttonStartSlicing.Text = "Slice with Slic3r";
            this.buttonStartSlicing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStartSlicing.UseVisualStyleBackColor = true;
            this.buttonStartSlicing.Click += new System.EventHandler(this.buttonStartSlicing_Click);
            // 
            // buttonKillSlicing
            // 
            this.buttonKillSlicing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKillSlicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKillSlicing.Location = new System.Drawing.Point(488, 3);
            this.buttonKillSlicing.Name = "buttonKillSlicing";
            this.buttonKillSlicing.Size = new System.Drawing.Size(111, 67);
            this.buttonKillSlicing.TabIndex = 3;
            this.buttonKillSlicing.Text = "Kill slicing\r\nprocess";
            this.buttonKillSlicing.UseVisualStyleBackColor = true;
            this.buttonKillSlicing.Click += new System.EventHandler(this.buttonKillSlicing_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonStartSlicing);
            this.panelTop.Controls.Add(this.buttonKillSlicing);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 81);
            this.panelTop.TabIndex = 4;
            // 
            // panelSlic3rPos
            // 
            this.panelSlic3rPos.Controls.Add(this.groupBox2);
            this.panelSlic3rPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSlic3rPos.Location = new System.Drawing.Point(0, 81);
            this.panelSlic3rPos.Name = "panelSlic3rPos";
            this.panelSlic3rPos.Size = new System.Drawing.Size(610, 185);
            this.panelSlic3rPos.TabIndex = 5;
            // 
            // SlicerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panelSlic3rPos);
            this.Controls.Add(this.panelTop);
            this.Name = "SlicerPanel";
            this.Size = new System.Drawing.Size(610, 267);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelSlic3rPos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStartSlicing;
        private SwitchButton switchSlic3rActive;
        private System.Windows.Forms.ComboBox comboSlic3rPrinterSettings;
        private System.Windows.Forms.ComboBox comboSlic3rFilamentSettings;
        private System.Windows.Forms.ComboBox comboSlic3rPrintSettings;
        private System.Windows.Forms.Label labelPrinterSettings;
        private System.Windows.Forms.Label labelFilamentSettings;
        private System.Windows.Forms.Label labelPrintSettings;
        private System.Windows.Forms.Button buttonSlic3rConfigure;
        private System.Windows.Forms.Button buttonSetupSlic3r;
        private System.Windows.Forms.Button buttonKillSlicing;
        private System.Windows.Forms.ComboBox comboSlic3rFilamentSettings2;
        private System.Windows.Forms.Label labelSlic3rExtruder2;
        private System.Windows.Forms.Label labelSlic3rExtruder1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSlic3rPos;
        private System.Windows.Forms.BindingSource mainBindingSource;
    }
}
