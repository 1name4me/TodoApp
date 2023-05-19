using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoApp
{
    public partial class tasks : UserControl
    {
        public tasks()
        {
            InitializeComponent();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }
    }
}



