namespace Assignment_2
{

    public partial class Assignment2 : Form
    {
        enum TruckColor { Red, Blue, Black, White }
        TruckColor selectedTruckColor;

        public Assignment2()
        {
            InitializeComponent();
        }

        private void listMakeandModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //Set the error message display and color if no solection is made
            if (lstMakeAndModel.SelectedIndex == -1)
            {
                lblPurchaseSummary.Text = "Please select a Make and Model";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }
            lblPurchaseSummary.ForeColor = Color.Black;

            //Use intTryParse for error message display and color
            if (!int.TryParse(txtYear.Text, out int year))
            {
                lblPurchaseSummary.Text = "Please enter a valid year";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }
            lblPurchaseSummary.ForeColor = Color.Black;

            //Use switch expression to get selected TruckColor using the enum 
            string colorText = selectedTruckColor switch
            {
                TruckColor.Red => "red",
                TruckColor.Blue => "blue",
                TruckColor.Black => "black",
                TruckColor.White => "white",
                _ => "unknown"
            };

            //Add the selected features from checkboxes
            List<string> features = new List<string>();
            if (chkBackUpCamera.Checked) features.Add("Back-Up Camera");
            if (chkTintedWindows.Checked) features.Add("Tinted Windows");
            if (chkAutoTailgate.Checked) features.Add("Auto Tailgate");
            if (chkAC.Checked) features.Add("AC");

            //Format the purchase summary
            lblPurchaseSummary.Text = $"You have purchased a {colorText} {year} {lstMakeAndModel.SelectedItem?.ToString() ?? "unknown model"} with the following features: {string.Join(", ", features)}.";

        }

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWhite.Checked) selectedTruckColor = TruckColor.White;
        }

        private void groupBoxColor_Enter(object sender, EventArgs e)
        {

        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked) selectedTruckColor = TruckColor.Red;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked) selectedTruckColor = TruckColor.Blue;
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlack.Checked) selectedTruckColor = TruckColor.Black;
        }

        private void groupBoxFeatures_Enter(object sender, EventArgs e)
        {

        }

        private void lblPurchaseSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
