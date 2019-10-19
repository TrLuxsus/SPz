namespace SPz_Lab3
{
    partial class AddRouterForm
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
            this.LPswd = new System.Windows.Forms.Label();
            this.TBRouterPswd = new System.Windows.Forms.TextBox();
            this.BOK = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LPswd
            // 
            this.LPswd.AutoSize = true;
            this.LPswd.Location = new System.Drawing.Point(13, 57);
            this.LPswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPswd.Name = "LPswd";
            this.LPswd.Size = new System.Drawing.Size(68, 16);
            this.LPswd.TabIndex = 0;
            this.LPswd.Text = "Password";
            // 
            // TBRouterPswd
            // 
            this.TBRouterPswd.Location = new System.Drawing.Point(88, 54);
            this.TBRouterPswd.Name = "TBRouterPswd";
            this.TBRouterPswd.Size = new System.Drawing.Size(264, 22);
            this.TBRouterPswd.TabIndex = 1;
            // 
            // BOK
            // 
            this.BOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOK.Location = new System.Drawing.Point(55, 160);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 23);
            this.BOK.TabIndex = 2;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(258, 160);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // AddRouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 195);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.TBRouterPswd);
            this.Controls.Add(this.LPswd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddRouterForm";
            this.Text = "AddRouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPswd;
        public System.Windows.Forms.TextBox TBRouterPswd;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCancel;
    }
}