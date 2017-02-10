using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustMath  //Version 1.0
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /*
         * Variables 
         */
        public static int sendAmount = 0; //Send Amount of explosive to resources form

        /*
         * All Functions below
         */
        public void WoodenWall()
        {
            if (optWood.Checked == true)
            {
                lblC4.Text = "1";
                lblRocket.Text = "2";
                lblSatchelCharge.Text = "3";
                lblF1.Text = "6";
                lblBean.Text = "13";
            }
        }

        public void StoneWall()
        {
            if (optStone.Checked == true)
            {
                lblC4.Text = "2";
                lblRocket.Text = "4";
                lblSatchelCharge.Text = "10";
                lblF1.Text = "22";
                lblBean.Text = "46";
            }
        }

        public void SheetWall()
        {
            if (optSheet.Checked == true)
            {
                lblC4.Text = "2";
                lblRocket.Text = "4";
                lblSatchelCharge.Text = "13";
                lblF1.Text = "26";
                lblBean.Text = "63";
            }
        }

        public void ArmoredWall()
        {
            if (optArmored.Checked == true)
            {
                lblC4.Text = "3";
                lblRocket.Text = "6";
                lblSatchelCharge.Text = "18";
                lblF1.Text = "34";
                lblBean.Text = "84";
            }
        }

        public void WoodDoor()
        {
            if (optWoodDoor.Checked == true)
            {
                lblC4.Text = "1";
                lblRocket.Text = "1";
                lblSatchelCharge.Text = "2";
                lblF1.Text = "3";
                lblBean.Text = "6";
            }
        }

        public void SheetDoor()
        {
            if (optSheetDoor.Checked == true)
            {
                lblC4.Text = "1";
                lblRocket.Text = "2";
                lblSatchelCharge.Text = "4";
                lblF1.Text = "50"; //Number could be wrong, following rust.wikia.com
                lblBean.Text = "18";
            }
        }

        public void ArmoredDoor()
        {
            if (optArmoredDoor.Checked == true)
            {
                lblC4.Text = "2";
                lblRocket.Text = "4";
                lblSatchelCharge.Text = "12";
                lblF1.Text = "24";
                lblBean.Text = "56";
            }
        }

        public void LadderHatch()
        {
            if (optLadderHatch.Checked == true)
            {
                lblC4.Text = "1";
                lblRocket.Text = "2";
                lblSatchelCharge.Text = "4";
                lblF1.Text = "8";
                lblBean.Text = "18";
            }
        }

        public void WoodExternal()
        {
            if (optWoodExternal.Checked == true)
            {
                lblC4.Text = "2";
                lblRocket.Text = "3";
                lblSatchelCharge.Text = "6";
                lblF1.Text = "12";
                lblBean.Text = "26";
            }
        }

        public void StoneExternal()
        {
            if (optStoneExternal.Checked == true)
            {
                lblC4.Text = "2";
                lblRocket.Text = "4";
                lblSatchelCharge.Text = "10";
                lblF1.Text = "22";
                lblBean.Text = "46";
            }
        }

      
     /*
      * Call all functions below
      */
        private void cmdRustMath_Click(object sender, EventArgs e) //Calls functions on button press to calculate amount of explosives req
        {
                WoodenWall();
                StoneWall();
                SheetWall();
                ArmoredWall();
                WoodDoor();
                SheetDoor();
                ArmoredDoor();
                LadderHatch();
                WoodExternal();
                StoneExternal();
        }

        public void picC4_Click(object sender, EventArgs e)
        {
            sendAmount = Convert.ToInt32(lblC4.Text);
            frmMain frm = new frmMain();
            (new frmC4()).ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to RustMath! Please select which structure you'd like to destroy then click on the icon of your preferred method of destruction to see how many resources will be needed to craft the amount you require. Happy Raiding!");
        }

        private void picRocket_Click(object sender, EventArgs e)
        {
            sendAmount = Convert.ToInt32(lblRocket.Text);
            frmMain frm = new frmMain();
            (new frmRocket()).ShowDialog();
        }

        private void picSatchel_Click(object sender, EventArgs e)
        {
            sendAmount = Convert.ToInt32(lblSatchelCharge.Text);
            frmMain frm = new frmMain();
            (new frmSatchel()).ShowDialog();
        }

        private void picF1_Click(object sender, EventArgs e)
        {
            sendAmount = Convert.ToInt32(lblF1.Text);
            frmMain frm = new frmMain();
            (new frmF1()).ShowDialog();
        }

        private void picBeancan_Click(object sender, EventArgs e)
        {
            sendAmount = Convert.ToInt32(lblBean.Text);
            frmMain frm = new frmMain();
            (new frmBean()).ShowDialog();
        }
    }
}
