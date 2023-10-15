using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungKu
{
    public partial class FormLoading : Form
    {
        int startPoint = 0;
        public FormLoading()
        {
            InitializeComponent();
            timerKu.Start();
        }
                private void timerKu_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBarKu.Value = startPoint;
            if (progressBarKu.Value == 100)
            {
                progressBarKu.Value = 0;
                timerKu.Stop();
                FormLogin FL = new FormLogin();
                this.Hide();
                FL.Show();
            }
        }
           }
}
