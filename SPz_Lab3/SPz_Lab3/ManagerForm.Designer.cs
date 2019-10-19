namespace SPz_Lab3
{
    partial class ManagerForm
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
            this.CompLabel = new System.Windows.Forms.Label();
            this.LBCompurets = new System.Windows.Forms.ListBox();
            this.LBTasks = new System.Windows.Forms.ListBox();
            this.TasksLabel = new System.Windows.Forms.Label();
            this.AddCompButtton = new System.Windows.Forms.Button();
            this.RemoveCompButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.BAddRouter = new System.Windows.Forms.Button();
            this.BRemoveRouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompLabel.Location = new System.Drawing.Point(87, 9);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(116, 25);
            this.CompLabel.TabIndex = 0;
            this.CompLabel.Text = "Computers";
            // 
            // LBCompurets
            // 
            this.LBCompurets.FormattingEnabled = true;
            this.LBCompurets.Location = new System.Drawing.Point(17, 50);
            this.LBCompurets.Name = "LBCompurets";
            this.LBCompurets.Size = new System.Drawing.Size(273, 316);
            this.LBCompurets.TabIndex = 1;
            // 
            // LBTasks
            // 
            this.LBTasks.FormattingEnabled = true;
            this.LBTasks.Location = new System.Drawing.Point(515, 50);
            this.LBTasks.Name = "LBTasks";
            this.LBTasks.Size = new System.Drawing.Size(273, 316);
            this.LBTasks.TabIndex = 2;
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoSize = true;
            this.TasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksLabel.Location = new System.Drawing.Point(617, 9);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new System.Drawing.Size(70, 25);
            this.TasksLabel.TabIndex = 3;
            this.TasksLabel.Text = "Tasks";
            // 
            // AddCompButtton
            // 
            this.AddCompButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCompButtton.Location = new System.Drawing.Point(17, 372);
            this.AddCompButtton.Name = "AddCompButtton";
            this.AddCompButtton.Size = new System.Drawing.Size(128, 53);
            this.AddCompButtton.TabIndex = 4;
            this.AddCompButtton.Text = "Add computer";
            this.AddCompButtton.UseVisualStyleBackColor = true;
            this.AddCompButtton.Click += new System.EventHandler(this.AddCompButtton_Click);
            // 
            // RemoveCompButton
            // 
            this.RemoveCompButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveCompButton.Location = new System.Drawing.Point(151, 372);
            this.RemoveCompButton.Name = "RemoveCompButton";
            this.RemoveCompButton.Size = new System.Drawing.Size(139, 53);
            this.RemoveCompButton.TabIndex = 5;
            this.RemoveCompButton.Text = "Remove computer";
            this.RemoveCompButton.UseVisualStyleBackColor = true;
            this.RemoveCompButton.Click += new System.EventHandler(this.RemoveCompButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.Location = new System.Drawing.Point(515, 372);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(128, 53);
            this.AddTaskButton.TabIndex = 6;
            this.AddTaskButton.Text = "Add task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTaskButton.Location = new System.Drawing.Point(649, 372);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(139, 53);
            this.RemoveTaskButton.TabIndex = 7;
            this.RemoveTaskButton.Text = "Remove task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // BAddRouter
            // 
            this.BAddRouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddRouter.Location = new System.Drawing.Point(334, 285);
            this.BAddRouter.Name = "BAddRouter";
            this.BAddRouter.Size = new System.Drawing.Size(139, 32);
            this.BAddRouter.TabIndex = 8;
            this.BAddRouter.Text = "Add router";
            this.BAddRouter.UseVisualStyleBackColor = true;
            this.BAddRouter.Click += new System.EventHandler(this.BAddRouter_Click);
            // 
            // BRemoveRouter
            // 
            this.BRemoveRouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemoveRouter.Location = new System.Drawing.Point(334, 323);
            this.BRemoveRouter.Name = "BRemoveRouter";
            this.BRemoveRouter.Size = new System.Drawing.Size(139, 32);
            this.BRemoveRouter.TabIndex = 9;
            this.BRemoveRouter.Text = "Remove router";
            this.BRemoveRouter.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BRemoveRouter);
            this.Controls.Add(this.BAddRouter);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.RemoveCompButton);
            this.Controls.Add(this.AddCompButtton);
            this.Controls.Add(this.TasksLabel);
            this.Controls.Add(this.LBTasks);
            this.Controls.Add(this.LBCompurets);
            this.Controls.Add(this.CompLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "ComputerManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.ListBox LBCompurets;
        private System.Windows.Forms.ListBox LBTasks;
        private System.Windows.Forms.Label TasksLabel;
        private System.Windows.Forms.Button AddCompButtton;
        private System.Windows.Forms.Button RemoveCompButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button BAddRouter;
        private System.Windows.Forms.Button BRemoveRouter;
    }
}

