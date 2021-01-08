namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void myForm_Load(object sender, EventArgs e)
        {
            var files = Directory.EnumerateFiles(@"c:\");
            comboBox1.Items.AddRange(files.ToArray());

            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Once upon a midnight dreary, while I pondered, weak and weary," + Environment.NewLine +
"Over many a quaint and curious volume of forgotten lore—" + Environment.NewLine +
"    While I nodded, nearly napping, suddenly there came a tapping," + Environment.NewLine +
"As of some one gently rapping, rapping at my chamber door." + Environment.NewLine +
"“’Tis some visitor,” I muttered, “tapping at my chamber door—" + Environment.NewLine +
"            Only this and nothing more.”" + Environment.NewLine +
"" + Environment.NewLine +
"    Ah, distinctly I remember it was in the bleak December;" + Environment.NewLine +
"And each separate dying ember wrought its ghost upon the floor." + Environment.NewLine +
"    Eagerly I wished the morrow;—vainly I had sought to borrow" + Environment.NewLine +
"    From my books surcease of sorrow—sorrow for the lost Lenore—" + Environment.NewLine +
"For the rare and radiant maiden whom the angels name Lenore—" + Environment.NewLine +
"            Nameless here for evermore.";

                listBox1.Items.AddRange(new string[] { "Katt", "Hund", "Kapybara" });
                listBox1.Items.Add("Häst");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pos = textBox1.Text.IndexOf("sorrow");
            textBox1.Select(pos, 6);
            textBox1.Focus();
            //MessageBox.Show(textBox1.SelectedText);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                var items = "";
                foreach (var item in listBox1.SelectedItems)
                {
                    items += item + "\n";
                }
                MessageBox.Show(items);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex >= 0)
            //{
            //    MessageBox.Show(listBox1.SelectedItem.ToString());
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
    }

    public class Knapp:Button
    {
        public Knapp()
        {
            Text = "Min knapp";
            Location = new System.Drawing.Point(243, 60);
            Size = new System.Drawing.Size(75, 23);
            UseVisualStyleBackColor = true;
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        }
    }

}
