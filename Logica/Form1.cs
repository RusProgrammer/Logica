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
        List<Parameter> Parameter_Pool = new List<Parameter>();
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
            Parameter a = new Parameter("(A | B) & (A | C)");
            var r=  a.SetTrue();
            
            InitializeComponent();

        }

        private void добавитьПараметрToolStripMenuItem_Click(object sender, EventArgs e)
        {                     
            if (Parameters_Browser.SelectedNode == null)
            {
                Parameter_adder Add_Wnd = new Parameter_adder();
                Add_Wnd.ShowDialog();  

                TreeNode Node_To_Add = new TreeNode(Add_Wnd.INSERT_PARAMETER.Name);
                Node_To_Add.Text = Add_Wnd.INSERT_PARAMETER.Name;
                Node_To_Add.Nodes.Add(Add_Wnd.INSERT_PARAMETER.Expr);
                Node_To_Add.Nodes[0].Text = Add_Wnd.INSERT_PARAMETER.Expr;

                Parameters_Browser.BeginUpdate();
                Parameters_Browser.Nodes.Add(Node_To_Add);
                Parameters_Browser.EndUpdate();

                Parameter_Pool.Add(Add_Wnd.INSERT_PARAMETER);
            }
            else
            {
                
                var Finder = Check_field_type(Parameter_Pool, Parameters_Browser.SelectedNode.Text);
                if (Finder == false)
                {
                    Parameter_adder Add_Wnd = new Parameter_adder();
                    Add_Wnd.ShowDialog();
                    TreeNode Node_To_Add = new TreeNode(Add_Wnd.INSERT_PARAMETER.Name);
                    Node_To_Add.Text = Add_Wnd.INSERT_PARAMETER.Name;
                    Node_To_Add.Nodes.Add(Add_Wnd.INSERT_PARAMETER.Expr);
                    Node_To_Add.Nodes[0].Text = Add_Wnd.INSERT_PARAMETER.Expr;

                    Parameters_Browser.BeginUpdate();
                    Parameters_Browser.SelectedNode.Nodes.Add(Node_To_Add);
                    Parameters_Browser.EndUpdate();

                    Parameter_Pool.Add(Add_Wnd.INSERT_PARAMETER);
                }
            }
        }

        private void добавитьСигналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Parameters_Browser.SelectedNode == null)
            {
                
            }
            else
            {
                var Finder = Check_field_type(Parameter_Pool, Parameters_Browser.SelectedNode.Text);
                if (Finder == false)
                {
                    Signal_adder Add_Wnd = new Signal_adder();
                    Add_Wnd.ShowDialog();
                    TreeNode Node_To_Add = new TreeNode(Add_Wnd.INSERT_SIGNAL.Name);
                    Node_To_Add.Text = Add_Wnd.INSERT_SIGNAL.Name;

                    Parameters_Browser.BeginUpdate();
                    Parameters_Browser.SelectedNode.Nodes.Add(Node_To_Add);
                    Parameters_Browser.EndUpdate();

                    var Param_Node = Parameter_Pool.Find(x => x.Name == Parameters_Browser.SelectedNode.Text);
                    if (Param_Node.Signals == null)
                        Param_Node.Signals = new List<Signal>();
                    Param_Node.Signals.Add(Add_Wnd.INSERT_SIGNAL);
                }
            }
        }

        private bool Check_field_type(List <Parameter> paramss, string srch)
        {
            bool RetVal = false;
            foreach (var pp in paramss)
            {
                if (pp.Expr == srch)
                {
                    return true;
                }
                if (pp.Signals != null)
                {
                    foreach (var _sign in pp.Signals)
                    {
                        if (_sign.Name == srch)
                        {
                            return true;
                        }
                    }
                }
                if (pp.Parameters!=null)
                {
                    RetVal = Check_field_type(pp.Parameters,srch);
                }
            }
            return RetVal;
        }

        private void Parameters_Browser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e != null)
            {
                Parameters_Browser.SelectedNode = e.Node;
            }
            else
            {
                Parameters_Browser.SelectedNode = null;
            }
        }




    }
}
