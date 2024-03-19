using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Pooya
{
    public partial class AnalyzeForm : Form
    {
        public int How_Many_word =0;
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            WordsBox.Text = How_Many_word.ToString();
        }
    }
}
