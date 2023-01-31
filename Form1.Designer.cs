namespace RaidTimers
{
    partial class raidForm
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
            this.mapsBox = new System.Windows.Forms.ComboBox();
            this.lblMaps = new System.Windows.Forms.Label();
            this.lblEscapeTime = new System.Windows.Forms.Label();
            this.escapeBox = new System.Windows.Forms.TextBox();
            this.bApply = new System.Windows.Forms.Button();
            this.lblMapPlaceholder = new System.Windows.Forms.Label();
            this.bCheck = new System.Windows.Forms.Button();
            this.chkAllMaps = new System.Windows.Forms.CheckBox();
            this.boxActionsOptions = new System.Windows.Forms.GroupBox();
            this.chkReset = new System.Windows.Forms.CheckBox();
            this.boxActionsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapsBox
            // 
            this.mapsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapsBox.FormattingEnabled = true;
            this.mapsBox.Items.AddRange(new object[] {
            "Customs",
            "Factory Day",
            "Factory Night",
            "Interchange",
            "Labs",
            "Lighthouse",
            "Reserve",
            "Shoreline",
            "Streets",
            "Woods"});
            this.mapsBox.Location = new System.Drawing.Point(205, 21);
            this.mapsBox.Name = "mapsBox";
            this.mapsBox.Size = new System.Drawing.Size(223, 27);
            this.mapsBox.TabIndex = 0;
            this.mapsBox.SelectedIndexChanged += new System.EventHandler(this.mapsBox_SelectedIndexChanged);
            // 
            // lblMaps
            // 
            this.lblMaps.AutoSize = true;
            this.lblMaps.Location = new System.Drawing.Point(138, 24);
            this.lblMaps.Name = "lblMaps";
            this.lblMaps.Size = new System.Drawing.Size(51, 19);
            this.lblMaps.TabIndex = 1;
            this.lblMaps.Text = "Maps:";
            // 
            // lblEscapeTime
            // 
            this.lblEscapeTime.AutoSize = true;
            this.lblEscapeTime.Location = new System.Drawing.Point(12, 69);
            this.lblEscapeTime.Name = "lblEscapeTime";
            this.lblEscapeTime.Size = new System.Drawing.Size(177, 19);
            this.lblEscapeTime.TabIndex = 4;
            this.lblEscapeTime.Text = "Escape Time (minutes):";
            // 
            // escapeBox
            // 
            this.escapeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.escapeBox.Enabled = false;
            this.escapeBox.Location = new System.Drawing.Point(205, 66);
            this.escapeBox.Name = "escapeBox";
            this.escapeBox.Size = new System.Drawing.Size(223, 27);
            this.escapeBox.TabIndex = 5;
            this.escapeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.escapebox_KeyPress);
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.Enabled = false;
            this.bApply.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bApply.Location = new System.Drawing.Point(293, 177);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(135, 38);
            this.bApply.TabIndex = 6;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // lblMapPlaceholder
            // 
            this.lblMapPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMapPlaceholder.AutoSize = true;
            this.lblMapPlaceholder.Location = new System.Drawing.Point(12, 196);
            this.lblMapPlaceholder.Name = "lblMapPlaceholder";
            this.lblMapPlaceholder.Size = new System.Drawing.Size(98, 19);
            this.lblMapPlaceholder.TabIndex = 7;
            this.lblMapPlaceholder.Text = "Placeholder";
            this.lblMapPlaceholder.Visible = false;
            // 
            // bCheck
            // 
            this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheck.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bCheck.Location = new System.Drawing.Point(146, 177);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(135, 38);
            this.bCheck.TabIndex = 8;
            this.bCheck.Text = "Check Time";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // chkAllMaps
            // 
            this.chkAllMaps.AutoSize = true;
            this.chkAllMaps.Location = new System.Drawing.Point(23, 26);
            this.chkAllMaps.Name = "chkAllMaps";
            this.chkAllMaps.Size = new System.Drawing.Size(92, 23);
            this.chkAllMaps.TabIndex = 9;
            this.chkAllMaps.Text = "All maps";
            this.chkAllMaps.UseVisualStyleBackColor = true;
            this.chkAllMaps.CheckedChanged += new System.EventHandler(this.chkAllMaps_CheckedChanged);
            // 
            // boxActionsOptions
            // 
            this.boxActionsOptions.Controls.Add(this.chkReset);
            this.boxActionsOptions.Controls.Add(this.chkAllMaps);
            this.boxActionsOptions.Location = new System.Drawing.Point(205, 99);
            this.boxActionsOptions.Name = "boxActionsOptions";
            this.boxActionsOptions.Size = new System.Drawing.Size(223, 62);
            this.boxActionsOptions.TabIndex = 10;
            this.boxActionsOptions.TabStop = false;
            this.boxActionsOptions.Text = "Options";
            // 
            // chkReset
            // 
            this.chkReset.AutoSize = true;
            this.chkReset.Location = new System.Drawing.Point(130, 26);
            this.chkReset.Name = "chkReset";
            this.chkReset.Size = new System.Drawing.Size(69, 23);
            this.chkReset.TabIndex = 10;
            this.chkReset.Text = "Reset";
            this.chkReset.UseVisualStyleBackColor = true;
            this.chkReset.CheckedChanged += new System.EventHandler(this.chkReset_CheckedChanged);
            // 
            // raidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 236);
            this.Controls.Add(this.boxActionsOptions);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.lblMapPlaceholder);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.escapeBox);
            this.Controls.Add(this.lblEscapeTime);
            this.Controls.Add(this.lblMaps);
            this.Controls.Add(this.mapsBox);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "raidForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaidTimers";
            this.Load += new System.EventHandler(this.raidForm_Load);
            this.boxActionsOptions.ResumeLayout(false);
            this.boxActionsOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mapsBox;
        private System.Windows.Forms.Label lblMaps;
        private System.Windows.Forms.Label lblEscapeTime;
        private System.Windows.Forms.TextBox escapeBox;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lblMapPlaceholder;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.GroupBox boxActionsOptions;
        private System.Windows.Forms.CheckBox chkAllMaps;
        private System.Windows.Forms.CheckBox chkReset;
    }
}

