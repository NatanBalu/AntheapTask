using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using MaterialSkin.Controls;

namespace BaluNatanApp
{
    public partial class Form2 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form2()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }

        private void EditFIleButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                filePath = openFileDialog.FileName;
                string[] original = File.ReadAllLines(filePath);
                List<string> output = new List<string>();
                List<string> output2 = new List<string>();
                List<string> outputTemp = new List<string>();

                original.ToList().ForEach(x =>
                {
                    if(!x.Contains(" --> "))
                    {
                        output.Add(x);
                    }
                    else
                    {
                        var a = x.Split(" --> ");
                        DateTime dateTime1 = DateTime.ParseExact(a[0], "HH:mm:ss,fff",
                                        CultureInfo.InvariantCulture);
                        DateTime dateTime2 = DateTime.ParseExact(a[1], "HH:mm:ss,fff",
                                        CultureInfo.InvariantCulture);

                        var dt1 = dateTime1.AddSeconds(5);
                        var dt2 = dateTime2.AddSeconds(5);
                        var outdt1 = dt1.AddMilliseconds(880);
                        var outdt2 = dt2.AddMilliseconds(880);
                        output.Add(outdt1.ToString("HH:mm:ss,fff") + " --> " + outdt2.ToString("HH:mm:ss,fff"));
                    }
                });

                //  var writer = new StreamWriter(filePath);
                //  output.ForEach(x => writer.WriteLine(x));

                MessageBox.Show("Wybierz folder do zapisu pliku z pełnymi sekundami", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var writer = new StreamWriter(filePath);
                        output.ForEach(x => writer.WriteLine(x));

                        int counter = 0;
                        output.ForEach((x) =>
                        {

                            if (x == "")
                            {
                                if (outputTemp.Count > 2 && DateTime.ParseExact(outputTemp[1].Split(" --> ")[0], "HH:mm:ss,fff", CultureInfo.InvariantCulture).Millisecond == 0)
                                {
                                    counter++;
                                    outputTemp[0] = counter.ToString();
                                    output2.AddRange(outputTemp);
                                }
                                outputTemp.Clear();
                            }
                            else
                            {
                                outputTemp.Add(x);
                            }
                        });

                        var writer2 = new StreamWriter(fbd.SelectedPath+"\\PartB.txt");
                        output2.ForEach(x => writer2.WriteLine(x));


                    }
                }




            }
        }
    }
}
