using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace Airports;

public partial class FormCon : Form
{
    public NpgsqlConnection conn;
    public FormCon()
    {
        InitializeComponent();
    }

    private void btn_connect_Click(object sender, EventArgs e)
    {
        //Server = 127.0.0.1; Port = 5432; Database = myDataBase; User Id = myUsername; Password = myPassword;
        string connectionString = string.Format("Server = {0};Port=5432;Database={1};Username={2};Password={3};", txt_pgserver.Text, txt_pgdb.Text, txt_login.Text, txt_password.Text);
        conn = new NpgsqlConnection(connectionString);
        try
        {
            conn.Open();
            lbl_status.Text = "Connection Successful!";
            FormMain mform = new FormMain();
            mform.Show(this);

        }
        catch (NpgsqlException ex)
        {
            lbl_status.Text = ex.Message;
        }
        catch (Exception ex)
        {
            lbl_status.Text = ex.Message;
        }

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        txt_pgserver.Text = "localhost";
        txt_pgdb.Text = "aviation";
        txt_login.Text = "Biker";
        txt_password.Text = "password";
    }
}
