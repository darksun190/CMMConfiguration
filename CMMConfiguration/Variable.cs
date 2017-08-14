using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration
{
    class Variable
    {
        public delegate void VariableChangedHandler(object sender, EventArgs e);
        public static event VariableChangedHandler VariableChanged;

        public string Project_Name
        {
            get;
            set;
        }

    }
   
}
