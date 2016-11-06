using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ControlOperationsWinForms
{
    public partial class Form1 : Form
    {

        ListBox lb = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;

            t.Tick += (s, eventargs) =>
            {
                if (actionAfterseconds-- == 0)
                {
                    createListbox();
                    t.Stop();
                    t.Dispose();
                    Invoke(new Action(() => txtCountownTimer.Text = "--"));
                   

                }
                else
                {
                    Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));
                }

            };

            t.Start();
            Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));

        }

        private void createListbox()
        {
            lb = new ListBox();
            this.Controls.Add(lb);
            lb.AccessibleName = "DynamicListbox";
            lb.Name = "DynamicListbox";
            lb.Enabled = false;
            lb.Top = 35;
            lb.Left = 150;
            lb.Height = 150;
            lb.Width = 100;

            lb.Items.Add("Red");
            lb.Items.Add("Green");
            lb.Items.Add("Yellow");
            lb.Items.Add("Blue");

            lb.SelectedIndex = 1;

            lb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;
            t.Tick += (s, eventargs) =>
            {
                if (actionAfterseconds-- == 0)
                {

                    lb.Enabled = true;

                    t.Stop();
                    t.Dispose();
                    Invoke(new Action(() => txtCountownTimer.Text = "--"));
                   
                }
                else
                {
                    Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));
                }


            };
            Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));

            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;
            t.Tick += (s, eventargs) =>
            {
                if (actionAfterseconds-- == 0)
                {

                    this.Controls.Remove(lb);
                    lb.Dispose();
                    lb = null;
                    t.Stop();
                    t.Dispose();
                    Invoke(new Action(() => txtCountownTimer.Text = "--"));
                   
                }
                else
                {
                    Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));
                }

            };
            Invoke(new Action(() => txtCountownTimer.Text = actionAfterseconds.ToString()));

            t.Start(); 
        }


    }
}
