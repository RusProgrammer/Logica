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
    public partial class Form1 : Form
    {
        public enum TYPE
        {
            BOOL,
            INT,
            REAL,
            RANGE,
            ENUM
        }
        public Form1()
        {
            Parameter a = new Parameter();
            
            InitializeComponent();
        }
    }
}
