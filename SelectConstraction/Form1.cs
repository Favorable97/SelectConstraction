using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectConstraction {
    public partial class Form1 : Form {

        readonly string connectionString = @"Data Source=SRZ\SRZ;Initial Catalog=ident;User ID=user;Password=гыук";

        public Form1() {
            InitializeComponent();
        }
        
        private void AddRequest_Click(object sender, EventArgs e) {
            this.AutoSize = true;
            PanelWithElementForAddRequest.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.AutoSize = false;
            this.Size = new Size(394, 300);
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
    }
}
