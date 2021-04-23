﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor = Color.FromArgb(255, 232, 232);
        Color panMaleColor = Color.FromArgb(255, 255, 0);
        Color panFemaleColor = Color.FromArgb(0, 255, 255);

        private void label2_Click(object sender, EventArgs e)
        {
            


        }
        //Thu cac event lam viec voi Mouse
        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalColor;
            labelTotal.ForeColor = Color.White;          
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.White;
            panelTotal.BackColor = panTotalColor;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = panFemaleColor;
            labelMale.ForeColor = Color.White;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            labelMale.ForeColor = Color.White;
            panelMale.BackColor = panMaleColor;
            
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = panFemaleColor;
            labelFemale.ForeColor = Color.White;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            labelFemale.ForeColor = Color.White;
            panelFemale.BackColor = panFemaleColor;
           
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            //get panels color
            panelTotal.BackColor = panTotalColor;
            panelMale.BackColor = panMaleColor;
            panelFemale.BackColor = panFemaleColor;
            

            //display the values
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalStudentMale());
            double totalFemale = Convert.ToDouble(student.totalStudentFemale());


            //tinh % 
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentPercentage = (totalFemale * (100 / total));

            labelTotal.Text = ("Total Students: " + total.ToString());
            labelMale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "% "));
            labelFemale.Text = ("Female: " + (femaleStudentPercentage.ToString("0.00") + "% "));
           
        }
    }
}
