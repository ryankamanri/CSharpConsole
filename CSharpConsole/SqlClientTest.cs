//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;
//namespace CSharpConsole
//{
//    class SqlClientTest
//    {
//        private static string SqlConnectString = "Server = 192.168.1.102,1433; Database=WebApplication1Context-72ad4565-867d-4363-a047-a4f39f02a988;uid=user;pwd=123456;";
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            InsertPostText("1");
//        }
//        public static int InsertPostText(string Text)
//        {
//            int idCount, id = 1; ;
//            SqlConnection sqlConnection = new SqlConnection(SqlConnectString);
//            SqlCommand sqlSelectCommand, sqlInsertCommand;
//            SqlDataReader sqlDataReader;
//            DataSet dataSet = new DataSet();
//            //遍历确定ID

//            string SqlSelectID = "SELECT ID FROM dbo.PostText";
//            string SqlInsertCommand = "INSERT INTO dbo.PostText VALUES (" + id + "," + Text + ")";
//            try
//            {
//                sqlConnection.Open();
//                sqlSelectCommand = new SqlCommand(SqlSelectID, sqlConnection);
//                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelectCommand);
//                sqlDataAdapter.Fill(dataSet);

//                idCount = dataSet.Tables[0].Rows.Count;
//                id = (int)dataSet.Tables[0].Rows[idCount - 1][0] + 1;
            
//           }
//            catch (Exception e)
//            {
//                sqlConnection.Close();
//                throw e;

//            }
//            return id;


//        }
//    }
//}
