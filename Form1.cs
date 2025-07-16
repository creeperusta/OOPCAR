using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Viewcars_Click(object sender, EventArgs e)
        {
            toyota.Visible = true;
            Honda.Visible = false;
            Ford.Visible = false;
            car car1 = new car();
            car1.carcolor = "Red";
            car1.carmodel = "Toyota";
            car1.cardate = "1960";
            car1.cargear = "Automatic";
            string cars = car1.carfull();
            CARCOLOR_TEXT.Text = car1.carcolor;
            CARMODEL_TEXT.Text = car1.carmodel;
            CARDATE_TEXT.Text = car1.cardate;
            CARGEAR_TEXT.Text = car1.cargear;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toyota.Visible = false;
            Honda.Visible = false;
            Ford.Visible = false;
        }

        private void twoviemcars_Click(object sender, EventArgs e)
        {
            Honda.Visible=true;
            toyota.Visible = false;
            Ford.Visible = false;
            car car2 = new car();
            car2.carcolor = "Blue";
            car2.carmodel = "Honda";
            car2.cardate = "1965";
            car2.cargear = "Manual";
            string cars = car2.carfull();
            CARCOLOR_TEXT.Text = car2.carcolor;
            CARMODEL_TEXT.Text = car2.carmodel;
            CARDATE_TEXT.Text = car2.cardate;
            CARGEAR_TEXT.Text = car2.cargear;
        }

        private void CARSVİEM2_Click(object sender, EventArgs e)
        {
            Ford.Visible = true;
            toyota.Visible = false;
            Honda.Visible = false;
            car car3 = new car();
            car3.carcolor = "Black";
            car3.carmodel = "Ford";
            car3.cardate = "1940";
            car3.cargear = "Manuel";
            string cars = car3.carfull();
            CARCOLOR_TEXT.Text = car3.carcolor;
            CARMODEL_TEXT.Text = car3.carmodel;
            CARDATE_TEXT.Text = car3.cardate;
            CARGEAR_TEXT.Text = car3.cargear;
        }
    }
}
