using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration
{
    static class Variable
    {
        public delegate void VariableChangedHandler(object sender, VariableChangedEventArgs e);
        public static event VariableChangedHandler VariableChanged;

        static string project_name;
        public static string Project_Name
        {
            get
            {
                return project_name;
            }
            set
            {
                string old_value = project_name;
                project_name = value;
                VariableChanged(Variable.Project_Name, new VariableChangedEventArgs(old_value, value));
            }
        }

    }
    public class VariableChangedEventArgs : EventArgs
    {
        public Type Type
        {
            get;
            private set;
        }
        public object old_value
        {
            get;
            private set;
        }
        public object new_value
        {
            get;
            private set;
        }
        public VariableChangedEventArgs(object old,object n)
        {
            Type = n.GetType();
            old_value = old;
            new_value = n;
        }
    }
}
