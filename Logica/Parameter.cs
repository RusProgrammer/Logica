using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Logica
{
    public class Parameter:IExpression
    {
        public string Name;
        public List<Parameter> Parameters;
        public List<Signal> Signals;

        public Parameter(string _EXPR)
        {
            this.Expr = _EXPR;
        }

        public override List<string> SetTrue()
        {
            List<string> Result = new List<string>();
            if (this.Parameters != null)
                foreach (var _PARAM in this.Parameters)
                {
                    Result.AddRange(_PARAM.SetTrue());
                }
            if (this.Signals != null)
                foreach (var _SIGN in this.Signals)
                {
                    switch (_SIGN.Type)
                    {
                        case Form1.TYPE.BOOL:
                            {

                                break;
                            }
                        case Form1.TYPE.ENUM:
                            {
                                break;
                            }
                        case Form1.TYPE.INT:
                            {
                                break;
                            }
                        case Form1.TYPE.RANGE:
                            {
                                break;
                            }
                        case Form1.TYPE.REAL:
                            {
                                break;
                            }
                    }
                }
            return null;
        }
        public override List<string> SetFalse()
        {
            List<string> Result = new List<string>();
            if (this.Parameters != null)
                foreach (var _PARAM in this.Parameters)
                {
                    Result.AddRange(_PARAM.SetFalse());
                }
            return null;
        }

        private void FindOperators(string _SIGN_NAME)
        {
            var Operands = Regex.Matches(this.Expr, @"\b\w+\b").OfType<Match>().Select(m => m.Value);
            
        }



    }
}
