namespace calcul
{
    public partial class FrmCalcul : Form
    {
        TextBox[] titles; // 교과목 TextBox배열
        ComboBox[] crds; // 학점 ComboBox배열
        ComboBox[] grds;

        public FrmCalcul()
        {
            InitializeComponent();
        }

        private void FrmCalcul_Load(object sender, EventArgs e)
        {
            crds = new ComboBox[] { Crd1, Crd2, Crd3, Crd4, Crd5, Crd6, Crd7 };
            grds = new ComboBox[] { Grd1, Grd2, Grd3, Grd4, Grd5, Grd6, Grd7 };
            titles = new TextBox[] { Title1, Title2, Title3, Title4, Title5, Title6, Title7 };
            int[] arrCredit = { 1, 2, 3 };
            List<String> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (var combo in crds)
            {
                foreach (var i in arrCredit)
                {
                    combo.Items.Add(i);
                }
            }

            foreach (var cb in grds)
            {
                foreach (var i in lstGrade)
                {
                    cb.Items.Add(i);
                }
            }
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            TxtGrade.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private double GetGrade(string text)
        {
            double grade = 0;

            if (text == "A+") grade = 4.5;
            else if (text == "A0") grade = 4.0;
            else if (text == "B+") grade = 3.5;
            else if (text == "B0") grade = 3.0;
            else if (text == "C+") grade = 2.5;
            else if (text == "C0") grade = 2.0;
            else if (text == "D+") grade = 1.5;
            else if (text == "D0") grade = 1.0;
            else grade = 0;

            return grade;
        }
    }
}
