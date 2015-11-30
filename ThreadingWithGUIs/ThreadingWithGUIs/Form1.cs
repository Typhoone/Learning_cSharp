using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingWithGUIs
{
   

    public partial class Form1 : Form
    {

        //Delegate sig
        public delegate void delTextBoxUpdate(string text);

        ThreadStart threadStart;
        Thread updateThread;


        public Form1()
        {
            InitializeComponent();
        }

        private void updateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threadStart = new ThreadStart(startThread);
            updateThread = new Thread(threadStart);
            updateThread.Name = "secondThread";

            updateThread.Start();

            new mouseControl(this.mousePos);

        }


        private void startThread()
        {
            delTextBoxUpdate updator = new delTextBoxUpdate(updateTextBox);
            for(int i = 0; i < 1000; i++)
            {
                this.updateBox.BeginInvoke(updator, i + "");
                Thread.Sleep(100);
            }
        }

        private void updateTextBox(string String)
        {
            this.updateBox.Text = String;
        }

        private void mousePos_Click(object sender, EventArgs e)
        {

        }
    }



    public class mouseControl
    {
        public delegate void delLableUpdate(string text);

        int ID;
        Thread t;
        Label label;

        public mouseControl(Label l)
        {
            ID = new Random().Next(1, 100000);
            t = new Thread(new ThreadStart(watchMouse));
            this.label = l;

            t.Start();
        }

        public void watchMouse()
        {
            delLableUpdate updator = new delLableUpdate(updateLabel);

            while (true)
            {
                this.label.BeginInvoke(updator, Cursor.Position.X + "," + Cursor.Position.Y);
                Thread.Sleep(10);
            }
        }

        public void updateLabel(string text)
        {
            this.label.Text = text;
        }
    }
}
