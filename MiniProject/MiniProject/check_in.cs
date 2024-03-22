using Microsoft.VisualBasic.ApplicationServices;
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

namespace MiniProject
{
    public partial class check_in : Form
    {
        public check_in()
        {
            InitializeComponent();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC17\SQLEXPRESS; Initial Catalog=Hotel; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT AvailabilityRoom FROM Rooms WHERE RoomNumber = @RoomNumber";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@RoomNumber", RoomNumber.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    // Room is available, proceed with booking
                    string insertQuery = "INSERT INTO checkedIn VALUES (@rNumber, @gName, @pNumber, @ciDate, @coDate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@rNumber", RoomNumber.Text);
                    insertCmd.Parameters.AddWithValue("@gName", guestName.Text);
                    insertCmd.Parameters.AddWithValue("@pNumber", phoneNumber.Text);
                    insertCmd.Parameters.AddWithValue("@ciDate", checkInDate.Value);
                    insertCmd.Parameters.AddWithValue("@coDate", checkOutDate.Value);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE Rooms SET AvailabilityRoom = 'Occupied' WHERE RoomNumber = @rNumber";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@rNumber", RoomNumber.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the room is not available for booking.");
                }
            }
        }
    }
}
