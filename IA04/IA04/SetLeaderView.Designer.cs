namespace IA04
{
    partial class SetLeaderView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Leader = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CurrentBoss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Location = new System.Drawing.Point(95, 45);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(82, 13);
            this.lbl_CompanyName.TabIndex = 1;
            this.lbl_CompanyName.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Boss";
            // 
            // cb_Leader
            // 
            this.cb_Leader.FormattingEnabled = true;
            this.cb_Leader.Location = new System.Drawing.Point(98, 99);
            this.cb_Leader.Name = "cb_Leader";
            this.cb_Leader.Size = new System.Drawing.Size(187, 21);
            this.cb_Leader.TabIndex = 2;
            this.cb_Leader.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cb_Leader_Format);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(210, 200);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(210, 171);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(210, 142);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Boss";
            // 
            // lbl_CurrentBoss
            // 
            this.lbl_CurrentBoss.AutoSize = true;
            this.lbl_CurrentBoss.Location = new System.Drawing.Point(95, 73);
            this.lbl_CurrentBoss.Name = "lbl_CurrentBoss";
            this.lbl_CurrentBoss.Size = new System.Drawing.Size(82, 13);
            this.lbl_CurrentBoss.TabIndex = 1;
            this.lbl_CurrentBoss.Text = "Company Name";
            // 
            // SetLeaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 235);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cb_Leader);
            this.Controls.Add(this.lbl_CurrentBoss);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SetLeaderView";
            this.Text = "SetLeaderView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Leader;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CurrentBoss;
    }
}