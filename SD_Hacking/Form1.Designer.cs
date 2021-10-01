namespace SD_Hacking
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
            this.btSubmit = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(80, 663);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(268, 67);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "SUBMIT";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(24, 57);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(374, 450);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // tbTip
            // 
            this.tbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTip.Location = new System.Drawing.Point(24, 13);
            this.tbTip.Name = "tbTip";
            this.tbTip.ReadOnly = true;
            this.tbTip.Size = new System.Drawing.Size(374, 38);
            this.tbTip.TabIndex = 6;
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(24, 534);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(374, 104);
            this.tbInput.TabIndex = 7;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 751);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crack the Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbInput;
    }
}

