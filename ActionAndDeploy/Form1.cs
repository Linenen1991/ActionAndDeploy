using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionAndDeploy
{

    public partial class Form1 : Form
    {
        IStack<string> Stacker;
        IChange<string> Changer;

        public Form1()
        {
            InitializeComponent();
            Stacker = new StackImp<string>();
            Changer = new ChangeListBox<string>(listbox_Stack);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_AddItem.Text == "")
                return;
            Stacker.Push(tb_AddItem.Text);
            Changer.Addition(tb_AddItem.Text);
        }

        private void btn_Pop_Click(object sender, EventArgs e)
        {
            Stacker.Pop();
            Changer.Remove();
        }
    }
}
