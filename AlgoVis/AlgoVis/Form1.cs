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
        List<NodeLib.Node> lst = new List<NodeLib.Node>();
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NodeLib.Node baa = new NodeLib.Node();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NodeLib.Node ne = new NodeLib.Node();
            lst.Add(ne);
            lst.ElementAt(i).Data = textBox1.Text;
            lst.ElementAt(i).Top = 80;
            lst.ElementAt(i).Left = i*80;
            textBox1.Text = "";
            this.Controls.Add(lst.ElementAt(i));
            i++;
        }

        private void node2_Load(object sender, EventArgs e)
        {
            
        }

    }

    
}
