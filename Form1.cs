namespace WFA230322OP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mitImport.Click += OnMitImportClick;
        }

        private void OnMitImportClick(object? sender, EventArgs e)
        {
            pnlMain.Controls.Add(new UscImport());
        }
    }
}