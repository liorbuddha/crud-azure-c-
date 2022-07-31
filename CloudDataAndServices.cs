using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CloudDataAndServices
    {
        //azure cosmos params for creating DB connection
        private string endpointuri;
        public string endPointUri
        {
            get
            {
                return endpointuri;

            }
        }
        private string primarykey;
        public string primaryKey
        {
            get
            {
                return primarykey;

            }
        }
        //indication if connected to cosmos
        private bool isConnectedToCosmos = false; //default for bool is false

        public bool isConnected
        {
            get
            {
                return isConnectedToCosmos;
            }
        }

        private CosmosClient cosmosClient;

        //lists. 
        
        private System.Collections.Generic.List<Models.Table> cloudTables = new List<Models.Table>();
        public System.Collections.Generic.List<Models.Table> CloudTables
        {
            get { return cloudTables; }
        }
        
        private System.Collections.Generic.List<Models.Database> cloudDatabases = new List<Models.Database>();

        public System.Collections.Generic.List<Models.Database> CloudDatabases
        {
            get { return cloudDatabases; }
        }

        //name of selected DB name in combobox
        private string DBname;
        public string DBName
        {
            get
            {
                return DBname;
            }
            set
            {
                DBname = value;
            }
        }
        private string tableName;
        public string TableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }
        private Microsoft.Azure.Cosmos.Container container = null;
        public enum TaskType
        {
            GetCloudDBTask,
            GetCloudTableTask
        }
        public enum CloudDataActivity
        {
            New,
            Modify,
            Delete

        }
        //constructor
        public CloudDataAndServices(string end_point_uri, string primary_key)
        {
            endpointuri = end_point_uri;
            primarykey = primary_key;
        }

        //create cosmos client
        public void createCosmosClient()
        {
            try
            {
                cosmosClient = new CosmosClient(endpointuri, primarykey);


            }
            catch (Exception ex)
            {
                isConnectedToCosmos = false;
                throw ex;
            }
            isConnectedToCosmos = true;
        }

        //create database
        public async Task<DatabaseResponse> createDbAsync(String DB_name)
        {
            
            DatabaseResponse response = await cosmosClient.CreateDatabaseIfNotExistsAsync(DB_name);
            return response;
        }
        //create table
        public async Task<ContainerResponse> CreateContainerAsync(Microsoft.Azure.Cosmos.Database dbObject, string tbName, string partitionKey)
        {
            ContainerResponse res = await dbObject.CreateContainerIfNotExistsAsync(tbName, partitionKey);
            await getDatabasesAsync();
            return res;
        }
       

        //the following method gets as input:
        //a. the type of the task we want the cloud to do.
        //b. the max time that we want to allow the cloud
        public void getCloudData(TaskType taskType, int timeOut)
        {
            //create a task
            Task cloudTask = Task.Run(
                async () =>
                {
                    if (taskType == TaskType.GetCloudDBTask)
                    {
                        await getDatabasesAsync();
                    }
                    else if (taskType == TaskType.GetCloudTableTask)
                    {
                        await getTablesAsync();
                    }
                }
                );
            cloudTask.Wait(timeOut);
            //when the code gets here, the task is no longer running
            if (!cloudTask.IsCompleted)
            {
                throw new TaskCanceledException(taskType.ToString() + " didnt returned in " + (timeOut / 1000) + " seconds");
            }

  
        }

        public async Task<System.Net.HttpStatusCode> deleteSelectedDBAsync(string DBname)
        {
            Microsoft.Azure.Cosmos.DatabaseResponse res = await cosmosClient.GetDatabase(DBname).DeleteAsync();
            return res.StatusCode;
        }
        //get all DBs from cloud, store them to local list (cloudDatabases)

        public async Task<System.Net.HttpStatusCode> deleteSelectedTableAsync(string DBname, string idForDelete)
        {
            Microsoft.Azure.Cosmos.ContainerResponse res = await cosmosClient.GetDatabase(DBname).GetContainer(idForDelete).DeleteContainerAsync();
            return res.StatusCode;
        }

        private async Task getDatabasesAsync()
        {
            //clear all current data (getting updated data)
            this.cloudDatabases.Clear();
            //get iterator for looping the DB in cloud
            FeedIterator<DatabaseProperties> iterator = cosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            do
            {
                foreach (DatabaseProperties db in await iterator.ReadNextAsync())
                {
                    //code for each db od DBs
                    Models.Database currentDB = new Models.Database();
                    currentDB.databaseId = db.Id;
                    currentDB.eTag = db.ETag;

                    //at this stage currentDB contains the information we choose
                    //to take from Microsoft.Azure.Cosmos.DatabaseProperties
                    cloudDatabases.Add(currentDB);

                }

            } while (iterator.HasMoreResults);

        }
       
        
        //get all tables from cloud, store them to local list (cloudTables)

        private async Task getTablesAsync()
        {
            //clear all current data from cloudTables
            this.cloudTables.Clear();
            //FeedIterator<ContainerProperties> iterator = cosmosClient.GetDatabaseQueryIterator<ContainerProperties>();
            
            //scan all DBs in the cloud, based on the local list cloudDatabases
            //for each db we want to call all its tables
            
                foreach(Models.Database localDB in cloudDatabases)
                {
                //get the azure DB object from the cloud according to its id
                //we want to ask the cloud for a specific database
                //input DB id and output microsoft DB
                Microsoft.Azure.Cosmos.Database currentDatabase = cosmosClient.GetDatabase(localDB.databaseId);

                    //get the tables of the cloud database (currentDatabase)
                FeedIterator<ContainerProperties> iterator = currentDatabase.GetContainerQueryIterator<ContainerProperties>();

                //at this stage currentDB contains the information we choose
                //to take from Microsoft.Azure.Cosmos.DatabaseProperties
                do
                {
                    foreach(ContainerProperties table in await iterator.ReadNextAsync())
                    {
                        Models.Table currentTable = new Models.Table();
                        currentTable.tableName = table.Id;
                        currentTable.databaseId = localDB.databaseId;
                        cloudTables.Add(currentTable);
                    }
                } while (iterator.HasMoreResults);
                }

        

        }



        //ADD STUDENT, UPDATE STUDENT, DELETE STUDENT
        public async Task updateDataInCloud(List<Models.Student> students, CloudDataActivity activity)
        {
            container = cosmosClient.GetContainer(DBName, tableName);
            string currentStudentId;
            bool existsInCLoud = false;
            foreach(Models.Student s in students)
            {
                currentStudentId = s.id;
                if (String.IsNullOrEmpty(currentStudentId))
                {
                    continue;
                }
                try
                {
                    await container.ReadItemAsync<Models.Student>(currentStudentId, new PartitionKey(currentStudentId));
                    existsInCLoud = true;
                }
                catch(Exception ex)
                {
                    existsInCLoud = false;
                }
                if(activity == CloudDataActivity.Delete)
                {
                    if (!existsInCLoud)
                    {
                        continue;
                    }
                    await container.DeleteItemAsync<Models.Student>(currentStudentId, new PartitionKey(currentStudentId));
                }
                //modify overrides the exists uder
                if(activity == CloudDataActivity.Modify)
                {
                    if (!existsInCLoud)
                    {
                        continue;
                    }
                    //delete and insert
                    await container.DeleteItemAsync<Models.Student>(currentStudentId, new PartitionKey(currentStudentId));
                    await container.CreateItemAsync<Models.Student>(s, new PartitionKey(currentStudentId));


                }
                if(activity == CloudDataActivity.New)
                {
                    if (existsInCLoud) continue;

                    await container.CreateItemAsync<Models.Student>(s, new PartitionKey(currentStudentId));
                    continue;

                }
            }
        }











        //public async Task<FeedIterator> createSqlAsync(String DB_Name)
        //{
        //    QueryDefinition qd = new QueryDefinition("CREATE TABLE " + DB_Name + "");
        //    QueryDefinition queryDefinition = new QueryDefinition(qd);

        //    using Task<FeedIterator> queryResultSetIterator = this..GetItemQueryIterator<FeedIterator>(queryDefinition);
        //    return feed;
        //}


    }
    }

        //insert data
        
        //ContainerRequestOptions req = await cont;
        //return req;
    
    

