namespace NodeLib
{
    partial class Node
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.NodeBox = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lblNodeData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.NodeBox});
            this.shapeContainer1.Size = new System.Drawing.Size(50, 50);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // NodeBox
            // 
            this.NodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NodeBox.Location = new System.Drawing.Point(0, 0);
            this.NodeBox.Name = "NodeBox";
            this.NodeBox.Size = new System.Drawing.Size(49, 49);
            // 
            // lblNodeData
            // 
            this.lblNodeData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNodeData.AutoEllipsis = true;
            this.lblNodeData.Location = new System.Drawing.Point(-23, -20);
            this.lblNodeData.Name = "lblNodeData";
            this.lblNodeData.Size = new System.Drawing.Size(93, 90);
            this.lblNodeData.TabIndex = 1;
            this.lblNodeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.lblNodeData);
            this.Name = "Node";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape NodeBox;
        private System.Windows.Forms.Label lblNodeData;
    }
}
