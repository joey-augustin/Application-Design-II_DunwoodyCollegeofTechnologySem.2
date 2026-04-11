using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dunwoody_Park_Member_Management_System
{
    public partial class FrmMembers : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DunwoodyParkDB;Integrated Security=True;");
        SqlCommand cmd;

        string mode = "";
        int selectedID = 0;

        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {

            this.dunwoodyParkTableAdapter.Fill(this.dunwoodyParkDBDataSet.DunwoodyPark);
            SetupComboBoxes();

            ResetForm();
            LoadMembers();
        }

        private void SetupComboBoxes()
        {

            cbox_gender.Items.Clear();
            cbox_gender.Items.Add("M");
            cbox_gender.Items.Add("F");
            cbox_gender.Items.Add("O");
            cbox_gender.SelectedIndex = -1;


            cbox_membershipType.Items.Clear();
            cbox_membershipType.Items.Add("Student");
            cbox_membershipType.Items.Add("Faculty");
            cbox_membershipType.SelectedIndex = -1; 
        }

        public void LoadMembers()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DunwoodyPark", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid_DunwoodyParks.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void ResetForm()
        {
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_phoneNumber.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            cbox_gender.SelectedIndex = -1;
            cbox_membershipType.SelectedIndex = -1;
            dtPicker_joinDate.Value = DateTime.Now;

            btn_add.Show();
            btn_update.Show();
            btn_delete.Show();
            btn_view.Show();

            btn_add.Enabled = true;
            btn_view.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            mode = "";
            selectedID = 0;

        }

        private void dataGrid_DunwoodyParks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_DunwoodyParks.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells[6].Value);

                txt_firstName.Text = row.Cells[0].Value.ToString();
                txt_lastName.Text = row.Cells[1].Value.ToString();
                txt_phoneNumber.Text = row.Cells[2].Value.ToString();
                cbox_gender.Text = row.Cells[3].Value.ToString();
                txt_email.Text = row.Cells[4].Value.ToString();
                txt_address.Text = row.Cells[5].Value.ToString();
                cbox_membershipType.Text = row.Cells[7].Value.ToString();
                dtPicker_joinDate.Value = Convert.ToDateTime(row.Cells[8].Value);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "" || txt_lastName.Text == "")
            {
                MessageBox.Show("First and Last Name are required.");
                return;
            }

            try
            {
                conn.Open();

                string insertQuery = @"INSERT INTO DunwoodyPark
                (FirstName, LastName, PhoneNumber, Gender, Email, Address, MemberType, JoinDate)
                VALUES
                (@FirstName, @LastName, @PhoneNumber, @Gender, @Email, @Address, @MemberType, @JoinDate)";

                cmd = new SqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txt_phoneNumber.Text);
                cmd.Parameters.AddWithValue("@Gender", cbox_gender.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                cmd.Parameters.AddWithValue("@MemberType", cbox_membershipType.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dtPicker_joinDate.Value);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Member added successfully!");

                LoadMembers();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Select a member first.");
                return;
            }

            try
            {
                conn.Open();

                string updateQuery = @"UPDATE DunwoodyPark SET
                FirstName = @FirstName,
                LastName = @LastName,
                PhoneNumber = @PhoneNumber,
                Gender = @Gender,
                Email = @Email,
                Address = @Address,
                MemberType = @MemberType,
                JoinDate = @JoinDate
                WHERE MemberID = @ID";

                cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txt_phoneNumber.Text);
                cmd.Parameters.AddWithValue("@Gender", cbox_gender.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                cmd.Parameters.AddWithValue("@MemberType", cbox_membershipType.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dtPicker_joinDate.Value);
                cmd.Parameters.AddWithValue("@ID", selectedID);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Member updated successfully!");

                LoadMembers();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Select a member first.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM DunwoodyPark WHERE MemberID=@ID";
                    cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Member deleted.");
                    LoadMembers();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

    }
}
