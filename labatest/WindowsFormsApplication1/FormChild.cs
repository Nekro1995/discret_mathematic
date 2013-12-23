using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        private void FormChild_Paint(object sender, PaintEventArgs e)
        {
          
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red), 10, 10, 50, 50);
            g.DrawRectangle(new Pen(Color.Green), 70, 10, 50, 50);
            g.DrawLine(new Pen(Color.Yellow), 130, 35, 150, 35);
            g.DrawLine(new Pen(Color.Purple), 160, 10, 160, 60);
            
        }

    }
}
