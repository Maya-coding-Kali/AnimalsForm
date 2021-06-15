using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnimalsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal.Frog AFrog = new Animal.Frog ("Tom", "Yellow");
            Animal.Cat ACat = new Animal.Cat ("Zorro", "White",2);
            richTextBox1.Text = "Your Frog " + AFrog.GetName()+"\n";
            richTextBox1.Text = richTextBox1.Text + "is still " + AFrog.GetColor() + "\n";

            richTextBox1.Text = richTextBox1.Text + "Your Cat " + ACat.GetName() + "\n";
            richTextBox1.Text = richTextBox1.Text + "is still " + ACat.GetColor() + "\n";
            richTextBox1.Text = richTextBox1.Text + "is still " + ACat.GetAge() + "\n";




        }
    }
}
