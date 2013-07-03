using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Configuration;

namespace TeamManagement_Tool
{
    public partial class frmMain : Form
    {

        const string sqlDatasource = "127.0.0.1";
        const string sqlDatabase = "TeamManagementTool";
        const string sqlLogin = "ReadWriteUser";
        const string sqlPassword = "test";
        MySqlConnection sqlConnection;

        enum PermissionLevel { None, Guest, User, Drei, Vier, Fünf, CoLeader, Leader, Admin, SuperAdmin };
        PermissionLevel currentPermission = PermissionLevel.None;

        public static frmMain mainScreen;

        public frmMain()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection("Data Source=" + sqlDatasource + "; Database=" + sqlDatabase + "; User ID=" + sqlLogin + ";Password=" + sqlPassword);

                frmLogin loginScreen = new frmLogin();
                DialogResult loginResult;

                while (true)
                {
                    loginResult = loginScreen.ShowDialog();
                    if (loginResult == DialogResult.OK)
                    {
                        //PasswordCrack();
                        //if (loginScreen.textLogin != "" || loginScreen.textPassword != "") break;//DEBUG
                        //loginScreen.SetWrongPassword();//DEBUG
                        //continue;//DEBUG

                        if (CheckLogin(loginScreen.textLogin, loginScreen.textPassword))
                        {
                            mainScreen = this;
                            //config.lastLoginName = loginScreen.textLogin;
                            //config.Save();
                            break;
                        }
                        else
                        {
                            loginScreen.SetWrongPassword();
                        }

                    }
                    else
                    {
                        this.Close();
                    }
                }
                RefreshAllData();
                //Console.WriteLine(loginScreen.tbLogin.Text);
            }
            catch
            {

                this.Close();
            }
        }

        private bool CheckLogin(string login, string password)
        {
            //this.statusbarLogin.Text = "ChristianT";
            //return true;
            //ConfigurationSettings config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Set;
            //System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None); //TeamManagement_Tool.Properties.Settings.Default; // System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Configuration config = ConfigurationManager.OpenMappedExeConfiguration(

            //Configuration config = Configuration

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand("Select Password,PermissionLevel from User where login = '" + login + "'", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                //if (sqlRead.Read()) {
                Console.WriteLine("Eingabe = " + MD5_Crypto.GetMd5Hash(password));
                //Console.WriteLine("Gespeichert = " + sqlRead.GetValue(0).ToString());
                //if (sqlRead.Read() && sqlRead.GetValue(0).ToString() == password)
                if (sqlRead.Read() && sqlRead.GetValue(0).ToString() == MD5_Crypto.GetMd5Hash(password))
                {
                    this.statusbarLogin.Text = login;
                    currentPermission = (PermissionLevel)sqlRead.GetInt32("PermissionLevel");
                    this.statusbarPermission.Text = Enum.GetName(typeof(PermissionLevel), currentPermission);
                    sqlRead.Close();
                    sqlConnection.Close();
                    return true;
                }
                else
                {
                    sqlRead.Close();
                    sqlConnection.Close();
                }
                /*}
                else
                {
                    sqlRead.Close();
                    sqlCon.Close();
                }*/
                return false;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuFileLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void RefreshAllData()
        {
            SQLRefreshMitarbeiter();
            SQLRefreshProjekte();
        }

        private void btnBugsFeedback_Click(object sender, EventArgs e)
        {
            RefreshAllData();
            //dgMitarbeiter.Rows.Add(row);
        }

        void SQLRefreshProjekte()
        {
            try
            {
                //Mitarbeiter

                MySqlCommand sqlCmd = new MySqlCommand("Select * from Projects", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                mainScreen.dgProjekt.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        DataGridViewRow row = dgProjekt.Rows[dgProjekt.Rows.Add()];

                        row.Cells[dgProjektID.Name].Value = sqlRead.GetString("id");
                        row.Cells[dgProjektName.Name].Value = sqlRead.GetString("Name");
                        row.Cells[dgProjektGenre.Name].Value = sqlRead.GetString("Genre");
                        row.Cells[dgProjektStil.Name].Value = sqlRead.GetString("Stil");
                        row.Cells[dgProjektPlatform.Name].Value = sqlRead.GetString("Platform");
                        row.Cells[dgProjektStartDatum.Name].Value = sqlRead.GetString("Startdatum");
                        row.Cells[dgProjektRelease.Name].Value = sqlRead.GetString("Release");
                        row.Cells[dgProjektArbeitstitel.Name].Value = sqlRead.GetString("Arbeitstitel");
                        row.Cells[dgProjektNotiz.Name].Value = sqlRead.GetString("Notiz");

                    }

                }

                sqlRead.Close();
                sqlConnection.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
            }
        }

        void SQLRefreshMitarbeiter()
        {
            try
            {
                //Mitarbeiter

                MySqlCommand sqlCmd = new MySqlCommand("Select * from User", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                MySqlConnection sqlSubConnection = new MySqlConnection(sqlConnection.ConnectionString + ";Password=" + sqlPassword);
                sqlSubConnection.Open();
                MySqlCommand sqlSubCommand;
                MySqlDataReader sqlSubReader;


                mainScreen.dgMitarbeiter.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {

                        sqlSubCommand = new MySqlCommand("Select * from VisiblePrivateData where id = " + Convert.ToInt32(sqlRead.GetString("id")), sqlSubConnection);

                        sqlSubReader = sqlSubCommand.ExecuteReader();
                        if (sqlSubReader.Read())
                        {
                            DataGridViewRow row = dgMitarbeiter.Rows[dgMitarbeiter.Rows.Add()];

                            if (currentPermission >= PermissionLevel.Leader)
                            {
                                row.Cells[dgMitarbeiterNummer.Name].Value = sqlRead.GetString("id");
                                row.Cells[dgMitarbeiterVorname.Name].Value = sqlRead.GetString("FirstName");
                                row.Cells[dgMitarbeiterName.Name].Value = sqlRead.GetString("LastName");
                                row.Cells[dgMitarbeiterLogin.Name].Value = sqlRead.GetString("Login");
                                row.Cells[dgMitarbeiterPermissionLevel.Name].Value = sqlRead.GetString("PermissionLevel");

                                row.Cells[dgMitarbeiterStrasse.Name].Value = sqlRead.GetString("Street");
                                row.Cells[dgMitarbeiterPLZ.Name].Value = sqlRead.GetString("ZipCode");
                                row.Cells[dgMitarbeiterOrt.Name].Value = sqlRead.GetString("City");
                                row.Cells[dgMitarbeiterRegion.Name].Value = sqlRead.GetString("Region");
                                row.Cells[dgMitarbeiterLand.Name].Value = sqlRead.GetString("Country");
                            }
                            else
                            {
                                row.Cells[dgMitarbeiterNummer.Name].Value = sqlRead.GetString("id");
                                row.Cells[dgMitarbeiterVorname.Name].Value = sqlRead.GetString("FirstName");
                                if (sqlSubReader.GetString("LastName") == "1") { row.Cells[dgMitarbeiterName.Name].Value = sqlRead.GetString("LastName"); }
                                row.Cells[dgMitarbeiterLogin.Name].Value = sqlRead.GetString("Login");

                                if (sqlSubReader.GetString("Street") == "1") { row.Cells[dgMitarbeiterStrasse.Name].Value = sqlRead.GetString("Street"); }
                                if (sqlSubReader.GetString("ZipCode") == "1") { row.Cells[dgMitarbeiterPLZ.Name].Value = sqlRead.GetString("ZipCode"); }
                                if (sqlSubReader.GetString("City") == "1") { row.Cells[dgMitarbeiterOrt.Name].Value = sqlRead.GetString("City"); }
                                if (sqlSubReader.GetString("Region") == "1") { row.Cells[dgMitarbeiterRegion.Name].Value = sqlRead.GetString("Region"); }
                                row.Cells[dgMitarbeiterLand.Name].Value = sqlRead.GetString("Country");
                            }
                        }
                        sqlSubReader.Close();
                    }

                }

                sqlRead.Close();
                sqlConnection.Close();
                sqlSubConnection.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
            }
        }

        private void dgMitarbeiter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dgMitarbeiter.Rows[e.RowIndex].Cells[dgMitarbeiterNummer.Name].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgMitarbeiter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgMitarbeiter.Rows[e.RowIndex].Selected = true;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dgMitarbeiter_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            frmProjekt project = new frmProjekt();
            project.ShowDialog(this);

            SQLSaveProject(project);
        }

        private void SQLSaveProject(frmProjekt project)
        {
            if (project.shouldSave == true)
            {
                try
                {
                    //Projekt

                    MySqlCommand sqlCmd;// = new MySqlCommand("Select * from Projects", sqlConnection);
                    string cmdString;
                    sqlConnection.Open();

                    if (project.tbID.Text == "")  //Neues Projekt
                    {
                        cmdString =
                        "INSERT INTO Projects VALUES (0," +
                        "'" + project.tbName.Text + "'," +
                        "'" + project.tbGenre.Text + "'," +
                        "'" + project.tbStil.Text + "'," +
                        "'" + project.tbPlatform.Text + "'," +
                        "'" + project.tbStartDatum.Text + "'," +
                        "'" + project.tbRelease.Text + "'," +
                            //"'" + project.dtpStartDatum.Value.Date.ToString() + "'," +
                            //"'" + project.dtpRelease.Value.Date.ToString() + "'," +
                        "'" + project.tbArbeitstitel.Text + "'," +
                        "'" + project.tbNotiz.Text + "');";
                    }
                    else //Bestehendes Ändern
                    {
                        cmdString =
                        "UPDATE Projects " +
                        "SET " +
                        "Name = '"+project.tbName.Text+"', " +
                        "Genre = '"+project.tbGenre.Text+"', " +
                        "Stil = '"+project.tbStil.Text+"', " +
                        "Platform = '"+project.tbPlatform.Text+"', " +
                        "Startdatum = '"+project.tbStartDatum.Text+"', " +
                        "Projects.Release = '"+project.tbRelease.Text+"', " +
                        "Arbeitstitel = '"+project.tbArbeitstitel.Text+"', " +
                        "Notiz = '"+project.tbNotiz.Text+"' " +
                        "WHERE id = '" + project.tbID.Text + "';";
                    }
                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    SQLRefreshProjekte();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                }

                Console.WriteLine("BLA");
            }
        }

        private void dgProjekt_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmProjekt project = new frmProjekt();
            project.tbID.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektID.Name].Value.ToString();
            project.tbName.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektName.Name].Value.ToString();
            project.tbGenre.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektGenre.Name].Value.ToString();
            project.tbStil.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektStil.Name].Value.ToString();
            project.tbPlatform.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektPlatform.Name].Value.ToString();
            project.tbStartDatum.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektStartDatum.Name].Value.ToString();
            project.tbRelease.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektRelease.Name].Value.ToString();
            project.tbArbeitstitel.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektArbeitstitel.Name].Value.ToString();
            project.tbNotiz.Text = dgProjekt.Rows[e.RowIndex].Cells[dgProjektNotiz.Name].Value.ToString();
            project.ShowDialog(this);

            SQLSaveProject(project);
        }

        private void dgProjekt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                if (dgProjekt.SelectedRows.Count > 0)
                {
                    int rowIndex = dgProjekt.SelectedRows[0].Index;
                    frmProjekt project = new frmProjekt();
                    project.tbID.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektID.Name].Value.ToString();
                    project.tbName.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektName.Name].Value.ToString();
                    project.tbGenre.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektGenre.Name].Value.ToString();
                    project.tbStil.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektStil.Name].Value.ToString();
                    project.tbPlatform.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektPlatform.Name].Value.ToString();
                    project.tbStartDatum.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektStartDatum.Name].Value.ToString();
                    project.tbRelease.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektRelease.Name].Value.ToString();
                    project.tbArbeitstitel.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektArbeitstitel.Name].Value.ToString();
                    project.tbNotiz.Text = dgProjekt.Rows[rowIndex].Cells[dgProjektNotiz.Name].Value.ToString();
                    project.ShowDialog(this);

                    SQLSaveProject(project);
                }
            }
        }
    }
}
