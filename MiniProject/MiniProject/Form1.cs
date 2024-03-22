using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static MiniProject.authenticate;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        private User authenticatedUser;
        public Form1(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
            usernameLabel.Text = $"Welcome, {authenticatedUser.Username}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoomType.SelectedIndex = 0;
            AvailabilityRoom.SelectedIndex = 0;
            Cleaning.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC17\SQLEXPRESS; Initial Catalog=Hotel; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Rooms WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (Cleaning.SelectedItem != null)
                    conditions.Add("Cleaning = @Cleaning");

                if (RoomType.SelectedItem != null)
                    conditions.Add("RoomType = @RoomType");

                if (AvailabilityRoom.SelectedItem != null)
                    conditions.Add("AvailabilityRoom = @AvailabilityRoom");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@Cleaning", Cleaning.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@RoomType", RoomType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@AvailabilityRoom", AvailabilityRoom.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            RoomType.SelectedIndex = 0;
            AvailabilityRoom.SelectedIndex = 0;
            Cleaning.SelectedIndex = 0;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            using (check_in userInputForm = new check_in())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }
    }
}