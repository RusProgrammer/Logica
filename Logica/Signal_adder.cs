using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class Signal_adder : Form
    {
        public Signal INSERT_SIGNAL;
        public Signal_adder()
        {
            InitializeComponent();
            TYPE_Field.SelectedIndex = 0;
        }

        private void TYPE_Field_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TYPE_Field.Text)
            {
                case "BOOL":
                {
                    //hide and off the msb field
                    MSB_Field.Text = "";
                    MSB_Field.Enabled = false;
                    MSB_Field.Visible = false;

                    //hide and off the lsb field
                    LSB_Field.Text = "";
                    LSB_Field.Enabled = false;
                    LSB_Field.Visible = false;

                    //hide and off the weight field
                    Weight_Field.Text = "";
                    Weight_Field.Enabled = false;
                    Weight_Field.Visible = false;

                    //hide and off the min field
                    Min_Field.Text = "";
                    Min_Field.Enabled = false;
                    Min_Field.Visible = false;

                    //hide and off the max field
                    Max_Field.Text = "";
                    Max_Field.Enabled = false;
                    Max_Field.Visible = false;

                    //hide and off the values field
                    Values_Field.Text = "";
                    Values_Field.Enabled = false;
                    Values_Field.Visible = false;
                    break;                  
                }
                case "INT":
                {
                    //show and on the msb field
                    MSB_Field.Text = "Enter the MSB value here";
                    MSB_Field.Enabled = true;
                    MSB_Field.Visible = true;

                    //show and on the lsb field
                    LSB_Field.Text = "Enter the LSB value here";
                    LSB_Field.Enabled = true;
                    LSB_Field.Visible = true;

                    //show and on the weight field
                    Weight_Field.Text = "Enter the Weight value here";
                    Weight_Field.Enabled = true;
                    Weight_Field.Visible = true;

                    //hide and off the min field
                    Min_Field.Text = "";
                    Min_Field.Enabled = false;
                    Min_Field.Visible = false;

                    //hide and off the max field
                    Max_Field.Text = "";
                    Max_Field.Enabled = false;
                    Max_Field.Visible = false;

                    //hide and off the values field
                    Values_Field.Text = "";
                    Values_Field.Enabled = false;
                    Values_Field.Visible = false;
                    break;
                }
                case "REAL":
                {
                    //show and on the msb field
                    MSB_Field.Text = "Enter the MSB value here";
                    MSB_Field.Enabled = true;
                    MSB_Field.Visible = true;

                    //show and on the lsb field
                    LSB_Field.Text = "Enter the LSB value here";
                    LSB_Field.Enabled = true;
                    LSB_Field.Visible = true;

                    //show and on the weight field
                    Weight_Field.Text = "Enter the Weight value here";
                    Weight_Field.Enabled = true;
                    Weight_Field.Visible = true;

                    //hide and off the min field
                    Min_Field.Text = "";
                    Min_Field.Enabled = false;
                    Min_Field.Visible = false;

                    //hide and off the max field
                    Max_Field.Text = "";
                    Max_Field.Enabled = false;
                    Max_Field.Visible = false;

                    //hide and off the values field
                    Values_Field.Text = "";
                    Values_Field.Enabled = false;
                    Values_Field.Visible = false;
                    break;
                }
                case "RANGE":
                {
                    //show and on the msb field
                    MSB_Field.Text = "Enter the MSB value here";
                    MSB_Field.Enabled = true;
                    MSB_Field.Visible = true;

                    //show and on the lsb field
                    LSB_Field.Text = "Enter the LSB value here";
                    LSB_Field.Enabled = true;
                    LSB_Field.Visible = true;

                    //show and on the weight field
                    Weight_Field.Text = "Enter the Weight value here";
                    Weight_Field.Enabled = true;
                    Weight_Field.Visible = true;

                    //show and on the min field
                    Min_Field.Text = "Enter the Min value here";
                    Min_Field.Enabled = true;
                    Min_Field.Visible = true;

                    //show and on the max field
                    Max_Field.Text = "Enter the Max value here";
                    Max_Field.Enabled = true;
                    Max_Field.Visible = true;

                    //hide and off the values field
                    Values_Field.Text = "";
                    Values_Field.Enabled = false;
                    Values_Field.Visible = false;
                    break;
                }
                case "ENUM":
                {
                    //hide and off the msb field
                    MSB_Field.Text = "";
                    MSB_Field.Enabled = false;
                    MSB_Field.Visible = false;

                    //hide and off the lsb field
                    LSB_Field.Text = "";
                    LSB_Field.Enabled = false;
                    LSB_Field.Visible = false;

                    //hide and off the weight field
                    Weight_Field.Text = "";
                    Weight_Field.Enabled = false;
                    Weight_Field.Visible = false;

                    //hide and off the min field
                    Min_Field.Text = "";
                    Min_Field.Enabled = false;
                    Min_Field.Visible = false;

                    //hide and off the max field
                    Max_Field.Text = "";
                    Max_Field.Enabled = false;
                    Max_Field.Visible = false;

                    //hide and off the values field
                    Values_Field.Text = "Value1, Value2...";
                    Values_Field.Enabled = true;
                    Values_Field.Visible = true;
                    break;
                }
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (Name_Field.Text == "")
            {
                MessageBox.Show("Enter the signal name");
                return;
            }
            switch (TYPE_Field.Text)
            {
                case "BOOL":
                {
                    INSERT_SIGNAL = new Signal();
                    INSERT_SIGNAL.Values = new List<string>();
                    INSERT_SIGNAL.Name = Name_Field.Text;
                    INSERT_SIGNAL.Values.Add("true");
                    INSERT_SIGNAL.Values.Add("false");
                    break;
                }
                case "INT":
                    {
                        break;
                    }
                case "REAL":
                    {
                        break;
                    }
                case "RANGE":
                    {
                        break;
                    }
                case "ENUM":
                    {
                        break;
                    }
            }
            this.Close();
        }
    }
}
