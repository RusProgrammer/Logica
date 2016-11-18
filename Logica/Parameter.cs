using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Parameter:IExpression
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
            foreach (var _PARAM in this.Parameters)
            {
                Result.AddRange(_PARAM.SetTrue());
            }
            return null;
        }
        public override List<string> SetFalse()
        {
            return null;
        }


    }
}
