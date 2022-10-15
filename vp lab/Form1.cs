using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            custom();
        }
        public void custom()
        {
            studentDetailsPanel.Visible = false;
            enterMarksPanel.Visible = false;
            resultPanel.Visible = false;
            subjectDetailsPanel.Visible = false;
            startpanel.Visible = true;
        }
        public void hide()
        {
            if (studentDetailsPanel.Visible == true)
                studentDetailsPanel.Visible = false;
            if (subjectDetailsPanel.Visible == true)
                subjectDetailsPanel.Visible = false;
            if (enterMarksPanel.Visible == true)
                enterMarksPanel.Visible = false;
            if (resultPanel.Visible == true)
                resultPanel.Visible = false;
            if (startpanel.Visible == true)
                startpanel.Visible = false;

        }
        public void show(Panel child)
        {
            if(child.Visible == false)
            {
                hide();
                child.Visible = true;

            }
            else
            {
                child.Visible = false;
            }
        }















        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }



        private void changesub()
        {
            mark1lb.Text = "Marks in "+s1Tb.Text;
            mark2lb.Text = "Marks in " + s2tb.Text;
            mark3lb.Text = "Marks in " + s3tb.Text;
            mark4lb.Text = "Marks in " + s4tb.Text;
            mark5lb.Text = "Marks in " + s5tb.Text;
            finalresult.Text = " Click calculate to see output ";

        }
        private int credits()
        {
            int credit = 0;
            credit = Convert.ToInt32(s1cb.SelectedItem) + Convert.ToInt32(s2cb.SelectedItem) + Convert.ToInt32(s3cb.SelectedItem) + Convert.ToInt32(s4cb.SelectedItem) + Convert.ToInt32(s5cb.SelectedItem);
            return credit;

        }
       
        private void calculate()
        {
            try
            {
                s1show.Text = "GPA in " + s1Tb.Text + " is " + Convert.ToString(subGpa(Convert.ToDouble(m1.Text), Convert.ToInt32(s1cb.SelectedItem)));
                s2show.Text = "GPA in " + s2tb.Text + " is " + Convert.ToString(subGpa(Convert.ToDouble(m2.Text), Convert.ToInt32(s2cb.SelectedItem)));
                s3show.Text = "GPA in " + s3tb.Text + " is " + Convert.ToString(subGpa(Convert.ToDouble(m3.Text), Convert.ToInt32(s3cb.SelectedItem)));
                s4show.Text = "GPA in " + s4tb.Text + " is " + Convert.ToString(subGpa(Convert.ToDouble(m4.Text), Convert.ToInt32(s4cb.SelectedItem)));
                s5show.Text = "GPA in " + s5tb.Text + " is " + Convert.ToString(subGpa(Convert.ToDouble(m5.Text), Convert.ToInt32(s5cb.SelectedItem)));
            }
            catch (FormatException)
            {

            }
            
        }

        private double subGpa(double m, int c)
        {
            double subgp = 0;
            try
            {
                if (m >= 90 && m <= 100)
                { subgp = c * 4.0; }
                else if (m >= 85 && m <= 89)
                { subgp = c * 3.7; }
                else if (m >= 80 && m <= 84)
                { subgp = c * 3.3; }
                else if (m >= 75 && m <= 79)
                { subgp = c * 3.0; }
                else if (m >= 70 && m <= 74)
                { subgp = c * 2.7; }
                else if (m >= 65 && m <= 69)
                { subgp = c * 2.3; }
                else if (m >= 60 && m <= 64)
                { subgp = c * 2.0; }
                else if (m >= 55 && m <= 59)
                { subgp = c * 1.7; }
                else if (m >= 50 && m <= 54)
                { subgp = c * 1.3; }
                else if (m >= 0 && m < 50)
                { subgp = 0; }
                else
                { MessageBox.Show("Pls enter Number 0 - 100"); }
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROROR");
            }
            total = total + subgp;
            return subgp;
            


            
        }
        private void studentdetailsbtn_Click(object sender, EventArgs e)
        {
            show(studentDetailsPanel);
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            first.BackColor = System.Drawing.Color.Gray;
            second.BackColor = System.Drawing.Color.Gray;
            subdetailsbtn.ForeColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();

        }

        private void subdetailsbtn_Click(object sender, EventArgs e)
        {
            show(subjectDetailsPanel);
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            second.BackColor = System.Drawing.Color.Gray;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            show(enterMarksPanel);
            changesub();
            calculate();
            second.BackColor = System.Drawing.Color.RoyalBlue;
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            marksbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void resultbtn_Click(object sender, EventArgs e)
        {
            show(resultPanel);
            third.BackColor = System.Drawing.Color.RoyalBlue;
            resultbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            second.BackColor = System.Drawing.Color.RoyalBlue;
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            marksbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            changesub();

            // display data


        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            show(studentDetailsPanel);
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            first.BackColor = System.Drawing.Color.Gray;
            second.BackColor = System.Drawing.Color.Gray;
            subdetailsbtn.ForeColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void marksnextbtn_Click(object sender, EventArgs e)
        {
            show(resultPanel);
            calculate();
            third.BackColor = System.Drawing.Color.RoyalBlue;
            resultbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            second.BackColor = System.Drawing.Color.RoyalBlue;
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            marksbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            changesub();
        }

        private void marksprevbtn_Click(object sender, EventArgs e)
        {
            show(subjectDetailsPanel);
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            second.BackColor = System.Drawing.Color.Gray;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void subdetailbtn_Click(object sender, EventArgs e)
        {
            show(enterMarksPanel);
            changesub();
            second.BackColor = System.Drawing.Color.RoyalBlue;
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            marksbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show(studentDetailsPanel);
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            first.BackColor = System.Drawing.Color.Gray;
            second.BackColor = System.Drawing.Color.Gray;
            subdetailsbtn.ForeColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void stuDetailsBtn_Click(object sender, EventArgs e)
        {
            show(subjectDetailsPanel);
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            second.BackColor = System.Drawing.Color.Gray;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            marksbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();
        }

        private void resultprevbtn_Click(object sender, EventArgs e)
        {
            show(enterMarksPanel);
            second.BackColor = System.Drawing.Color.RoyalBlue;
            first.BackColor = System.Drawing.Color.RoyalBlue;
            studentdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            subdetailsbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            marksbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            third.BackColor = System.Drawing.Color.Gray;
            resultbtn.ForeColor = System.Drawing.Color.Gray;
            changesub();


        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                finalresult.Text = snametb.Text + " your GPA is " + Convert.ToString(Math.Round(total / credits(),3));
                total = 0;
                
            }
            
            catch (FormatException)
            {

            }
            
        }
    }
}
