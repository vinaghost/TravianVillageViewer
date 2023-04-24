using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class VillagesForm : Form
    {
        public VillagesForm(string title, List<Village> villages)
        {
            InitializeComponent();
            GenerateColumn();
            DataGrid.DataSource = BindingSource;
            BindingSource.DataSource = villages;
            Text = title;
        }

        private void GenerateColumn()
        {
            DataGrid.AutoGenerateColumns = false;

            var columns = new List<DataGridViewTextBoxColumn>()
            {
                new () { Name = "VillageName", HeaderText = "Village name", DataPropertyName = "Name" },
                new () { Name = "VillagePlayer", HeaderText = "Player name", DataPropertyName = "PlayerName" },
                new () { Name = "Coordinates", HeaderText = "Coordinates", DataPropertyName = "Coordinates" },
                new () { Name = "Population", HeaderText = "Population", DataPropertyName = "Pop" },
                new () { Name = "IsCapital", HeaderText = "Capital", DataPropertyName = "IsCapital" },
            };

            DataGrid.Columns.AddRange(columns.ToArray());
        }
    }
}