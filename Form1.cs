using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asinc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HideStartForm()
        {
            this.Controls.Clear();
        }

        private void ShowStartForm()
        {
            this.Controls.Add(CharGenerator);
            this.Controls.Add(CopyBigFiles);
            this.Controls.Add(CopyDirectories);
        }
        private void CharGenerator_Click(object sender, EventArgs e)
        {
            HideStartForm();
            CharGeneratorClass exercise = new CharGeneratorClass(this);
        }
    }
}
