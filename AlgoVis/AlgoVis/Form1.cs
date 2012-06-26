using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoVis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }
    }

    private partial class Node : Microsoft.VisualBasic.PowerPacks.OvalShape
    {
        #region "Constructor"
        public Node()
        {

        }
        #endregion
    }
}
