using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using DLL
using AccessModifiersDll;

namespace SimpleAccessModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate Parent Object
            Parent parent = new Parent();
            //Calling Parent
            AccessModifiersListBox.Items.Add(parent.ParentMethodPublic());
            AccessModifiersListBox.Items.Add(parent.ParentPropertyPublic());
            //Instantiate Child Object
            Child child = new Child();
            //Calling Child
            AccessModifiersListBox.Items.Add(child.ChildMethod());
            AccessModifiersListBox.Items.Add(child.ChildProperty);
            //Calling Child & Parent Names Using Child
            AccessModifiersListBox.Items.Add(child.GetName);
            //Calling Protected Method From Parent Using Child
            AccessModifiersListBox.Items.Add(child.GetProtectedMethodFromParent());

            //Instantiate ParentDLL Object
            ParentDLL parentDLL = new ParentDLL();
            //Calling ParentDLL
            AccessModifiersListBox.Items.Add(parentDLL.GetStringPublic());
            //Instantiate ChildDLL Object
            ChildDLL childDLL = new ChildDLL();
            //Calling Child & Overriding It
            AccessModifiersListBox.Items.Add(childDLL.GetStringPublic());
        }
    }
}
