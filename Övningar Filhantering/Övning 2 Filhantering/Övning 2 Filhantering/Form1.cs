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

namespace Övning_2_Filhantering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)

        {
            
        }

        private void buttonViewFiles_Click(object sender, EventArgs e)
        {
            string folder = textBoxSource.Text;
            string[] txtFiles = Directory.GetFiles(folder);
            //listBoxFiles.Items.AddRange(txtFiles);

            for (int i = 0; i < txtFiles.Length; i++)
            {
                listBoxFiles.Items.Add(Path.GetFileName(txtFiles[i]));
            }

        }

        private void textBoxWriter_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string folder = textBoxSource.Text + "\\" + listBoxFiles.Text;
            using (StreamWriter saveToFile = new StreamWriter(folder))
            {
                saveToFile.WriteLine(textBoxWriter.Text);
                saveToFile.Close();
            }
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            

            string folder = textBoxSource.Text + "\\" + listBoxFiles.Text;
            using (FileStream fileStream = File.OpenRead(folder))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string fileContent = streamReader.ReadToEnd();

                textBoxWriter.Text = fileContent;

        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
