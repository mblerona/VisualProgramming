using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingBalls
{
    public partial class Form1 : Form
    {

        public Scene Scene;
        public Random Random= new Random();
        public int generateFrequency;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Width, this.Height);
            timer1.Start();
            this.DoubleBuffered = true;
            timer1.Interval = 100;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.HitBalls(e.Location);
            updateStatus();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public void updateStatus() {
            toolStripStatusLabel1.Text = $"Misses: {Scene.Misses}";
            toolStripStatusLabel2.Text = $"Hits: {Scene.Hits}";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Misses: {Scene.Misses}";
            toolStripStatusLabel2.Text = $"Hits: {Scene.Hits}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval %10 == 0)
            {
                
                Scene.addBall(new Ball(new Point(-Ball.RADIUS, Random.Next(2*Ball.RADIUS,Height - 4*Ball.RADIUS))));

            }
            Scene.Move();
            updateStatus();
            Invalidate();
        }

        private void pauseTool_Click(object sender, EventArgs e)
        {
            Scene.isPaused = !Scene.isPaused;
            if (Scene.isPaused)
            {
                timer1.Stop();
                pauseTool.Text = "Start";
            }
            else
            {
                timer1.Start();
                pauseTool.Text = "Pause";
            }

            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Width = Width;
            this.Height = Height;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(Width, Height);
            Invalidate();
        }


        private void saveScene(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(f, Scene);
            f.Close();

        }
        private void loadScene(string path)
        {
            FileStream f = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = formatter.Deserialize(f) as Scene;

            f.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadScene(openFileDialog.FileName);
            }
            else
            {
                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveScene(saveFileDialog.FileName);
            }
            else
            {
                this.Close();
            }
        }
    }
}
