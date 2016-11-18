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
    public partial class Parameter_adder : Form
    {
        public Parameter INSERT_PARAMETER;
        public Parameter_adder()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Name_Box.Text == "")
            {
                MessageBox.Show("Input parameter name");
                return;
            }
            if (Expr_Box.Text == "")
            {
                MessageBox.Show("Input expression");
                return;
            }
            if (Expr_Box.Text == Name_Box.Text)
            {
                MessageBox.Show("Parameter and expression are same");
                return;
            }
            this.INSERT_PARAMETER = new Parameter(Expr_Box.Text);
            this.INSERT_PARAMETER.Name = Name_Box.Text;
            this.Close();
        }
    }
}
