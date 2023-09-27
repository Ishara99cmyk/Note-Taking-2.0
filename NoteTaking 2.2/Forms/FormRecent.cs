using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfiumViewer;

namespace NoteTaking_2._2.Forms
{
    public partial class FormRecent : Form
    {
        public FormRecent()
        {
            InitializeComponent();
        }

        private void OpenPdf_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog = new OpenFileDialog();
             if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = openFileDialog.FileName;
            }
        }

        private void FormRecent_Load(object sender, EventArgs e)
        {

        }
    }
}
