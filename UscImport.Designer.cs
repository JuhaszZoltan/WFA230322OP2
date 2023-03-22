namespace WFA230322OP2
{
    partial class UscImport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImport = new Button();
            dgvEllenorzes = new DataGridView();
            colOM = new DataGridViewTextBoxColumn();
            colNev = new DataGridViewTextBoxColumn();
            colJogv = new DataGridViewCheckBoxColumn();
            colJogVege = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colMobil = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEllenorzes).BeginInit();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.Location = new Point(239, 37);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(306, 45);
            btnImport.TabIndex = 0;
            btnImport.Text = "Diákok adatainak impotrálása";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // dgvEllenorzes
            // 
            dgvEllenorzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEllenorzes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEllenorzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEllenorzes.Columns.AddRange(new DataGridViewColumn[] { colOM, colNev, colJogv, colJogVege, colEmail, colMobil });
            dgvEllenorzes.Location = new Point(13, 121);
            dgvEllenorzes.Name = "dgvEllenorzes";
            dgvEllenorzes.RowTemplate.Height = 25;
            dgvEllenorzes.Size = new Size(756, 364);
            dgvEllenorzes.TabIndex = 1;
            // 
            // colOM
            // 
            colOM.HeaderText = "OM";
            colOM.Name = "colOM";
            // 
            // colNev
            // 
            colNev.HeaderText = "Név";
            colNev.Name = "colNev";
            // 
            // colJogv
            // 
            colJogv.HeaderText = "Jogviszony?";
            colJogv.Name = "colJogv";
            // 
            // colJogVege
            // 
            colJogVege.HeaderText = "Jogviszony vége";
            colJogVege.Name = "colJogVege";
            colJogVege.Resizable = DataGridViewTriState.True;
            colJogVege.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "e-mail";
            colEmail.Name = "colEmail";
            colEmail.Resizable = DataGridViewTriState.True;
            colEmail.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colMobil
            // 
            colMobil.HeaderText = "Elérhetőség";
            colMobil.Name = "colMobil";
            // 
            // UscImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvEllenorzes);
            Controls.Add(btnImport);
            Name = "UscImport";
            Size = new Size(782, 504);
            ((System.ComponentModel.ISupportInitialize)dgvEllenorzes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImport;
        private DataGridView dgvEllenorzes;
        private DataGridViewTextBoxColumn colOM;
        private DataGridViewTextBoxColumn colNev;
        private DataGridViewCheckBoxColumn colJogv;
        private DataGridViewTextBoxColumn colJogVege;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colMobil;
    }
}
