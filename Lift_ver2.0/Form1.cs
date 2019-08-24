using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace Lift_ver2._0
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Documents\C# Projects\Lift_ver2.0\Lift_ver2.0\bin\Debug\log_book.mdb";
        }

        private void timer1_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label1.Left -= 2;
            if (label1.Left < 10)
            {
                timer21.Stop();
                timer22.Stop();
                timer23.Stop();
                timer24.Stop();
                timer17.Stop();
                timer18.Stop();
                timer19.Stop();
                timer20.Stop();
                timer15.Stop();
                timer16.Stop();
                timer13.Stop();
                timer14.Stop();
                timer9.Stop();
                timer10.Stop();
                timer7.Stop();
                timer8.Stop();
                timer5.Stop();
                timer6.Stop();
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label1.Left += 3;
            if (label1.Left > 100)
            {
                timer21.Stop();
                timer22.Stop();
                timer23.Stop();
                timer24.Stop();
                timer17.Stop();
                timer18.Stop();
                timer19.Stop();
                timer20.Stop();
                timer15.Stop();
                timer16.Stop();
                timer13.Stop();
                timer14.Stop();
                timer9.Stop();
                timer10.Stop();
                timer7.Stop();
                timer8.Stop();
                timer5.Stop();
                timer6.Stop();
                timer1.Start(); 
                timer2.Stop();
                timer1.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label2.Left += 3; 

            if (label2.Left < 220)
            {
                timer21.Stop();
                timer22.Stop();
                timer23.Stop();
                timer24.Stop();
                timer17.Stop();
                timer18.Stop();
                timer19.Stop();
                timer20.Stop();
                timer15.Stop();
                timer16.Stop();
                timer13.Stop();
                timer14.Stop();
                timer9.Stop();
                timer10.Stop();
                timer7.Stop();
                timer8.Stop();
                timer5.Stop();
                timer6.Stop();
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label2.Left -= 3;
            if (label2.Left > 100)
            {
                timer21.Stop();
                timer22.Stop();
                timer23.Stop();
                timer24.Stop();
                timer17.Stop();
                timer18.Stop();
                timer19.Stop();
                timer20.Stop();
                timer15.Stop();
                timer16.Stop();
                timer13.Stop();
                timer14.Stop();
                timer9.Stop();
                timer10.Stop();
                timer7.Stop();
                timer8.Stop();
                timer5.Stop();
                timer6.Stop();
                timer3.Start();
                timer4.Stop();
                timer3.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e) // Going to Floor 1
        {
            label1.Top += 3;
            if (label1.Top > 100)
            {
                timer5.Stop();
                timer7.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e) // Going to Floor 1
        {
            label2.Top += 3; 
            if(label2.Top > 100)
            {
                timer6.Stop();
                timer8.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e) // Going to Floor 1
        {
            label1.Top -= 3;
            if (label1.Top < 10)
            {
                timer5.Start(); 
                timer7.Stop();
                timer5.Stop();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)// Going to Floor 1
        {
            label2.Top -= 3;
            if (label2.Top < 10)
            {
                timer6.Start();
                timer8.Stop();
                timer6.Stop();
                timer9.Start();
                timer11.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label1.Left -= 2;
            if (label1.Left < 10)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label1.Left += 3;
            if (label1.Left > 98)
            {
                timer9.Start();
                timer10.Stop();
                timer9.Stop();
            }
        }

        private void timer11_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label2.Left += 3;

            if (label2.Left > 220)
            {
                timer11.Stop();
                timer12.Start();
            }
        }

        private void timer12_Tick(object sender, EventArgs e) // Open and close door automatic
        {
            label2.Left -= 3;
            if (label2.Left < 100)
            {
                timer11.Start();
                timer12.Stop();
                timer11.Stop();
            }
        }

        private void timer13_Tick(object sender, EventArgs e) // Open door manually 
        {
            label1.Left -= 3;
            if (label1.Left < 1)
            {
                timer13.Stop();
            }
        }

        private void timer14_Tick(object sender, EventArgs e) // Open door manually 
        {
            label1.Left += 3;
            if (label1.Left > 1)
            {
                timer13.Start();
                timer14.Stop();
            }
        }

        private void timer15_Tick(object sender, EventArgs e) // Open door manually 
        {
            label2.Left += 3;
            if (label2.Left > 180)
            {
                timer15.Stop();
            }
        }

        private void timer16_Tick(object sender, EventArgs e) // Open door manually 
        {
            label2.Left -= 3;
            if (label2.Left < 180)
            {
                timer15.Start();
                timer16.Stop();
            }
        }

        private void timer17_Tick(object sender, EventArgs e) // Going to Floor 0
        {
            label1.Top -= 3;
            if (label1.Top < 10)
            {
                timer17.Stop();
                timer19.Start();
            }
        }

        private void timer18_Tick(object sender, EventArgs e) // Going to Floor 0
        {
            label2.Top -= 3;
            if (label2.Top < 10)
            {
                timer18.Stop();
                timer20.Start();
            }
        }

        private void timer19_Tick(object sender, EventArgs e) // Going to Floor 0
        {
            label1.Top += 3;
            if (label1.Top > 300)
            {
                timer17.Start();
                timer19.Stop();
                timer17.Stop();
            }
        }

        private void timer20_Tick(object sender, EventArgs e) // Going to Floor 0
        {
            label2.Top += 3;
            if (label2.Top > 300)
            {
                timer18.Start();
                timer18.Stop();
                timer20.Stop();
                timer9.Start();
                timer11.Start();
            }
        }

        private void timer21_Tick(object sender, EventArgs e) // Close door manually 
        {
            label1.Left += 3;
            if (label1.Left > 100)
            {
                timer21.Stop();
            }
        }

        private void timer22_Tick(object sender, EventArgs e) // Close door manually
        {
            label1.Left += 3;
            if (label1.Left > 1)
            {
                timer21.Start();
                timer22.Stop();
            }
        }

        private void timer23_Tick(object sender, EventArgs e) // Close door manually
        {
            label2.Left -= 3;
            if (label2.Left < 100)
            {
                timer23.Stop();
            }
        }

        private void timer24_Tick(object sender, EventArgs e) // Close door manually
        {
            label2.Left -= 3;
            if (label2.Left > 1)
            {
                timer23.Start();
                timer24.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer6.Enabled = true;
            label10.Text = "Floor 1";
            try
            {
                connection.Open();//connection open. 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = command.CommandText = @"insert into [Log] ( [Current log] ) values (?)";
                command.Parameters.AddWithValue("Current log", DateTime.Now.Date);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer6.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer17.Enabled = true;
            timer18.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer13.Enabled = true;
            timer14.Enabled = true;
            timer15.Enabled = true;
            timer16.Enabled = true;
            label10.Text = "Close Door";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer13.Enabled = true;
            timer14.Enabled = true;
            timer15.Enabled = true;
            timer16.Enabled = true;
            label10.Text = "Close Door";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer21.Enabled = true;
            timer22.Enabled = true;
            timer23.Enabled = true;
            timer24.Enabled = true;
            label10.Text = "Select Floor";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer13.Enabled = true;
            timer14.Enabled = true;
            timer15.Enabled = true;
            timer16.Enabled = true;
            label10.Text = "Close Door";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Log";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; 


                connection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex); 
            } 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer17.Enabled = true;
            timer18.Enabled = true;
            label10.Text = "Floor 0";
            try
            {
                connection.Open();//connection open. 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = command.CommandText = @"insert into [Log] ( [Current log] ) values (?)";
                command.Parameters.AddWithValue("Current log", DateTime.Now.Date);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
