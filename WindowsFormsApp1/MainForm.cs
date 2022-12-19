using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    

    public partial class MainForm : Form
    {
        List<HouseData> HouseDataList = new List<HouseData>();
        string dbConnectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.HouseDatabaseConnectionString"].ConnectionString;


            //"WindowsFormsApp1.Properties.Settings.HouseDBConnectionString";
            //connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HouseDB.mdf;Integrated Security=True"
            //providerName = "System.Data.SqlClient" />


        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_GetData_Click(object sender, EventArgs e)
        {
            PopulateClientDataListBox();
        }

        private void PopulateClientDataListBox()
        {
            using(SqlConnection myConnection = new SqlConnection(dbConnectionString))  //establish connection to db
            using (SqlDataAdapter clientAdapter = new SqlDataAdapter("select * from Properties", myConnection))
            {
                DataTable clientData = new DataTable();
                myConnection.Open();
                clientAdapter.Fill(clientData);
                //Console.WriteLine(clientData.Rows[0]);
                myConnection.Close();

                clientData.DefaultView.Sort = "PostalCode";
                clientData = clientData.DefaultView.ToTable();

                //loop through all rows
                for(int i = 0; i<clientData.Rows.Count; i++)
                {
                    int id = (int)clientData.Rows[i]["Id"];
                    String Address = clientData.Rows[i]["Address"].ToString();
                    string PostalCode = clientData.Rows[i]["PostalCode"].ToString();
                    DateTime ListDate = (DateTime)clientData.Rows[i]["ListDate"];
                    string NumberOfBedrooms = clientData.Rows[i]["NumberOfBedrooms "].ToString();
                    string NumberOfBathrooms = clientData.Rows[i]["NumberOfBathrooms"].ToString();
                    string ListPrice = clientData.Rows[i]["ListPrice"].ToString();
                    string Description = clientData.Rows[i]["Description"].ToString();
                    string SellingPrice = clientData.Rows[i]["SellingPrice"].ToString();
                    
                    string SquareFeet = clientData.Rows[i]["SquareFeet"].ToString();
                    DateTime SellDate = (DateTime)clientData.Rows[i]["ListDate"];
                    


                    HouseData houseData = new HouseData(id, Address, PostalCode, ListDate.ToString(), NumberOfBedrooms, NumberOfBathrooms, ListPrice, Description, SellingPrice, SquareFeet, SellDate.ToString());
                    HouseDataList.Add(houseData);
                    ListViewItem myItem = new ListViewItem(id.ToString());
                    Console.Write(houseData.address);
                    myItem.SubItems.Add(houseData.address);
                    myItem.SubItems.Add(houseData.postalCode);

                    if (Convert.ToDouble(houseData.listPrice) / (Convert.ToDouble(houseData.squareFeet)) >= 200)
                    {
                        myItem.ForeColor = Color.Red;
                    }else if(Convert.ToDouble(houseData.listPrice) / (Convert.ToDouble(houseData.squareFeet)) <= 100)
                    {
                        myItem.ForeColor = Color.Green;
                    }
                    else
                    {
                        myItem.ForeColor = Color.Yellow;
                    }
                    ListView.Items.Add(myItem);

                }

              
             

            }
                    
                    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {

            Console.WriteLine("test");
            for(int i = 0; i<ListView.Items.Count; i++)
            {
                if (ListView.Items[i].Selected == true)
                {
                    string id = ListView.Items[i].Text;
                    Console.WriteLine("selected found, id: " + id);
                    FillTheFullData(Int32.Parse(id));
                    break;
                }
            }
        }

        private void FillTheFullData(int id)
        {
            Console.WriteLine("filling data for id: " + id);
            foreach ( var x in HouseDataList)
            {
                if (x.id == id)
                {
                    ListViewItem myItem = new ListViewItem(x.id.ToString());
                    myItem.SubItems.Add(x.address);
                    myItem.SubItems.Add(x.description);
                    myItem.SubItems.Add(x.postalCode);
                    myItem.SubItems.Add(x.listDate);
                    myItem.SubItems.Add(x.listPrice);
                    myItem.SubItems.Add(x.sellingDate);
                    myItem.SubItems.Add(x.sellingPrice);
                    myItem.SubItems.Add(x.numberOfBathrooms);
                    myItem.SubItems.Add(x.NumberOfBedrooms);
                    myItem.SubItems.Add(x.squareFeet);



                    listView1.Items.Add(myItem);

                }
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
