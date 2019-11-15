using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccessModifiers
{
    public class Parent
    {
        string ParentMethod()
        {
            return "Method Called In Property";
        }
        string ParentProperty()
        {
            return "Property Called In Method";
        }

        public string ParentMethodPublic()
        {
            return "Method Called In Property";
        }
        public string ParentPropertyPublic()
        {
            return "Property Called In Method";
        }
        //GetName
        private string parentstring;

        public string GetName
        {
            get { return parentstring; }
            set { parentstring = value; }
        }

        public Parent()
        {
            parentstring = "Parent Constructor Called";
        }
        //Protection
        protected string ParentMethodProtected()
        {
            return "Protected Method Called in Parent";
        }


    }
}
