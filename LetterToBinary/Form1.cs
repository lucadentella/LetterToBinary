using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LetterToBinary
{
    public partial class Form1 : Form
    {

        private Label[] cells;

        public Form1()
        {
            InitializeComponent();

            // create cells grid
            cells = new Label[40];
            for (int i = 0; i < 5; i++)
                for(int j = 0; j < 8; j++)
                {
                    Label label = new Label();
                    label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    label.Location = new System.Drawing.Point(12 + (21 * i), 9 + (21 * j));
                    label.Size = new System.Drawing.Size(15, 15);
                    label.TabIndex = (8 * i) + j;
                    label.Click += new System.EventHandler(this.cell_Click);
                    this.Controls.Add(label);
                    cells[(8 * i) + j] = label;
                }
        }

        // on click, change cell's color (black->white and white->black)
        private void cell_Click(object sender, EventArgs e)
        {
            Label source = (Label)sender;
            if (source.BackColor == Color.Black) source.BackColor = SystemColors.Control;
            else source.BackColor = Color.Black;
            convert();
        }

        // all whites
        private void btWhite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++) cells[i].BackColor = SystemColors.Control;
            convert();
        }

        // all blacks
        private void btBlack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++) cells[i].BackColor = Color.Black;
            convert();
        }

        // copy to clipboard
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOut.Text);
        }

        // Convert cells' color to binary values
        private void convert()
        {
            tbOut.Clear();
            
            for(int i = 0; i < 5; i++)
            {
                
                StringBuilder lineValue = new StringBuilder();
                lineValue.Append('B');

                bool allWhite = true;
                for (int j = 0; j < 8; j++)
                {
                    Label actualLabel = cells[(8 * i) + j];
                    char value = '0';
                    if (actualLabel.BackColor == Color.Black)
                    {
                        value = '1';
                        allWhite = false;
                    }
                    lineValue.Append(value);
                }

                if (allWhite) break;
                lineValue.Append(',' + Environment.NewLine);
                tbOut.AppendText(lineValue.ToString());
            }

            tbOut.SelectionStart = 0;
            tbOut.ScrollToCaret();
        }
    }
}
