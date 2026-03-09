namespace Sikidom
{
    public partial class Form1 : Form
    {
        private Label[] lblParam = new Label[3];
        private TextBox[] txtParam = new TextBox[3];
        public Form1()
        {
            InitializeComponent();
            BuildUi();
        }
        private void BuildUi()
        {
            for (int i = 0; i < 3; i++)
            {
                lblParam[i] = new Label
                {
                    Text = $"Paraméter {i + 1}:",
                    AutoSize = true,
                    Anchor = AnchorStyles.Left,
                };
                txtParam[i] = new TextBox
                {
                    PlaceholderText = "pl.: 2,4",
                    AutoSize = true,
                    Anchor = AnchorStyles.Left,
                };

                tbLInput.Controls.Add(lblParam[i], 0, i);
                tbLInput.Controls.Add(txtParam[i], 1, i);
                //cBoxSikidom.Items.AddRange(new string[] { "Négyzet", "Téglalap", "Kör", "Háromszög", "Rombusz" });


                cBoxSikidom.SelectedIndexChanged += changeSikidom;


                cBoxMertekegyseg.SelectedIndex = 1;
                lblStatus.Text = "Kérem válassza ki a síkidomot és adja meg a paramétereket!";
            }
        }
        private void changeSikidom(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                lblParam[i].Visible = true;
                txtParam[i].Visible = true;
            }
            clearData();

            switch (cBoxSikidom.SelectedIndex)
            {
                case 0:
                    lblParam[0].Text = "a oldal:";
                    lblParam[1].Text = "b oldal:";
                    lblParam[2].Visible = false;
                    txtParam[2].Visible = false;
                    break;
                case 1:
                    lblParam[0].Text = "a oldal:";
                    lblParam[1].Visible = false;
                    txtParam[1].Visible = false;
                    lblParam[2].Visible = false;
                    txtParam[2].Visible = false;
                    break;
                case 2:
                    lblParam[0].Text = "r sugár:";
                    lblParam[1].Visible = false;
                    txtParam[1].Visible = false;
                    lblParam[2].Visible = false;
                    txtParam[2].Visible = false;
                    break;
                case 3:
                    lblParam[0].Text = "a oldal:";
                    lblParam[1].Text = "b oldal:";
                    lblParam[2].Text = "c oldal:";
                    break;
                case 4:
                    lblParam[0].Text = "a oldal:";
                    lblParam[1].Text = "b oldal:";
                    lblParam[2].Visible = false;
                    txtParam[2].Visible = false;
                    break;
                default:
                    break;
            }

        }
        private void Előzmények_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxSikidom.SelectedIndex = 0;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            double[] adatok = new double[3];
            for (int i = 0; i < 3; i++)
            {
                if (txtParam[i].Visible)
                {
                    if (!double.TryParse(txtParam[i].Text, out adatok[i]))
                    {
                        lblStatus.Text = $"Hibás érték a {i + 1}. paraméternél!";
                        //MessageBox.Show($"Hibás érték a {i + 1}. paraméternél! Kérem adjon meg egy számot.");
                        return;
                    }
                }
            }
            double kerulet = 0, terulet = 0;
            double aOldal = 0;
            double bOldal;
            double cOldal;
            double r;
            switch (cBoxSikidom.SelectedIndex)
            {

                case 0:
                    aOldal = adatok[0];
                    bOldal = adatok[1];
                    kerulet = 2 * (aOldal + bOldal);
                    terulet = aOldal * bOldal;
                    break;
                case 1:
                    aOldal = adatok[0];
                    kerulet = 4 * aOldal;
                    terulet = aOldal * aOldal;
                    break;
                case 2:
                    r = adatok[0];
                    kerulet = 2 * r * Math.PI;
                    terulet = r * r * Math.PI;
                    break;
                case 3:
                    aOldal = adatok[0];
                    bOldal = adatok[1];
                    cOldal = adatok[2];
                    if (!HaromszogE(aOldal, bOldal, cOldal))
                    {
                        lblStatus.Text = "A megadott oldalak nem alkotnak háromszöget!";
                        return;
                    }
                    kerulet = aOldal + bOldal + cOldal;
                    double s = kerulet / 2;
                    terulet = Math.Sqrt(s * (s - aOldal) * (s - bOldal) * (s - cOldal));
                    break;
                case 4:
                    aOldal = adatok[0];
                    bOldal = adatok[1];

                    kerulet = Math.Sqrt((aOldal * aOldal) + (bOldal * bOldal)) + aOldal + bOldal;
                    terulet = aOldal * bOldal / 2;
                    break;
                default:
                    break;
            }
            lblStatus.Text = "A számítás befejeződött!";
            lblKerulet.Text = $"{kerulet:F2}";
            lblTerulet.Text = $"{terulet:F2}";
            lBoxElozmenyek.Items.Add($"{cBoxSikidom.Text}; {string.Join("; ", adatok.Where((x, i) => txtParam[i].Visible).Select(x => x.ToString("F2")))} ; Kerület: {kerulet:F2}{cBoxMertekegyseg.Text}; Terület: {terulet:F2}{cBoxMertekegyseg.Text}²");

        }

        private bool HaromszogE(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private void clearData() {
            for (int i = 0; i < 3; i++)
            {
                txtParam[i].Text = string.Empty;
            }
            lblStatus.Text = "Kérem válassza ki a síkidomot és adja meg a paramétereket!";
            lblKerulet.Text = "-";
            lblTerulet.Text = "-";
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
           clearData();
        }
    }
}
