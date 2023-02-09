using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class Form2 : Form
    {
        //private DataHandler dh; // DataHandler nyní abstraktní 
        public Form2()
        {
            InitializeComponent();
            //dh = new DataHandler(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dh.date = dateTimePicker1.Value;
            DataHandler.zvoleneDatum = dateTimePicker1.Value;
            this.Close();
        }
    }
}
