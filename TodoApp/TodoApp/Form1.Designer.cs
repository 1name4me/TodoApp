namespace TodoApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.task_input = new System.Windows.Forms.TextBox();
            this.task_submit = new System.Windows.Forms.Button();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo App";
            this.label1.UseWaitCursor = true;
            // 
            // task_input
            // 
            this.task_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task_input.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_input.Location = new System.Drawing.Point(38, 98);
            this.task_input.Multiline = true;
            this.task_input.Name = "task_input";
            this.task_input.Size = new System.Drawing.Size(373, 31);
            this.task_input.TabIndex = 1;
            this.task_input.UseWaitCursor = true;
            // 
            // task_submit
            // 
            this.task_submit.BackColor = System.Drawing.Color.Blue;
            this.task_submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.task_submit.Location = new System.Drawing.Point(417, 98);
            this.task_submit.Name = "task_submit";
            this.task_submit.Size = new System.Drawing.Size(53, 31);
            this.task_submit.TabIndex = 2;
            this.task_submit.Text = "ADD";
            this.task_submit.UseVisualStyleBackColor = false;
            this.task_submit.UseWaitCursor = true;
            this.task_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FLP
            // 
            this.FLP.Location = new System.Drawing.Point(38, 182);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(432, 382);
            this.FLP.TabIndex = 3;
            this.FLP.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.task_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 598);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.task_submit);
            this.Controls.Add(this.task_input);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox task_input;
        private System.Windows.Forms.Button task_submit;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

