using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Crud_App
{
    public partial class Form1 : Form

    {
        public void clearAllText() 
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V55V5IC\\SQLEXPRESS;Initial Catalog=CRUD_APP;Integrated Security=True");

            con.Open();

            

            SqlCommand cmd = new SqlCommand("Insert into customers values(@id,@name,@email,@phone)",con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data saved successfully");

            clearAllText();


        }
    }
}