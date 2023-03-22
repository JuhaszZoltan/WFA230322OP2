using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230322OP2
{
    public partial class UscImport : UserControl
    {
        public UscImport()
        {
            InitializeComponent();
            btnImport.Click += OnBtnImportClick;
        }

        private void OnBtnImportClick(object? sender, EventArgs e)
        {
            OpenFileDialog odf = new();
            odf.ShowDialog();
        }
    }
}
