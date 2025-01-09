using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string[] filelines;

        public Form1()
        {
            InitializeComponent();
            searchTextBox.KeyPress += new KeyPressEventHandler(searchTextBox_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeComboBox.Text = "Típus"; typeComboBox.ForeColor = Color.Gray; typeComboBox.Enter += (s, e) => { if (typeComboBox.Text == "Típus") { typeComboBox.Text = ""; typeComboBox.ForeColor = Color.Black; } }; typeComboBox.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(typeComboBox.Text)) { typeComboBox.Text = "Típus"; typeComboBox.ForeColor = Color.Gray; } };

            string filepath = "adat.txt";
            filelines = File.ReadAllLines(filepath);

            resultsListbox.Visible = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Search();
            }
        }

        private void Search()
        {
            string searchTerm = searchTextBox.Text;
            resultsListbox.Items.Clear();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                resultsListbox.Items.Add("Keress rá egy alkatrészre.");
                resultsListbox.Visible = true;
                return;
            }

            var results = filelines
                .Where(line => line.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Any())
            {
                resultsListbox.Items.AddRange(results.ToArray());
                resultsListbox.Visible = true;
            }
            else
            {
                resultsListbox.Items.Add("Nincs találat.");
                resultsListbox.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string type = typeComboBox.Text.ToUpper();
            string name = nameTextbox.Text;
            string desc = descTextbox.Text;
            string price = priceTextbox.Text;

            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(price)) { MessageBox.Show("Töltsd ki az összes mezőt."); return; }

            string newLine = $"{type};{name};{desc};{price}";
            File.AppendAllText("test.txt", newLine + Environment.NewLine);
            filelines = File.ReadAllLines("test.txt");
            MessageBox.Show("Sikeresen elmentve.");
        }

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("adat.txt");
            int amdCpus = 0, intelCpus = 0, amdGpus = 0, nvidiaGpus = 0;

            resultsListbox.Visible = true;
            resultsListbox.Items.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                var type = parts[0];
                var name = parts[1];

                if (type == "CPU")
                {
                    if (name.Contains("AMD"))
                        amdCpus++;
                    else if (name.Contains("Intel"))
                        intelCpus++;
                }
                else if (type == "GPU")
                {
                    if (name.Contains("AMD"))
                        amdGpus++;
                    else if (name.Contains("NVIDIA"))
                        nvidiaGpus++;
                }
            }

            resultsListbox.Items.Clear();
            resultsListbox.Items.Add("Statisztika:");
            resultsListbox.Items.Add($"- AMD CPU-k: {amdCpus}");
            resultsListbox.Items.Add($"- Intel CPU-k: {intelCpus}");
            resultsListbox.Items.Add($"- AMD GPU-k: {amdGpus}");
            resultsListbox.Items.Add($"- NVIDIA GPU-k: {nvidiaGpus}");
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(discountTextBox.Text, out int discountPercentage) || discountPercentage <= 0 || discountPercentage > 100)
            {
                MessageBox.Show("Kérlek adj meg egy érvényes százalékot 1-100 között!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCategory = discountType.SelectedItem.ToString();

            var lines = File.ReadAllLines("adat.txt");
            var updatedLines = new List<string>();

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length < 4)
                {
                    updatedLines.Add(line);
                    continue;
                }

                string type = parts[0];
                string name = parts[1];
                string details = parts[2];
                if (!int.TryParse(parts[3], out int price))
                {
                    updatedLines.Add(line);
                    continue;
                }

                if (selectedCategory == "Összes" || selectedCategory == type)
                {
                    price -= price * discountPercentage / 100;
                }

                updatedLines.Add($"{type};{name};{details};{price}");
            }

            File.WriteAllLines("adat.txt", updatedLines);

            resultsListbox.Visible = true;
            resultsListbox.Items.Clear();
            resultsListbox.Items.Add($"Az árak {discountPercentage}% kedvezménnyel frissítve.");
            resultsListbox.Items.Add($"Kategória: {selectedCategory}");
        }
    }
}
