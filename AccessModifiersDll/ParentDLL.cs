using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDll
{
    public class ParentDLL
    {
        private string stringmod;
        public ParentDLL()
        {
            stringmod = "This is my class modifier in the dll";
        }

        protected internal string GetStringInternal()
        {
            return stringmod;
        }
        //Virtual 
        public virtual string GetStringPublic()
        {
            return stringmod;
        }
    }
}
