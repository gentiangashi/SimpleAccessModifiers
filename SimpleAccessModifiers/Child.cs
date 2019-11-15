using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccessModifiers
{
   class Child : Parent
    {
        public string ChildProperty
        {
            get { return "Property Called in Child"; }
        }
        public string ChildMethod()
        {
            return "Method Called in Child";
        }
        public Child()
        {
            base.GetName += " Child Constructor Called";
        }
        //Protection
        public string GetProtectedMethodFromParent()
        {
            return ParentMethodProtected();
        }


    }

}
