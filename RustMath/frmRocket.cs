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
    public partial class frmRocket : Form
    {
        public frmRocket()
        {
            InitializeComponent();
        }
        /*
         * Variables
         */
        int receiveAmount = 0;
        int sulfur = 1250;
        int charcoal = 1950;
        int metalFrag = 180;
        int animalFat = 24;
        int cloth = 8;
        /*
        * Functions/Methods
        */
        private void CalcResources() // receives amount of explosive from frmMain and calcs the resources required
        {
            receiveAmount = frmMain.sendAmount;
            lblSulfur.Text = Convert.ToString(receiveAmount * sulfur);
            lblCharcoal.Text = Convert.ToString(receiveAmount * charcoal);
            lblMetalFrag.Text = Convert.ToString(receiveAmount * metalFrag);
            lblAnimalFat.Text = Convert.ToString(receiveAmount * animalFat);
            lblCloth.Text = Convert.ToString(receiveAmount * cloth); 
        }

        private void frmRocket_Load(object sender, EventArgs e)
        {
            CalcResources();
            //MessageBox.Show(receiveAmount.ToString()); //DEBUGGING ONLY 
        }

        private void cmdBack_Click(object sender, EventArgs e) //closes form, duhhh..
        {
            this.Close();
        }
    }
}
