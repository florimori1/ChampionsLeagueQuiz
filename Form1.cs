using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeagueQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBestaetigen_Click(object sender, EventArgs e)
        {
            if (txtbxClubEingabe.Text == "Real")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2022.Visible = true;
                lbl2018.Visible = true;
                lbl2017.Visible = true;
                lbl2016.Visible = true;
                lbl2014.Visible = true;
                lbl2002.Visible = true;
                lbl2000.Visible = true;
                lbl1998.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Chelsea")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2021.Visible = true;
                lbl2012.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Bayern")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2020.Visible = true;
                lbl2013.Visible = true;
                lbl2001.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Liverpool")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2019.Visible = true;
                lbl2005.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Barca")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2015.Visible = true;
                lbl2011.Visible = true;
                lbl2009.Visible = true;
                lbl2006.Visible = true;
                lbl1992.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Inter")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2010.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Manchester")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2008.Visible = true;
                lbl1999.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Milan")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2007.Visible = true;
                lbl2003.Visible = true;
                lbl1994.Visible = true;
                lbl1990.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Porto")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl2004.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "BVB")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl1997.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Juve")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl1996.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Ajax")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl1995.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Marseille")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl1993.Visible = true;
                txtbxClubEingabe.Clear();
            }

            if (txtbxClubEingabe.Text == "Belgrad")
            {
                string eingabe = txtbxClubEingabe.Text;
                lbl1991.Visible = true;
                txtbxClubEingabe.Clear();
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
}
