namespace SPz_Lab3
{
    partial class AddTaskForm
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
            this.TBTaskName = new System.Windows.Forms.TextBox();
            this.LAdditional = new System.Windows.Forms.Label();
            this.TBAdditionalInf = new System.Windows.Forms.TextBox();
            this.BOK = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(12, 9);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(45, 16);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // TBTaskName
            // 
            this.TBTaskName.Location = new System.Drawing.Point(63, 8);
            this.TBTaskName.Name = "TBTaskName";
            this.TBTaskName.Size = new System.Drawing.Size(208, 20);
            this.TBTaskName.TabIndex = 1;
            // 
            // LAdditional
            // 
            this.LAdditional.AutoSize = true;
            this.LAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAdditional.Location = new System.Drawing.Point(12, 46);
            this.LAdditional.Name = "LAdditional";
            this.LAdditional.Size = new System.Drawing.Size(68, 16);
            this.LAdditional.TabIndex = 2;
            this.LAdditional.Text = "Additional";
            // 
            // TBAdditionalInf
            // 
            this.TBAdditionalInf.Location = new System.Drawing.Point(86, 45);
            this.TBAdditionalInf.Name = "TBAdditionalInf";
            this.TBAdditionalInf.Size = new System.Drawing.Size(185, 20);
            this.TBAdditionalInf.TabIndex = 3;
            // 
            // BOK
            // 
            this.BOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOK.Location = new System.Drawing.Point(15, 122);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 23);
            this.BOK.TabIndex = 4;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(196, 122);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 177);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.TBAdditionalInf);
            this.Controls.Add(this.LAdditional);
            this.Controls.Add(this.TBTaskName);
            this.Controls.Add(this.LName);
            this.Name = "AddTaskForm";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        public System.Windows.Forms.TextBox TBTaskName;
        private System.Windows.Forms.Label LAdditional;
        public System.Windows.Forms.TextBox TBAdditionalInf;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCancel;
    }
}