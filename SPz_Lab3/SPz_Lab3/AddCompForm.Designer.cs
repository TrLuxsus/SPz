namespace SPz_Lab3
{
    partial class AddCompForm
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
            this.LName = new System.Windows.Forms.Label();
            this.TBCompName = new System.Windows.Forms.TextBox();
            this.BOK = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(57, 58);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(45, 16);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // TBCompName
            // 
            this.TBCompName.Location = new System.Drawing.Point(108, 54);
            this.TBCompName.Name = "TBCompName";
            this.TBCompName.Size = new System.Drawing.Size(194, 20);
            this.TBCompName.TabIndex = 1;
            // 
            // BOK
            // 
            this.BOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOK.Location = new System.Drawing.Point(60, 103);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 23);
            this.BOK.TabIndex = 2;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(227, 103);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // AddCompForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 138);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.TBCompName);
            this.Controls.Add(this.LName);
            this.Name = "AddCompForm";
            this.Text = "AddComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        public System.Windows.Forms.TextBox TBCompName;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCancel;
    }
}