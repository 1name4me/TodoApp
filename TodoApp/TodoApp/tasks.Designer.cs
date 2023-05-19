namespace TodoApp
{
    partial class tasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.task_txt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.task_txt);
            this.panel1.Location = new System.Drawing.Point(0, -34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 90);
            this.panel1.TabIndex = 1;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(343, 51);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(65, 30);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // task_txt
            // 
            this.task_txt.BackColor = System.Drawing.Color.Transparent;
            this.task_txt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_txt.Location = new System.Drawing.Point(0, 34);
            this.task_txt.Name = "task_txt";
            this.task_txt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.task_txt.Size = new System.Drawing.Size(432, 67);
            this.task_txt.TabIndex = 2;
            this.task_txt.Text = "label1";
            this.task_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "tasks";
            this.Size = new System.Drawing.Size(432, 67);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeBtn;
        public System.Windows.Forms.Label task_txt;
    }
}
