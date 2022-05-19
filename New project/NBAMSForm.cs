
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NBAMSForm : Form
    {
        String[] imgList = new String[] {"0.jpg","1.jpg", "2.jpg", "3.jpg","4.jpg","5.jpg","6.jpg", "7.jpg", "8.jpg", "9.jpg" };
        Country[] countries = new Country[5];
        //Team[] teams = new Team[5];

        int index = 0,number_picturbox=3;

        public NBAMSForm()
        {
            InitializeComponent();
            Country country = new Country();
            country.setCountryCode("MIR");
            country.setCountryName("Australia");
            countries[0] = country;

            country.setCountryCode("ORL");
            country.setCountryName("Argentina");
            countries[1] = country;

            country.setCountryCode("ATL");
            country.setCountryName("Austria");
            countries[2] = country;

            country.setCountryCode("WSH");
            country.setCountryName("Australia");
            countries[3] = country;

            country.setCountryCode("CHA");
            country.setCountryName("Bosnia");
            countries[4] = country;



            /*
            Team team = new Team();
            team.SetTeamAll(1, "Miami Heat", "MIA", "1.jpg");
            teams[0] = team;
            team.SetTeamAll(2, "Orlando Magic", "ORL", "2.jpg");
            teams[1] = team;
            team.SetTeamAll(3, "Atlanta Hawks", "ATL", "3.jpg");
            teams[2] = team;
            team.SetTeamAll(4, "Washington Wizards", "WSH", "4.jpg");
            teams[3] = team;
            team.SetTeamAll(5, "Charlotte Hornets", "CHA", "5.jpg");
            teams[4] = team;
            */

            pictureBox2.Load("../../picture/" + imgList[0]);
            pictureBox4.Load("../../picture/" + imgList[1]);
            pictureBox3.Load("../../picture/" + imgList[2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new AdminForm();
            adminForm.Show();  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                 index = imgList.Length- number_picturbox;
            }
            pictureBox2.Load("../../picture/" + imgList[index+0]);
            pictureBox4.Load("../../picture/" + imgList[index + 1]);
            pictureBox3.Load("../../picture/" + imgList[index + 2]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index++;
            if (index+ number_picturbox > imgList.Length)  // Length размер массива 
            {
                index = 0;
            }
            pictureBox2.Load("../../picture/" + imgList[index + 0]);
            pictureBox4.Load("../../picture/" + imgList[index +1]);
            pictureBox3.Load("../../picture/" + imgList[index + 2]);
        }
    }
}
