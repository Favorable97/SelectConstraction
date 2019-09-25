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

        readonly string connectionString = @"Data Source=SRZ\SRZ;Initial Catalog=ident;User ID=user;Password=гыук";
        string request;
        public Form1() {
            InitializeComponent();
            this.Size = new Size(394, 300);
        }

        private void AddRequest_Click(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithElementForAddRequest.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.AutoSize = false;

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
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand("Insert Into Requests(NameRequest, Request) Values(@name, @req)", con)) {
                    con.Open();
                    com.Parameters.AddWithValue("@name", NameRequest.Text);
                    com.Parameters.AddWithValue("@req", Request.Text);
                    com.ExecuteNonQuery();
                }
            }
            ListWithRequests.Items.Add(NameRequest.Text);
            NameRequest.Clear();
            Request.Clear();
            this.AutoSize = false;
            this.Size = new Size(394, 300);
            PanelWithElementForAddRequest.Visible = false;
        }

        private void ChooseRequst_Click(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithArg.Visible = true;
            PanelWithArg.Size = new Size(395, 99);
            ParsingRequest();
        }

        void RunRequest() {
            request = request.Substring(request.IndexOf("Select"), request.Length - request.IndexOf("Select"));
            request = request.Replace('\n', ' ');
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand com = new SqlCommand(request, con)) {
                    con.Open();
                    int index = 0;
                    foreach (string nameVar in nameVarLst) {
                        com.Parameters.AddWithValue(nameVar, (object) (textBoxes[index].Text));
                        index++;
                    }
                    com.ExecuteNonQuery();
                }
            }
        }
        List<string> nameVarLst;
        TextBox[] textBoxes;
        private void ParsingRequest() {
            nameVarLst = new List<string>();
            request = GetRequest();
            Regex regex = new Regex(@"declare @\w*\s");
            MatchCollection matches = regex.Matches(request);
            if (matches.Count > 0) {
                int i = 3;
                int index = 0;
                textBoxes = new TextBox[matches.Count];
                foreach(Match match in matches) {
                    Label label = new Label { Location = new Point(4, i), Font = new Font("Century Gothic", 12) };
                    string nameVar = match.Value.Substring(match.Value.IndexOf(' '), match.Length - match.Value.IndexOf(' ')).Trim(' ');
                    nameVarLst.Add(nameVar);
                    label.Text = nameVar + ":";
                    textBoxes[index] = new TextBox { Location = new Point(4, i + 25), Size = new Size(150, 20) };
                    PanelWithArg.Controls.Add(label);
                    PanelWithArg.Controls.Add(textBoxes[index]);
                    i += 50;
                }
                DoRequest.Location = new Point(DoRequest.Location.X, i);
            }
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
    }
}
