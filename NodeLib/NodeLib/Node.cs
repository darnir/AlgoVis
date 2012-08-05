using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeLib
{
    public partial class Node: UserControl
    {
        private string strNodeData; // Store property value.
        //Create a new custom property for the Node to store its contents.
        public string Data
        {
            get 
            {
                return strNodeData;
            }
            set 
            {
                strNodeData = value;
                lblNodeData.Text = strNodeData;
            }
        }

        private Node parentNode;
        public Node Parent_Node
        {
            get
            {
                return parentNode;
            }
            set
            {
                parentNode = value;
            }
        }


        public Node()
        {
            InitializeComponent();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Force the resize to be proportional.
            base.SetBoundsCore(x, y, width, width, specified);
        }

    }
}
