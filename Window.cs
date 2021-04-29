using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace DbProviderFactory
{
    public partial class Window : Form
    {
        private System.Data.IDbConnection connection = null;
        private System.Data.Common.DbProviderFactory factory = null;
        private string providerName = "";

        public Window()
        {
            InitializeComponent();
        }

        private void ClickGetProviders(object sender, EventArgs e)
        {
            DataTable dataTable = DbProviderFactories.GetFactoryClasses();
            dataGridView.DataSource = dataTable;

            comboBoxProviders.Items.Clear();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                comboBoxProviders.Items.Add(dataRow["InvariantName"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClickSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProviders.SelectedItem != null)
            {
                factory = DbProviderFactories.GetFactory(comboBoxProviders.SelectedItem.ToString());
                connection = factory.CreateConnection();
                providerName = GetConnectionStringByProvider(comboBoxProviders.SelectedItem.ToString());
                textBoxConnectionString.Text = providerName;
            }
               

        }

        private static string GetConnectionStringByProvider(string providerName)
        {
            string result = null;

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings stringSettings in settings)
                {
                    if (stringSettings.ProviderName == providerName)
                    {
                        result = stringSettings.ConnectionString;
                        break;
                    }
                }
            }

            return result;

        }

        private void ClickSendRequest(object sender, EventArgs e)
        {
            connection.ConnectionString = textBoxConnectionString.Text;
            DbDataAdapter dataAdapter = factory.CreateDataAdapter();
            dataAdapter.SelectCommand = (DbCommand)connection.CreateCommand();
            dataAdapter.SelectCommand.CommandText = textBoxSqlRequest.Text;

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
        }

        private void TextChanged(object sender, PreviewKeyDownEventArgs e)
        {
            buttonSendRequest.Enabled = textBoxSqlRequest.Text.Length > 5;
        }
    }
}
