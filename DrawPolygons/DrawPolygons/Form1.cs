using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPolygons
{
    public partial class Form1 : Form
    {

        public Polygon polygon;
        public Scene scene;

        public Form1()
        {
            InitializeComponent();
            polygon= new Polygon();
            this.DoubleBuffered = true;
            scene= new Scene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           scene.addPoint(e.Location);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.updateCursor(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void saveScene(string path) {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate) ;
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(f, scene);
            f.Close();
            
        }
        private void loadScene(string path) {
        FileStream f = new FileStream (path, FileMode.Open) ;
            IFormatter formatter = new BinaryFormatter();   
            scene= formatter.Deserialize(f) as Scene;

            f.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveScene(saveFileDialog.FileName);
            }
            else { 
            this.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
            loadScene(openFileDialog.FileName);
            }
            else
            {
                this.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }
    }
}
