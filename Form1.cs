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

namespace Test_Pooya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(!Directory.Exists(Application.StartupPath + "/saves/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/saves/");
                
            }
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
                var textValue = textBox1.Text;              

                SaveFileDialog SaveFile = new SaveFileDialog();
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(SaveFile.FileName, textValue);
                    MessageBox.Show("با موفقیت ثبت شد ", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text=File.ReadAllText(OpenFile.FileName);
                
            }
      
        }

        private void AnalyzeBtn_Click(object sender, EventArgs e)
        {
            int WordsInText = How_Many_word();
            AnalyzeForm Form = new AnalyzeForm();
            Form.How_Many_word = WordsInText;
            Form.ShowDialog();
        }

        private int How_Many_word()
        {
            var Textbox_Splited_Array = textBox1.Text.Trim().Split(' ');
            
            return Textbox_Splited_Array.Length;
        }

    }
}
