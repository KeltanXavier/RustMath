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
    public partial class frmC4 : Form
    {
        public frmC4()
        {
            InitializeComponent();
        }
        /*
         * Variables
         */
        int receiveAmount = 0;
        int sulfur = 2200;
        int charcoal = 3000;
        int metalFrag = 200;
        int animalFat = 180;
        int cloth = 5;
        int techTrash = 3;

        /*
         * Functions
         */ 
        private void CalcResources()
        {
            lblSulfur.Text = Convert.ToString(receiveAmount * sulfur);
            lblCharcoal.Text = Convert.ToString(receiveAmount * charcoal);
            lblMetalFrag.Text = Convert.ToString(receiveAmount * metalFrag);
            lblAnimalFat.Text = Convert.ToString(receiveAmount * animalFat);
            lblCloth.Text = Convert.ToString(receiveAmount * cloth);
            lblTechTrash.Text = Convert.ToString(receiveAmount * techTrash);
        }
        private void frmC4_Load(object sender, EventArgs e)
        {
            receiveAmount = frmMain.sendAmount; //receives number of explosives from frmMain
           //DEBUGGING ONLY MessageBox.Show(receiveAmount.ToString());
            CalcResources();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes frmC4
        }

    }
}
