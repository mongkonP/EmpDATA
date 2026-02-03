using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpDATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.tblShift' table. You can move, or remove it, as needed.
          



        }

        private void tblShiftBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblShiftBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);
            this.tblShiftTableAdapter.Fill(this.dB.tblShift);

        }
    }
}
