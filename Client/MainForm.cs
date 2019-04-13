using System;
using System.Threading;
using System.Windows.Forms;
using Client.Extensions;

namespace Client
{
    public partial class Form1 : Form
    {
        private Services.KNNServiceClient client;
        private Services.Patient patient {
            get =>
                new Services.Patient()
                {
                    Age = int.Parse(ageTextBox.Text),
                    OperationYear = int.Parse(yearTextBox.Text),
                    NodesNumber = int.Parse(nodesTextBox.Text)
                };
        }
        private bool isAttributesSet => 
            !ageTextBox.Text.IsEmpty() && !yearTextBox.Text.IsEmpty() && !nodesTextBox.Text.IsEmpty();

        public Form1()
        {
            client = new Services.KNNServiceClient();
            InitializeComponent();
            resultComboBox.SelectedIndex = 0;
            Closed += new EventHandler(OnFormClosed);

        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            client.Exit();
        }

        private async void OnServiceInfoButtonClick(object sender, EventArgs e)
        {
            serviceInfoLabel.Text = await client.GetServiceInfoAsync();
        }

        private async void OnDatasetInfoButtonClick(object sender, EventArgs e)
        {
            datasetInfoLabel.Text = await client.GetDatasetInfoAsync();
        }

        private async void OnAddButtonClick(object sender, EventArgs e)
        {
            bool c = resultComboBox.SelectedIndex == 0 ? true : false;
            await client.AddPatientAsync(patient, c);
            MessageBox.Show("New patient added to dataset!", "Info");
        }

        private async void OnCheckButtonClick(object sender, EventArgs e)
        {
            resultComboBox.SelectedIndex = -1;
            bool c = await client.GetClassAsync(patient);
            resultComboBox.SelectedIndex = c ? 1 : 0;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            addItemButton.Enabled = checkSurvivalButton.Enabled = isAttributesSet;
        }

        private void OnTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || ((sender as TextBox).Text.Length > 1 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
