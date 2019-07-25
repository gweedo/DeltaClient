using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //listBox1.Text = "acv";
            //listBox1.a
        }

        public void OnClickLabel(object sender, EventArgs e)
        {
            Label label = sender as Label;
            string name = label.Name;
            //UsersCarslistView.Bounds = nome ;
        }

        public void ExitOnClickLabel(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
