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
    }
}
