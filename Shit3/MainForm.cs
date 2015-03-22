using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shit3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FillInWordsOfChoice();
        }

        private void FillInWordsOfChoice()
        {
            var words = System.IO.File.ReadLines("words.txt");

            foreach (var w in words)
            {
                this.comboBoxWordsOfChoice.Items.Add(w);
            }

            this.comboBoxWordsOfChoice.Text = "test";
        }
    }
}
