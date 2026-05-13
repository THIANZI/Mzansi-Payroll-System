namespace Mzansi_Tech_Contractors_Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Contractor name is required.");
                    return;
                }

                if (!double.TryParse(txtHours.Text, out double hours) || hours < 0)
                {
                    MessageBox.Show("Enter valid positive hours worked.");
                    return;
                }

                if (!int.TryParse(txtDependents.Text, out int dependents) || dependents < 0 || dependents > 10)
                {
                    MessageBox.Show("Dependents must be between 0 and 10.");
                    return;
                }

                PayrollCalculator calc = new PayrollCalculator();

                double gross = calc.CalculateGross(hours);
                double uif = calc.CalculateUIF(gross);
                double paye = calc.CalculatePAYE(gross, dependents);
                double membership = calc.CalculateMembership(gross);
                double total = uif + paye + membership;
                double net = calc.CalculateNet(gross, uif, paye, membership);

                lblGross.Text = $"R {gross:F2}";
                lblUIF.Text = $"R {uif:F2}";
                lblPAYE.Text = $"R {paye:F2}";
                lblMembership.Text = $"R {membership:F2}";
                lblTotal.Text = $"R {total:F2}";
                lblNet.Text = $"R {net:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtDependents.Clear();

            lblGross.Text = "R 0.00";
            lblUIF.Text = "R 0.00";
            lblPAYE.Text = "R 0.00";
            lblMembership.Text = "R 0.00";
            lblTotal.Text = "R 0.00";
            lblNet.Text = "R 0.00";

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to exit?",
       "Confirm Exit",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
