using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private static readonly string endpointuri = ConfigurationManager.AppSettings["EndpointUri"];
        private static readonly string primarykey = ConfigurationManager.AppSettings["PrimaryKey"];
        private CloudDataAndServices cloudData;
        private static readonly string partitionkey = ConfigurationManager.AppSettings["PartitionKey"];
        private static readonly int maxTimeForCloudActivities = Convert.ToInt32(ConfigurationManager.AppSettings["maxTimeForCloudActivities"]);
        private static readonly int maxTimeForCloudActivitiesTables = Convert.ToInt32(ConfigurationManager.AppSettings["maxTimeForCloudActivitiesTables"]);


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new DB obj
            cloudData = new CloudDataAndServices(endpointuri, primarykey);

            textBox_AzureAccountAndPointUri.Text = endpointuri;
            textBox_AzureAccountAndPrimaryKey.Text = primarykey;
        }



        private void btn_connectDB_Click(object sender, EventArgs e)
        {
            try
            {
                cloudData.createCosmosClient();
                MessageBox.Show("Successsully connected to DB");
                btn_connectDB.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem...  \n" + ex.Message);
            }

        }

        private void btn_isConnected_click(object sender, EventArgs e)
        {
            if (cloudData.isConnected)
            {
                MessageBox.Show("you are connected to DB!!!");
            }
            else
            {
                MessageBox.Show("you are not connected to DB");
            }
        }

        //click on create db/table button
        private async void btn_createTable_click(object sender, EventArgs e)
        {
            //taking db name and table name from input fields
            string dbName = textBox_DBname.Text;
            string tableName = textBox_TableName.Text;
            await Create_db_and_table_async(dbName, tableName);

        }
        private async Task Create_db_and_table_async(string dbName, string tbName)
        {
            Microsoft.Azure.Cosmos.Database createDB = null;

            //creating a database
            #region stage 1:  create database in cloud
            try
            {
                Microsoft.Azure.Cosmos.DatabaseResponse result = await cloudData.createDbAsync(dbName);
                System.Net.HttpStatusCode resCode = result.StatusCode;
                createDB = result.Database;
                //the DB was created in the cloud
                if (resCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("'" + dbName + "' was created in your cloud account", "DB was created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                //the DB is already exists in the cloud, so azure didnt create it again
                else if (resCode == System.Net.HttpStatusCode.OK || resCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("the database '" + dbName + "' is already exist", "DB already existed in your cloud",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //another value of httpStatusCode
                else
                {
                    MessageBox.Show("The DB was not created, the following error accured: \n\n\n" + resCode,
                        "DB was not created.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database was not created, Error:\n\n" + ex.Message, 
                    "DB was not created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            //if the db was not created, we cannot proceed to the table creation process
            if(createDB == null)
            {
                MessageBox.Show("Table wasn't created","table will not be created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //creating a table
            #region stage 2:  create table in cloud
            
                //check if tbName is not empty
                if (!String.IsNullOrEmpty(tbName))
                {
                try {
                    Microsoft.Azure.Cosmos.ContainerResponse result = await cloudData.CreateContainerAsync(createDB, tbName, partitionkey);
                    System.Net.HttpStatusCode sCode = result.StatusCode;
                    //the Table was created in the database
                    if (sCode == System.Net.HttpStatusCode.Created)
                    {
                        MessageBox.Show("Table '" + tbName + "' was created in your DB", "Table was created",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    //the Table is already exists in the database, so azure didnt create it again
                    else if (sCode == System.Net.HttpStatusCode.OK || sCode == System.Net.HttpStatusCode.Accepted)
                    {
                        MessageBox.Show("the table '" + tbName + "' is already exist", "Table already existed in your DB",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //another value of httpStatusCode
                    else
                    {
                        MessageBox.Show("The Table was not created, the following error accured: \n\n\n" + sCode,
                            "Table was not created.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Table was not created, Error:\n\n" + ex.Message,
                        "Table was not created", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
                
            
            
            
            
            #endregion
        }


        //make textBoxes enable or disable
        private void textBox_DBname_TextChanged(object sender, EventArgs e)
        {
            //if the user typed the database name, then we can enable the create button
            if (!textBox_DBname.Text.Equals(String.Empty))
            { // !textBox_DBname.Text.Equals(String.Empty)    textBox_DBname.Text != ""

                btn_CreateTable.Enabled = true;
            }
            else
            {
                btn_CreateTable.Enabled = false;
            }
        }

        

        

        

        

        

        //put value in the list from the ObjList  cloudDatabases
        private void populateDatabaseInComboBox()
        {
            comboBox_cloudDBs.DataSource = null;
            comboBox_cloudDBs.Items.Clear();
            
            comboBox_cloudDBs.DataSource = cloudData.CloudDatabases;
            comboBox_cloudDBs.DisplayMember = "databaseId";
        }
        private void populateTablesInComboBox()
        {
            comboBox_cloudTables.DataSource = null;
            comboBox_cloudTables.Items.Clear();

            comboBox_cloudTables.DataSource = cloudData.CloudTables;
            comboBox_cloudTables.DisplayMember = "tableName";
        }
        private void refreshDBlist()
        {
            //ask the cloud object to get our DBs with time limitation
            cloudData.getCloudData(CloudDataAndServices.TaskType.GetCloudDBTask, maxTimeForCloudActivities);
            //at this stage, we know that cloudData.CloudDatabases is updated
            populateDatabaseInComboBox();
        }


        private void btn_refreshDBlist_Click_1(object sender, EventArgs e)
        {
            refreshDBlist();
        }

        private void btn_refreshTableList_Click_2(object sender, EventArgs e)
        {
            cloudData.getCloudData(CloudDataAndServices.TaskType.GetCloudTableTask, maxTimeForCloudActivitiesTables);
            //populateTablesInComboBox();
            filterTableListAccordingToDB(cloudData.DBName);
            
        }

        private async void btn_deleteDBfromCloud_Click(object sender, EventArgs e)
        {
            String DBidForDetele = ((Models.Database)comboBox_cloudDBs.SelectedItem).databaseId;
            if(DBidForDetele != ""||DBidForDetele != null)
            {
                MessageBox.Show(DBidForDetele + " is about to be deleted!");
                if (!String.IsNullOrEmpty(DBidForDetele))
                {
                    try
                    {
                        //trigger delete function
                        System.Net.HttpStatusCode res = await cloudData.deleteSelectedDBAsync(DBidForDetele);
                       if(
                            (res == System.Net.HttpStatusCode.OK)
                            ||
                            (res == System.Net.HttpStatusCode.NoContent)
                            )
                        {
                            MessageBox.Show(DBidForDetele + " deleted succsessfully");
                            refreshDBlist();

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Delete activity faild. " + ex.Message,"failed to delete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

            }
        }
        
        private void comboBox_cloudDBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_cloudDBs.SelectedItem != null)
            {
                cloudData.DBName = ((Models.Database)comboBox_cloudDBs.SelectedItem).databaseId;
            }
            else
            {
                cloudData.DBName = String.Empty;
                //display only the tables wich are relevant to the selectet DB
            }
            filterTableListAccordingToDB(cloudData.DBName);
        }
        private void filterTableListAccordingToDB(string DBid = "")
        {
            comboBox_cloudTables.Items.Clear();
            foreach (Models.Table tb in cloudData.CloudTables)
            {
                if (!String.IsNullOrEmpty(DBid))
                {
                    //skip those tables wich are not related to the current database id
                    if (!tb.databaseId.Equals(DBid))
                    {
                        continue;
                    }
                    //if the code came to this place then we want to add the items for the list
                    comboBox_cloudTables.Items.Add(tb);
                    comboBox_cloudTables.DisplayMember = "tableName";
                }
                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_cloudTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_cloudTables.SelectedItem != null)
            {
                cloudData.TableName = ((Models.Table)comboBox_cloudTables.SelectedItem).tableName;
            }
            else
            {
                cloudData.TableName = String.Empty;
            }
        }

        private async void btn_insert_click(object sender, EventArgs e)
        {
            string userData = richTextBox_textFromUser.Text;
            //take data from screen and split it to students and units
            List<Models.Student> studentsFromUser = Models.Student.convertStringIntoStudentData(userData);
            string cloudActivity = checkedListBox_cloudActivity.CheckedItems[0].ToString();
            if (cloudActivity.Contains("insert"))
            {
                await cloudData.updateDataInCloud(studentsFromUser, CloudDataAndServices.CloudDataActivity.New);
            }
            if (cloudActivity.Contains("modify"))
            {
                await cloudData.updateDataInCloud(studentsFromUser, CloudDataAndServices.CloudDataActivity.Modify);
            }
            if (cloudActivity.Contains("delete"))
            {
                await cloudData.updateDataInCloud(studentsFromUser, CloudDataAndServices.CloudDataActivity.Delete);
            }


        }
        //delete btn
        private async void button1_Click(object sender, EventArgs e)
        {
            String tableidForDetele = ((Models.Table)comboBox_cloudTables.SelectedItem).tableName;
            String DBidForDetele = ((Models.Database)comboBox_cloudDBs.SelectedItem).databaseId;
            if (tableidForDetele != "" || tableidForDetele != null)
            {
                MessageBox.Show(tableidForDetele + " is about to be deleted!");
                if (!String.IsNullOrEmpty(tableidForDetele))
                {
                    try
                    {
                        //trigger delete function
                        System.Net.HttpStatusCode res = await cloudData.deleteSelectedTableAsync(DBidForDetele ,tableidForDetele);
                        if (
                             (res == System.Net.HttpStatusCode.OK)
                             ||
                             (res == System.Net.HttpStatusCode.NoContent)
                             )
                        {
                            MessageBox.Show(tableidForDetele + " deleted succsessfully");
                            refreshDBlist();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete activity faild. " + ex.Message, "failed to delete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
