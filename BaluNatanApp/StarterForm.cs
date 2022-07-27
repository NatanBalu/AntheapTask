using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;


namespace BaluNatanApp
{
    public partial class StarterForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Form1 form1 = new Form1();
        Form2 form2 =  new Form2();
        public StarterForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {

        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Show();            
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
