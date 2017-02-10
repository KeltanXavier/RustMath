using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustMath
{
    public partial class frmSatchel : Form
    {
        public frmSatchel()
        {
            InitializeComponent();
        }
        /*
        * Variables
        */
        int receiveAmount = 0;
        int sulfur = 480;
        int charcoal = 720;
        int metalFrag = 80;
        int cloth = 10;
        /*
        * Functions/Methods
        */
        private void CalcResources() // receives amount of explosive from frmMain and calcs the resources required
        {
            receiveAmount = frmMain.sendAmount;
            lblSulfur.Text = Convert.ToString(receiveAmount * sulfur);
            lblCharcoal.Text = Convert.ToString(receiveAmount * charcoal);
            lblMetalFrag.Text = Convert.ToString(receiveAmount * metalFrag);
            lblCloth.Text = Convert.ToString(receiveAmount * cloth);
        }


        private void frmSatchel_Load(object sender, EventArgs e)
        {
            CalcResources();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
