using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Office.Interop.Excel;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Aplikacja
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxDatabase.Text = "CN_Test";
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxServer.Text = textBoxLogin.Text = textBoxPassword.Text = textBoxDatabase.Text= "";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool checkConnection;
            connection.ConnectionString = $"Server={textBoxServer.Text};Database=master;User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";

            try
            {
                connection.Open();
                connection.Close();
                checkConnection = true;
            }
            catch (SqlException)
            {
                checkConnection = false;
            }


            if (checkConnection)
            {
                MessageBox.Show("Połączenie poprawne","Sprawdzenie połączenia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie udało się połączyć z serwerem SQL", "Sprawdzenie połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateDatabase_Click(object sender, EventArgs e)
        {
            connectionString = $"Server={textBoxServer.Text};Database=master;User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";
            command.Connection = connection;

            string databaseCreateQuery =
                        $"CREATE DATABASE {textBoxDatabase.Text} ON PRIMARY " +
                        $"(NAME = {textBoxDatabase.Text}, " +
                        $"FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.SERVERDMS214\\MSSQL\\DATA\\{textBoxDatabase.Text}.mdf', " +
                        "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
                        $"LOG ON (NAME = {textBoxDatabase.Text}_Log, " +
                        $"FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.SERVERDMS214\\MSSQL\\DATA\\{textBoxDatabase.Text}Log.ldf', " +
                        "SIZE = 1MB, " +
                        "MAXSIZE = 5MB, " +
                        "FILEGROWTH = 10%)";

            string tableCreateQuery =
                "CREATE TABLE " + textBoxDatabase.Text + @".[dbo].[CN_Pracownicy](
	                    [Prac_ID] [int] IDENTITY(1,1) NOT NULL,
	                    [Prac_Dzial] [varchar](50) NULL,
	                    [Prac_Kod] [varchar](50) NOT NULL,
	                    [Prac_Nazwisko] [varchar](50) NULL,
	                    [Prac_Imie] [varchar](50) NULL,
	                    [Prac_Stanowisko] [varchar](50) NULL,
	                    [Prac_DataUtworzenia] [datetime] NULL,
                        CONSTRAINT [PK_CN_Pracownicy] PRIMARY KEY CLUSTERED 
                    (
	                    [Prac_ID] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
                        CONSTRAINT [Unique_ID] UNIQUE NONCLUSTERED 
                    (
	                    [Prac_ID] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]";

            string tableAlterQuery = $"ALTER TABLE {textBoxDatabase.Text}.[dbo].[CN_Pracownicy] ADD  CONSTRAINT [Prac_DataWpisuAuto]  DEFAULT (getdate()) FOR [Prac_DataUtworzenia]";

            try
            {
                connection.Open();

                command.CommandText = databaseCreateQuery;
                command.ExecuteNonQuery();

                command.CommandText = tableCreateQuery;
                command.ExecuteNonQuery();

                command.CommandText = tableAlterQuery;
                command.ExecuteNonQuery();

                MessageBox.Show($"Baza danych {textBoxDatabase.Text} została utworzona", "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            connection.ConnectionString= $"Server={textBoxServer.Text};Database=master;User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";
            command.Connection = connection;
            command.CommandText = $"DROP DATABASE {textBoxDatabase.Text}";

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"Baza danych {textBoxDatabase.Text} została usunięta", "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void buttonLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            DialogResult result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string file = openDialog.FileName;
                    workbook = excel.Workbooks.Open(openDialog.FileName);
                    worksheet = workbook.Worksheets[1];

                    for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
                    {
                        string value = worksheet.Cells[1, i].Value;
                        comboBoxImportDzial.Items.Add(value);
                        comboBoxImportNazwisko.Items.Add(value);
                        comboBoxImportImie.Items.Add(value);
                        comboBoxImportKod.Items.Add(value);
                        comboBoxImportStanowisko.Items.Add(value);
                    }
                    labelImportPlikNazwa.Enabled = true;
                    labelImportPlikNazwa.Text = Regex.Match(openDialog.FileName, @"[^\\]*$").Value;
                    buttonImport.Enabled = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { }                                
        }      

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string insertQuery;
            int dzialID = comboBoxImportDzial.SelectedIndex+1;
            int nazwiskoID = comboBoxImportNazwisko.SelectedIndex+1;
            int imieID = comboBoxImportImie.SelectedIndex+1;
            int kodID = comboBoxImportKod.SelectedIndex+1;
            int stanowiskoID = comboBoxImportStanowisko.SelectedIndex + 1;            

            try
            {
                connection.ConnectionString = $"Server={textBoxServer.Text};Database={textBoxDatabase.Text};User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";
                connection.Open();
                command.Connection = connection;

                for (int i = 2; i <= worksheet.UsedRange.Rows.Count; i++)
                {
                    insertQuery = 
                        $"INSERT INTO {textBoxDatabase.Text}.dbo.CN_Pracownicy (" +
                                    $"[Prac_Dzial]," +
                                    $"[Prac_Kod]," +
                                    $"[Prac_Nazwisko]," +
                                    $"[Prac_Imie]," +
                                    $"[Prac_Stanowisko])" + 
                        $"values (" +
                                    $"'{worksheet.Cells[i, dzialID].value}', " +
                                    $"'{worksheet.Cells[i, kodID].value}', " +
                                    $"'{worksheet.Cells[i, nazwiskoID].value}', " +
                                    $"'{worksheet.Cells[i, imieID].value}', " +
                                    $"'{worksheet.Cells[i, stanowiskoID].value}')";
                    command.CommandText = insertQuery;
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Import wykonany pomyślnie");
            }
            catch (COMException ex)
            {
                if(ex.ErrorCode == -2146827284)
                {
                    MessageBox.Show("Uzupełnij wszystkie pola", "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                { 
                    MessageBox.Show(ex.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aplikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();

        }

        private void buttonExportXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            saveDialog.Filter = "All files (*.*) | *.*";
            DialogResult result = saveDialog.ShowDialog();

            connection.ConnectionString = $"Server={textBoxServer.Text};Database={textBoxDatabase.Text};User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM dbo.CN_Pracownicy";

            if (result == DialogResult.OK)
            {
                try
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataSet);
                    dataSet.Tables[0].WriteXml(saveDialog.FileName);
                    connection.Close();
                    MessageBox.Show("Eksport wykonany pomyślnie");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { }
        }

        private void buttonExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "All files (*.*) | *.*";
            DialogResult result = saveDialog.ShowDialog();

            connection.ConnectionString = $"Server={textBoxServer.Text};Database={textBoxDatabase.Text};User Id={textBoxLogin.Text};Password={textBoxPassword.Text};";
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM {textBoxDatabase.Text}.dbo.CN_Pracownicy";

            if (result == DialogResult.OK)
            {
                try
                {                    
                    SqlDataReader reader = command.ExecuteReader();
                    StreamWriter writer = new StreamWriter(saveDialog.FileName);

                    object[] output = new object[reader.FieldCount];

                    for (int i = 0; i < reader.FieldCount; i++)
                        output[i] = reader.GetName(i);

                    writer.WriteLine(string.Join(",", output));

                    while (reader.Read())
                    {
                        reader.GetValues(output);
                        writer.WriteLine(string.Join(",", output));
                    }

                    writer.Close();
                    reader.Close();
                    connection.Close();
                    MessageBox.Show("Eksport wykonany pomyślnie");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { }
        }

        private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", "dom.karczewski@gmail.com", "Odpowiedź na zadanie", "Panie Dominiku,"+Environment.NewLine+"Zadanie wykonane świetnie!");
            mailto = Uri.EscapeUriString(mailto);
            System.Diagnostics.Process.Start(mailto);
        }
    }
}
