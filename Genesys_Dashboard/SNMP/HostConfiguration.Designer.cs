namespace Genesys_DashBoard
{
    partial class HostConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostConfiguration));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SnmpPasswordTxt = new System.Windows.Forms.MaskedTextBox();
            this.SnmpUserTxt = new System.Windows.Forms.TextBox();
            this.SnmpCommunityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SnmpVersionTxt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SnmpPortTxt = new System.Windows.Forms.TextBox();
            this.HostNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SnmpPasswordTxt);
            this.groupBox2.Controls.Add(this.SnmpUserTxt);
            this.groupBox2.Controls.Add(this.SnmpCommunityTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SnmpVersionTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Snmp";
            // 
            // SnmpPasswordTxt
            // 
            this.SnmpPasswordTxt.Enabled = false;
            this.SnmpPasswordTxt.Location = new System.Drawing.Point(76, 86);
            this.SnmpPasswordTxt.Name = "SnmpPasswordTxt";
            this.SnmpPasswordTxt.Size = new System.Drawing.Size(166, 20);
            this.SnmpPasswordTxt.TabIndex = 6;
            // 
            // SnmpUserTxt
            // 
            this.SnmpUserTxt.Enabled = false;
            this.SnmpUserTxt.Location = new System.Drawing.Point(76, 62);
            this.SnmpUserTxt.Name = "SnmpUserTxt";
            this.SnmpUserTxt.Size = new System.Drawing.Size(166, 20);
            this.SnmpUserTxt.TabIndex = 5;
            // 
            // SnmpCommunityTxt
            // 
            this.SnmpCommunityTxt.Location = new System.Drawing.Point(76, 13);
            this.SnmpCommunityTxt.Name = "SnmpCommunityTxt";
            this.SnmpCommunityTxt.Size = new System.Drawing.Size(166, 20);
            this.SnmpCommunityTxt.TabIndex = 3;
            this.SnmpCommunityTxt.Text = "public";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Community";
            // 
            // SnmpVersionTxt
            // 
            this.SnmpVersionTxt.FormattingEnabled = true;
            this.SnmpVersionTxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.SnmpVersionTxt.Location = new System.Drawing.Point(76, 36);
            this.SnmpVersionTxt.Name = "SnmpVersionTxt";
            this.SnmpVersionTxt.Size = new System.Drawing.Size(50, 21);
            this.SnmpVersionTxt.TabIndex = 4;
            this.SnmpVersionTxt.Text = "2";
            this.SnmpVersionTxt.SelectedIndexChanged += new System.EventHandler(this.SnmpVersionTxt_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SnmpPortTxt);
            this.groupBox1.Controls.Add(this.HostNameTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host";
            // 
            // SnmpPortTxt
            // 
            this.SnmpPortTxt.Location = new System.Drawing.Point(76, 39);
            this.SnmpPortTxt.Name = "SnmpPortTxt";
            this.SnmpPortTxt.Size = new System.Drawing.Size(50, 20);
            this.SnmpPortTxt.TabIndex = 2;
            this.SnmpPortTxt.Text = "161";
            // 
            // HostNameTxt
            // 
            this.HostNameTxt.Location = new System.Drawing.Point(76, 13);
            this.HostNameTxt.Name = "HostNameTxt";
            this.HostNameTxt.Size = new System.Drawing.Size(166, 20);
            this.HostNameTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hostname";
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(12, 218);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 11;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(185, 218);
            this.CancelBtn.MaximumSize = new System.Drawing.Size(280, 280);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HostConfiguration
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(272, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CancelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "HostConfiguration";
            this.Text = "Host";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox SnmpPasswordTxt;
        private System.Windows.Forms.TextBox SnmpUserTxt;
        private System.Windows.Forms.TextBox SnmpCommunityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SnmpVersionTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SnmpPortTxt;
        private System.Windows.Forms.TextBox HostNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}