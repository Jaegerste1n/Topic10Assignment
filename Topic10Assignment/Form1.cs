using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic10Assignment
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            int rand = generator.Next(1, 6);
            if (rand == 5)
            {
                imgMario.Enabled = false;
                imgMario.Image = Properties.Resources.MarioEyWhatGives;
                btnThatKillsMario.Enabled = true;
                btnThatKillsMario.Visible = true;
                lblMarioComplaint.Visible = true;
                lblMarioComplaint.Text = "I'M GOING TO STOMP YOU INTO A STAIN ON THE CONCRETE YOU FERMENTED TURTLE LEG";
                lblMarioComplaint.Location = new Point(200, 350);
                lblMarioComplaint.Font = new Font("Impact", 12, FontStyle.Bold);
                imgMario.BackColor = Color.DarkRed;
            }
            else
            {
                imgMario.Enabled = false;
                imgMario.Image = Properties.Resources.MarioEyWhatGives;
                btnThatKillsMario.Enabled = true;
                btnThatKillsMario.Visible = true;
                lblMarioComplaint.Visible = true;
                lblMarioComplaint.Location = new Point(455, 350);
            }

        }

        private void btnThatKillsMario_Click(object sender, EventArgs e)
        {
            imgMario.Enabled = true;
            imgMario.Image = Properties.Resources.MarioDead;
            btnThatKillsMario.Enabled = false;
            btnThatKillsMario.Visible = false;
            lblMarioComplaint.Visible = false;
            imgMario.BackColor = Color.Transparent;
            lblMarioComplaint.Font = new Font("Papyrus", 8, FontStyle.Regular);
            lblMarioComplaint.Text = "What Is Wrong With You Why Would You Do That You Herrid Twat";
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.Cpu;
            lblDescription.Text = "The CPU is the brain of the computer. It manages a variety of things.";
            lblDesc2.Text = "";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.Ram;
            lblDescription.Text = "RAM is a fast memory that stores programs and data that is being actively used,";
            lblDesc2.Text = "and this data is lost when the computer is shut off.";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.Ssd;
            lblDescription.Text = "SSD, standing for Solid State Drive, is a storage device with no moving parts.";
            lblDesc2.Text = "It is notably fast and silent.";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }

        private void btnPowerSupply_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.PowerSupply;
            lblDescription.Text = "The power supply converts electrical energy into a specific voltage/frequency/current";
            lblDesc2.Text = "depending on what the computer currently needs.";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }

        private void btnInputPeripheral_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.MarioEyWhatGives;
            lblDescription.Text = "Placeholder";
            lblDesc2.Text = "Placeholder";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }

        private void btnOutputPeripheral_Click(object sender, EventArgs e)
        {
            imgComponent.Image = Properties.Resources.MarioEyWhatGives;
            lblDescription.Text = "Placeholder";
            lblDesc2.Text = "Placeholder";
            lblDescription.Visible = true;
            lblDesc2.Visible = true;
        }
    }
}
