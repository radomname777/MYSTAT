namespace MYSTAT
{
    public partial class Form1 : Form
    {
        public bool boolen { get; set; } = false;
        public int Cris { get; set; } = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e){ richTextBox1.Visible = true; }
        private void pictureBox2_Click(object sender, EventArgs e) {if (boolen)studentinfo.Visible = true; }
        private void Remove_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (sender is PictureBox pb && boolen)
            {
                var parentPanel = (Panel)pb.Parent;
                foreach (var item in parentPanel.Controls)
                {
                    if (item is Guna.UI2.WinForms.Guna2ImageCheckBox icb&&icb.Checked==true)
                    {
                        icb.Checked = false;
                        num++;
                    }
                }
                Cris +=num;
                Cristallabel.Text = Cris.ToString();
            }
        }
        private void dia1_Click(object sender, EventArgs e)
        {
            if (!boolen && sender is Guna.UI2.WinForms.Guna2ImageCheckBox b) { b.Checked = !b.Checked; return; }
            if (sender is Guna.UI2.WinForms.Guna2ImageCheckBox a)
            {
                if (Cris <= 0 && a.Checked == true) a.Checked = false;
                else if (a.Checked == true)
                {
                    a.Checked = false;
                    var parentPanel = (Panel)a.Parent;
                    int num = 1;
                    for (int i = 0; i < 3; i++)
                    {
                        foreach (var item in parentPanel.Controls)
                        {
                                if (item is Guna.UI2.WinForms.Guna2ImageCheckBox icb && boolen)
                                {
                                    if (icb.Checked == false && icb.Tag == num.ToString()) { icb.Checked = true; Cris--;
                                    Cristallabel.Text = Cris.ToString();return; }
                                }
                        }
                        num++;
                    }
                }
                else
                {
                    int num = 3;
                    a.Checked = true;
                    var parentPanel = (Panel)a.Parent;
                    foreach (var item in parentPanel.Controls)
                    {
                        if (item is Guna.UI2.WinForms.Guna2ImageCheckBox icb && boolen)
                        {
                            if (icb.Checked == true && icb.Tag == num.ToString()) { icb.Checked = false; break; }
                            num--;
                        }
                    }
                    Cris++;
                }
              Cristallabel.Text = Cris.ToString();
            }
        }
        private void guna2CustomRadioButton4_Click(object sender, EventArgs e)
        {
            if (boolen)
            {
                foreach (var item in Controls)
                {
                    if (sender is Guna.UI2.WinForms.Guna2CustomRadioButton a1)
                    {
                        if (item is Panel panel && panel.Tag == "student")
                        {
                            a1.Checked = true;
                            foreach (var item2 in panel.Controls)
                                if (item2 is Guna.UI2.WinForms.Guna2CustomRadioButton rb) if (rb.Tag == "1") { rb.Checked = true; break; }
                        }
                        else a1.Checked = false;
                    }
                }

            }
            else if (sender is Guna.UI2.WinForms.Guna2CustomRadioButton a1) a1.Checked = false;
        }
        public bool MyProperty { get; set; } = false;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MyProperty) boolen = true;
            else MessageBox.Show("Movzunu yaddasa yaz!");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 2) MyProperty = true;
            else MessageBox.Show("Movzunu daxil edin!");
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!MyProperty) richTextBox1.Text = "";
        }

        private void guna2CustomRadioButton1_Click(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2CustomRadioButton a1)
            {
                if (!boolen)
                {
                    a1.Checked = !a1.Checked;
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!boolen && sender is Guna.UI2.WinForms.Guna2ComboBox a)
            {
                a.SelectedIndex = -1;
            }
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            if(!boolen&&sender is Guna.UI2.WinForms.Guna2ComboBox a)
            {
                a.SelectedIndex = -1; return;
            }  
        }
    }
}