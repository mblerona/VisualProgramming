using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {

        public Scene Scene;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Width, this.Height);
            this.DoubleBuffered = true;
            StatusLabel.Text = $"Lines: 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddPoint(e.Location);
            Scene.UndoLines.Clear();
            updateStatus();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg= new ColorDialog(); 
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.Color = dlg.Color;
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            Scene.Thickness = 1;
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            Scene.Thickness = 2;
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Scene.Thickness = 3;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.CursorPoint = e.Location;
            Invalidate();
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Positioner = !Scene.Positioner;
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
        }


        private void updateStatus() {
            StatusLabel.Text = $"Lines : {Scene.Lines.Count}";
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Undo();
            Invalidate();
            updateStatus();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Redo();
            Invalidate();
            updateStatus();
        }
    }
}
