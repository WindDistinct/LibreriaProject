using System.Data;
using System.Data.SqlClient;

namespace LibreriaProyect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=sa;Encrypt=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPassword.Text;

            try
            {
                String query = "Select * from tb_user where username = '" + txtUser.Text + "' and password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    user = txtUser.Text;
                    pass = txtPassword.Text;

                    MainMenu form2 = new MainMenu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales erroneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtPassword.Clear();

                    txtUser.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
