using BaluNatanApp.Models;
using MaterialSkin.Controls;
using System.ComponentModel;

namespace BaluNatanApp


{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        recruitmentDBContext db = new recruitmentDBContext();
        Companies Company = null;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //materialSkinManager.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string NIPToSearch = NIPTextBox.Text;
            if (NIPToSearch.Length != 10)
                MessageBox.Show("NIP musi zawieraæ 10 cyfr!", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            else
            {
                GetNIPData(NIPToSearch);
            }
            
        }

        public async void GetNIPData(string NIPToSearch)
        {
            CompaniesRoot companiesRoot = await WlApiController.SearchByNIP(NIPToSearch);
            if(companiesRoot.result.subject == null)
            {
                MessageBox.Show("Nie znaleziono danego numeru nip", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Company = companiesRoot.result.subject;
            ShowNIPData();
        }

        public void ShowNIPData()
        {
            Label_Name.Text = Company.name ?? "N/A";
            Label_NIP.Text = Company.nip ?? "N/A";
            Label_StatusVAT.Text = Company.statusVat ?? "N/A";
            Label_Regon.Text = Company.regon ?? "N/A";
            Label_Pesel.Text = Company.pesel ?? "N/A";
            Label_KRS.Text = Company.krs ?? "N/A";
            Label_ResAddress.Text = Company.residenceAddress ?? "N/A";
            Label_WorkAddr.Text = Company.workingAddress ?? "N/A";

            Label_RegLegDate.Text = Company.registrationLegalDate ?? "N/A";
            Label_RegDenBasis.Text = Company.registrationDenialBasis ?? "N/A";
            Label_RegDenDate.Text = Company.registrationDenialDate ?? "N/A";
            Label_RemovalBasis.Text = Company.removalBasis ?? "N/A";
            Label_RemovalDate.Text = Company.removalDate ?? "N/A";
            Label_RestorationBasis.Text = Company.restorationBasis ?? "N/A";
            Label_RestorationDate.Text = Company.removalDate ?? "N/A";
            Label_HasVirtAcc.Text = Company.name ?? "N/A";

            ListBox_Partners.Items.Clear();
            ListBox_AccountNumbers.Items.Clear();
            Company.partners.ForEach(x => ListBox_Partners.Items.Add(new MaterialSkin.MaterialListBoxItem(x)));
            Company.accountNumbers.ForEach(x => ListBox_AccountNumbers.Items.Add(new MaterialSkin.MaterialListBoxItem(x)));
        }

        private void NIPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Company == null)
                return;

            db.Companies.Add(new BaluNatanApp.Company()
            {
                Nip = Convert.ToInt32(Company.nip),
                Name = Company.name,
                StatusVat = Company.statusVat,
                Regon = Company.regon,
                Pesel = Company.pesel,
                Krs = Company.krs,
                ResidenceAddress = Company.residenceAddress,
                WorkingAddress = Company.workingAddress,
                RegistrationLegalDate = Company.registrationLegalDate,
                RegistrationDenialDate = Company.registrationDenialDate,
                RegistrationDenialBasis = Company.registrationDenialBasis,
                RestorationBasis = Company.restorationBasis,
                RestorationDate = Company.restorationDate,
                RemovalBasis = Company.removalBasis,
                RemovalDate = Company.removalDate,
                HasVirtualAccounts = Company.hasVirtualAccounts.ToString(),
            });

            Company.partners.ForEach(x => db.Partners.Add(new Partner()
            {
                Nip = Convert.ToInt32(Company.nip),
                Partners = x
            }));

            Company.accountNumbers.ForEach(x => db.AccountNumbers.Add(new AccountNumber()
            {
                Nip = Convert.ToInt32(Company.nip),
                AccountNumbers = x
            }));


            db.SaveChanges();
            MessageBox.Show("Zapisano", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}