using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectConstraction {
    public partial class Form1 : Form {
        private bool flag = false;
        readonly string connectionString = @"Data Source=SRZ\SRZ;Initial Catalog=ident;User ID=user;Password=гыук";
        readonly string connectionString2 = @"Server=192.168.2.155;Port=5432;User Id=fuser;Password=6PJyRMLH#Sf@tQLL9Sc@;Database=foms;";
        string request;
        public Form1() {
            InitializeComponent();
            this.Size = new Size(400, 300);
        }

        private void AddRequest_Click(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithElementForAddRequest.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.AutoSize = false;

            UpdateList();
        }

        private void UpdateList() {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand("Select NameRequest From Requests", con)) {
                    con.Open();
                    using (SqlDataReader reader = com.ExecuteReader()) {
                        while (reader.Read()) {
                            ListWithRequests.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void AddSelectToDB_Click(object sender, EventArgs e) {
            if (flag) {
                using (SqlConnection con = new SqlConnection(connectionString)) {
                    using (SqlCommand com = new SqlCommand("Update Requests set NameRequest = @name, Request = @req Where NameRequest = @name1", con)) {
                        con.Open();
                        com.Parameters.AddWithValue("@name", NameRequest.Text);
                        com.Parameters.AddWithValue("@req", Request.Text);
                        com.Parameters.AddWithValue("@name1", ListWithRequests.SelectedItem.ToString());
                        com.ExecuteNonQuery();
                    }
                }
                ListWithRequests.Items.Clear();
                UpdateList();
            } else {
                using (SqlConnection con = new SqlConnection(connectionString)) {
                    using (SqlCommand com = new SqlCommand("Insert Into Requests(NameRequest, Request) Values(@name, @req)", con)) {
                        con.Open();
                        com.Parameters.AddWithValue("@name", NameRequest.Text);
                        com.Parameters.AddWithValue("@req", Request.Text);
                        com.ExecuteNonQuery();
                    }
                }
                ListWithRequests.Items.Add(NameRequest.Text);
            }
            NameRequest.Clear();
            Request.Clear();
            this.AutoSize = false;
            this.Size = new Size(400, 300);
            flag = false;
            AddSelectToDB.Name = "Добавить";
            PanelWithElementForAddRequest.Visible = false;
        }

        private void ChooseRequst_Click(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithArg.Visible = true;
            
            DeleteEl();
            ParsingRequest();
            PanelWithArg.Size = new Size(395, 99);
        }
        private void DeleteEl() {
            //PanelWithArg.Size = new Size(395, 99);
            if (!(textBoxes is null)) {
                foreach (TextBox txt in textBoxes) 
                    PanelWithArg.Controls.Remove(txt);
                textBoxes = null;    
            }
            if (!(OurLabel is null)) {
                foreach (Label l in OurLabel) 
                    PanelWithArg.Controls.Remove(l);
                OurLabel = null;    
            }
            
            //DoRequest.Location = new Point(DoRequest.Location.X, ras - 41);
        }

        void RunRequest() {
            request = request.Substring(request.IndexOf("Select", comparisonType: StringComparison.OrdinalIgnoreCase), request.Length - request.IndexOf("Select", comparisonType: StringComparison.OrdinalIgnoreCase));
            request = request.Replace('\n', ' ');
            using (NpgsqlConnection npgsqlcon = new NpgsqlConnection(connectionString2)) {
                npgsqlcon.Open();
                int index = 0;
                foreach (var nameVar in nameVarLst) {
                    if (nameVar.Value.IndexOf("varchar") != -1) {
                        string str = "'" + textBoxes[index].Text.ToString() + "'";
                        request = request.Replace(nameVar.Key.ToString(), "'" + textBoxes[index].Text.ToString() + "'");
                    }
                        
                    else if (nameVar.Value.IndexOf("date") != -1)
                        request = request.Replace(nameVar.Key.ToString(), "'" + DateTime.ParseExact(GetDate(textBoxes[index].Text), "yyyyMdd", null) + "'");
                    else if (nameVar.Value.IndexOf("int") != -1)
                        request = request.Replace(nameVar.Key.ToString(), textBoxes[index].Text.ToString());
                    index++;
                }
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(request, npgsqlcon)) {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    ReportForm reportForm = new ReportForm();
                    reportForm.ReportTbl.DataSource = dataSet.Tables[0];
                    reportForm.ShowDialog();
                }
            }
        }
        Dictionary<string, string> nameVarLst;
        Label[] OurLabel;
        TextBox[] textBoxes;
        
        private void ParsingRequest() {
            nameVarLst = new Dictionary<string, string>();
            request = GetRequest();
            
            Regex regex = new Regex(@"declare @\w* \w*");
            MatchCollection matches = regex.Matches(request);
            int i = 3;
            if (matches.Count > 0) {
                int index = 0;
                textBoxes = new TextBox[matches.Count];
                OurLabel = new Label[matches.Count];
                foreach(Match match in matches) {
                    OurLabel[index] = new Label { Location = new Point(4, i), Font = new Font("Century Gothic", 12) };
                    string nameVar = match.Value.Substring(match.Value.IndexOf(' '), (match.Value.LastIndexOf(' ') - match.Value.IndexOf(' '))).Trim(' ');
                    string type = match.Value.Substring(match.Value.LastIndexOf(' ') + 1, match.Value.Length - (match.Value.LastIndexOf(' ') + 1));
                    nameVarLst.Add(nameVar, type);
                    OurLabel[index].Text = nameVar + ":";
                    textBoxes[index] = new TextBox { Location = new Point(4, i + 25), Size = new Size(150, 20) };
                    PanelWithArg.Controls.Add(OurLabel[index]);
                    PanelWithArg.Controls.Add(textBoxes[index]);
                    i += 50;
                    index++;
                }
            }
            DoRequest.Location = new Point(DoRequest.Location.X, i);
            this.Size = new Size(this.Size.Width, PanelWithArg.Height);
        }

        private string GetRequest() {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand("Select Request From Requests Where NameRequest = @nameReq", con)) {
                    con.Open();
                    com.Parameters.AddWithValue("@nameReq", ListWithRequests.SelectedItem.ToString());
                    using (SqlDataReader reader = com.ExecuteReader()) {
                        reader.Read();
                        return reader.GetString(0);
                    }
                }
            }
        }

        private void DoRequest_Click(object sender, EventArgs e) {
            RunRequest();
        }

        private string GetDate(string ourDate) {
            string year = ourDate.Split('.')[2];
            string month = ourDate.Split('.')[1];
            string day = ourDate.Split('.')[0];
            string date = year + month + day;
            return date;
        }

        private void ListWithRequests_DoubleClick(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithArg.Visible = true;

            DeleteEl();
            ParsingRequest();
            PanelWithArg.Size = new Size(400, 99);
        }

        private void ListWithRequests_SelectedIndexChanged(object sender, EventArgs e) {
            EditButton.Enabled = true;
            RemoveButton.Enabled = true;
        }

        private void EditButton_Click(object sender, EventArgs e) {
            AddSelectToDB.Text = "Изменить";
            NameRequest.Text = ListWithRequests.SelectedItem.ToString();
            GetReq();
            flag = true;this.AutoSize = true;
            PanelWithElementForAddRequest.Visible = true;
        }

        void GetReq() {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand("Select Request From Requests Where NameRequest = @name", con)) {
                    con.Open();
                    com.Parameters.AddWithValue("@name", ListWithRequests.SelectedItem.ToString());
                    using (SqlDataReader reader = com.ExecuteReader()) {
                        reader.Read();
                        Request.Text = reader.GetString(0);
                    }
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand("Delete From Requests Where NameRequest = @name", con)) {
                    con.Open();
                    com.Parameters.AddWithValue("@name", ListWithRequests.SelectedItem.ToString());
                    com.ExecuteNonQuery();
                }
            }
            ListWithRequests.Items.Remove(ListWithRequests.SelectedItem);
        }
    }
}
