using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TodoApp
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (task_input.Text != "")
            {
                tasks task = new tasks();
                task.task_txt.Text = task_input.Text;
                FLP.Controls.Add(task);
                task_input.Text = "";
            }            
        }
    }
}
