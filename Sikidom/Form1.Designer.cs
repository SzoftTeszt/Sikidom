namespace Sikidom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            gBoxBeallitas = new GroupBox();
            cBoxMertekegyseg = new ComboBox();
            cBoxSikidom = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            gBoxAdatok = new GroupBox();
            btnTorles = new Button();
            btnSzamol = new Button();
            lblStatus = new Label();
            tbLInput = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            lblTerulet = new Label();
            label4 = new Label();
            lblKerulet = new Label();
            label3 = new Label();
            gBoxElozmenyek = new GroupBox();
            btnExport = new Button();
            lBoxElozmenyek = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gBoxBeallitas.SuspendLayout();
            gBoxAdatok.SuspendLayout();
            groupBox1.SuspendLayout();
            gBoxElozmenyek.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.875F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(gBoxElozmenyek, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(gBoxBeallitas, 0, 0);
            tableLayoutPanel2.Controls.Add(gBoxAdatok, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(395, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // gBoxBeallitas
            // 
            gBoxBeallitas.Controls.Add(cBoxMertekegyseg);
            gBoxBeallitas.Controls.Add(cBoxSikidom);
            gBoxBeallitas.Controls.Add(label2);
            gBoxBeallitas.Controls.Add(label1);
            gBoxBeallitas.Dock = DockStyle.Fill;
            gBoxBeallitas.Location = new Point(3, 3);
            gBoxBeallitas.Name = "gBoxBeallitas";
            gBoxBeallitas.Size = new Size(389, 105);
            gBoxBeallitas.TabIndex = 0;
            gBoxBeallitas.TabStop = false;
            gBoxBeallitas.Text = "Beállítások";
            // 
            // cBoxMertekegyseg
            // 
            cBoxMertekegyseg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cBoxMertekegyseg.FormattingEnabled = true;
            cBoxMertekegyseg.Items.AddRange(new object[] { "mm", "cm", "m" });
            cBoxMertekegyseg.Location = new Point(103, 65);
            cBoxMertekegyseg.Name = "cBoxMertekegyseg";
            cBoxMertekegyseg.Size = new Size(263, 23);
            cBoxMertekegyseg.TabIndex = 1;
            // 
            // cBoxSikidom
            // 
            cBoxSikidom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cBoxSikidom.FormattingEnabled = true;
            cBoxSikidom.Items.AddRange(new object[] { "Téglalap (a,b)", "Négyzet (a)", "Kör (r)", "Háromszög - 3 oldal (a, b, c)", "Derékszögű háromszög - 2 befogó (a, b)" });
            cBoxSikidom.Location = new Point(103, 33);
            cBoxSikidom.Name = "cBoxSikidom";
            cBoxSikidom.Size = new Size(263, 23);
            cBoxSikidom.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Mértékegység";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Síkidom";
            // 
            // gBoxAdatok
            // 
            gBoxAdatok.Controls.Add(btnTorles);
            gBoxAdatok.Controls.Add(btnSzamol);
            gBoxAdatok.Controls.Add(lblStatus);
            gBoxAdatok.Controls.Add(tbLInput);
            gBoxAdatok.Dock = DockStyle.Fill;
            gBoxAdatok.Location = new Point(3, 114);
            gBoxAdatok.Name = "gBoxAdatok";
            gBoxAdatok.Size = new Size(389, 216);
            gBoxAdatok.TabIndex = 1;
            gBoxAdatok.TabStop = false;
            gBoxAdatok.Text = "Adatok";
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(103, 127);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(75, 23);
            btnTorles.TabIndex = 2;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            btnTorles.Click += btnTorles_Click;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(9, 127);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(75, 23);
            btnSzamol.TabIndex = 2;
            btnSzamol.Text = "Számolás";
            btnSzamol.UseVisualStyleBackColor = true;
            btnSzamol.Click += btnSzamol_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(6, 171);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(12, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "-";
            // 
            // tbLInput
            // 
            tbLInput.ColumnCount = 2;
            tbLInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLInput.Location = new Point(6, 24);
            tbLInput.Name = "tbLInput";
            tbLInput.RowCount = 3;
            tbLInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLInput.Size = new Size(377, 84);
            tbLInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTerulet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblKerulet);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 105);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eredmény";
            // 
            // lblTerulet
            // 
            lblTerulet.AutoSize = true;
            lblTerulet.Location = new Point(60, 61);
            lblTerulet.Name = "lblTerulet";
            lblTerulet.Size = new Size(12, 15);
            lblTerulet.TabIndex = 0;
            lblTerulet.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 61);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 0;
            label4.Text = "Terület";
            // 
            // lblKerulet
            // 
            lblKerulet.AutoSize = true;
            lblKerulet.Location = new Point(60, 31);
            lblKerulet.Name = "lblKerulet";
            lblKerulet.Size = new Size(12, 15);
            lblKerulet.TabIndex = 0;
            lblKerulet.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 31);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Kerület";
            // 
            // gBoxElozmenyek
            // 
            gBoxElozmenyek.Controls.Add(btnExport);
            gBoxElozmenyek.Controls.Add(lBoxElozmenyek);
            gBoxElozmenyek.Dock = DockStyle.Fill;
            gBoxElozmenyek.Location = new Point(404, 3);
            gBoxElozmenyek.Name = "gBoxElozmenyek";
            gBoxElozmenyek.Size = new Size(393, 444);
            gBoxElozmenyek.TabIndex = 1;
            gBoxElozmenyek.TabStop = false;
            gBoxElozmenyek.Text = "Előzmények";
            gBoxElozmenyek.Enter += Előzmények_Enter;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExport.Location = new Point(1, 384);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(395, 41);
            btnExport.TabIndex = 1;
            btnExport.Text = "CSV export ...";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lBoxElozmenyek
            // 
            lBoxElozmenyek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lBoxElozmenyek.FormattingEnabled = true;
            lBoxElozmenyek.Location = new Point(-3, 30);
            lBoxElozmenyek.Name = "lBoxElozmenyek";
            lBoxElozmenyek.Size = new Size(399, 334);
            lBoxElozmenyek.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Síkidom terület - és területkalkulátor";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            gBoxBeallitas.ResumeLayout(false);
            gBoxBeallitas.PerformLayout();
            gBoxAdatok.ResumeLayout(false);
            gBoxAdatok.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gBoxElozmenyek.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gBoxBeallitas;
        private ComboBox cBoxMertekegyseg;
        private ComboBox cBoxSikidom;
        private Label label2;
        private Label label1;
        private GroupBox gBoxAdatok;
        private Button btnSzamol;
        private Label lblStatus;
        private TableLayoutPanel tbLInput;
        private Button btnTorles;
        private GroupBox groupBox1;
        private Label lblTerulet;
        private Label label4;
        private Label lblKerulet;
        private Label label3;
        private GroupBox gBoxElozmenyek;
        private ListBox lBoxElozmenyek;
        private Button btnExport;
    }
}
