using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class IExpression
    {
        public string Expr;
        public abstract List<string> SetTrue();
        public abstract List<string> SetFalse();
    }
}
