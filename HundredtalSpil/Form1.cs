using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundredtalSpil
{
    public partial class Form1 : Form
    {
        private int RNGNumber { get; set; }
        private int PointsInt { get; set; }
        public Form1()
        {
            InitializeComponent();
            RNG();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void RNG()
        {
            Random rnd = new Random();
            RNGNumber = rnd.Next(10,100);
            RandomNumber.Text = Convert.ToString(RNGNumber);
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textAdd10.Text) == 0 || Convert.ToInt16(textRemove10.Text) == 0 || Convert.ToInt16(textAdd1.Text) == 0 || Convert.ToInt16(textRemove1.Text) == 0)
            {
                MessageBox.Show("Du skal skrive i alle boxes");
            }
            else
            {
                Add1();
                Remove1();
                Add10();
                Remove10();
            }
        }
        private void Add1()
        {
            int BoxNum;
            BoxNum = Convert.ToInt32(textAdd1.Text);
            if(BoxNum == RNGNumber + 1)
            {
                PointsInt++;
                Points.Text = Convert.ToString(PointsInt);
                textAdd1.BackColor = Color.Green;
            }
            else
            {
                textAdd1.BackColor = Color.Red;
            }
        }
        private void Add10()
        {
            int BoxNum;
            BoxNum = Convert.ToInt32(textAdd10.Text);
            if (BoxNum == RNGNumber + 10)
            {
                PointsInt++;
                Points.Text = Convert.ToString(PointsInt);
                textAdd10.BackColor = Color.Green;
            }
            else
            {
                textAdd10.BackColor = Color.Red;
            }
        }

        private void Remove1()
        {
            int BoxNum;
            BoxNum = Convert.ToInt32(textRemove1.Text);
            if (BoxNum == RNGNumber - 1)
            {
                PointsInt++;
                Points.Text = Convert.ToString(PointsInt);
                textRemove1.BackColor = Color.Green;
            }
            else
            {
                textRemove1.BackColor = Color.Red;
            }
        }

        private void Remove10()
        {
            int BoxNum;
            BoxNum = Convert.ToInt32(textRemove10.Text);
            if (BoxNum == RNGNumber - 10)
            {
                PointsInt++;
                Points.Text = Convert.ToString(PointsInt);
                textRemove10.BackColor = Color.Green;
            }
            else
            {
                textRemove10.BackColor = Color.Red;
            }
        }

        

        private void textAdd10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textRemove1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textAdd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textRemove10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Restart()
        {
            textAdd1.Text = "0";
            textRemove1.Text = "0";
            textAdd10.Text = "0";
            textRemove10.Text = "0";
            Points.Text = "0";
            textAdd1.BackColor = Color.White;
            textRemove1.BackColor = Color.White;
            textAdd10.BackColor = Color.White;
            textRemove10.BackColor = Color.White;
            PointsInt = 0;
            RNG();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}