using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoCoordinatePortable;
using Npgsql;

namespace Airports
{
    public partial class FormMain : Form
    {
        public string lat_a, long_a, lat_b, long_b;
        //public DataSet ds = new DataSet();
        //DataTable dtairports = new DataTable("airports");
        //public NpgsqlDataAdapter air = new NpgsqlDataAdapter();

        public FormMain()
        {
            InitializeComponent();

        }

        private void btn_valA_Click(object sender, EventArgs e)
        {
            FormCon formcon = this.Owner as FormCon;//ASK ABOUT THIS MOVE
            StringBuilder stringBuilder = new StringBuilder();
            if ((txt_inputA.Text) != "")
            {
                try
                {
                    richTextBox1.Text = "";
                    string selct = ("SELECT airport, city , region, latitude , longitude  FROM airports WHERE airport = '" + txt_inputA.Text + "';");
                    NpgsqlCommand cmd = new NpgsqlCommand(selct, formcon.conn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        stringBuilder.Append(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + "\n");
                        this.lat_a = reader.GetString(3);
                        this.long_a = reader.GetString(4);
                    }
                    richTextBox1.Text = stringBuilder.ToString();
                    MessageBox.Show("Lattitude a= " + lat_a + " Longitude= " + long_a);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = "Not found, reference: " + ex;
                }
                finally
                {
                    lbl_validatedA.Show();
                }
            }
            else
            {
                richTextBox1.Text = "No data to commit";
            }


        }

        private void btn_valB_Click(object sender, EventArgs e)
        {
            FormCon formcon = this.Owner as FormCon;
            StringBuilder stringBuilder = new StringBuilder();
            if ((txt_inputB.Text) != "")
            {
                try
                {
                    richTextBox2.Text = "";
                    string selct = ("SELECT airport, city , region, latitude , longitude  FROM airports WHERE airport = '" + txt_inputB.Text + "';");
                    NpgsqlCommand cmd = new NpgsqlCommand(selct, formcon.conn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        stringBuilder.Append(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + "\n");
                        this.lat_b = reader.GetString(3);
                        this.long_b = reader.GetString(4);
                    }
                    richTextBox2.Text = stringBuilder.ToString();
                    MessageBox.Show("Lattitude a= " + lat_b + " Longitude= " + long_b);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    richTextBox2.Text = "Not found, reference: " + ex;
                }
                finally
                {
                    lbl_validatedB.Show();
                }
            }
            else
            {
                richTextBox2.Text = "No data to commit";
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            GeoCoordinate geo1 = new GeoCoordinate(Convert.ToDouble(lat_a, CultureInfo.InvariantCulture), Convert.ToDouble(long_a, CultureInfo.InvariantCulture));
            GeoCoordinate geo2 = new GeoCoordinate(Convert.ToDouble(lat_b, CultureInfo.InvariantCulture), Convert.ToDouble(long_b, CultureInfo.InvariantCulture));
            double dist = (geo1.GetDistanceTo(geo2));
            MessageBox.Show(dist.ToString());
        }

        public void btn_search_Click(object sender, EventArgs e)
        {
            switch (chk_search.Text)
            {
                case "Country":
                    {
                        try
                        {

                            FormCon formcon = this.Owner as FormCon;
                            string selct = ("SELECT id, airport, city , country, region, latitude , longitude, utc  FROM airports WHERE country = '" + textBox1.Text + "';");
                            NpgsqlCommand cmd = new NpgsqlCommand(selct, formcon.conn);
                            NpgsqlDataAdapter air = new NpgsqlDataAdapter();
                            air.SelectCommand = cmd;
                            DataSet ds = new DataSet();
                            ds.Tables.Add(new DataTable("airports"));
                            ds.Tables[0].BeginLoadData();
                            air.Fill(ds, "airports");
                            ds.Tables[0].EndLoadData();
                            datagrid_search.DataSource = ds.Tables[0].DefaultView;
                            datagrid_search.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                            break;
                        }
                        catch (Exception ex)
                        {
                            richTextBox2.Text = "Not found, reference: " + ex; break;
                        }
                    }
                case "City":
                    {
                        FormCon formcon = this.Owner as FormCon;
                        string selct = ("SELECT id, airport, city , country, region, latitude , longitude, utc  FROM airports WHERE city = '" + textBox1.Text + "';");
                        NpgsqlCommand cmd = new NpgsqlCommand(selct, formcon.conn);
                        NpgsqlDataAdapter air = new NpgsqlDataAdapter();
                        air.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        ds.Tables.Add(new DataTable("airports"));
                        ds.Tables[0].BeginLoadData();
                        air.Fill(ds, "airports");
                        ds.Tables[0].EndLoadData();
                        datagrid_search.DataSource = ds.Tables[0].DefaultView;
                        break;
                    }
                case "Region":
                    {
                        FormCon formcon = this.Owner as FormCon;
                        string selct = ("SELECT id, airport, city , country, region, latitude , longitude, utc  FROM airports WHERE region LIKE '%" + textBox1.Text + "%';");
                        NpgsqlCommand cmd = new NpgsqlCommand(selct, formcon.conn);
                        NpgsqlDataAdapter air = new NpgsqlDataAdapter();
                        air.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        ds.Tables.Add(new DataTable("airports"));
                        ds.Tables[0].BeginLoadData();
                        air.Fill(ds, "airports");
                        ds.Tables[0].EndLoadData();
                        datagrid_search.DataSource = ds.Tables[0].DefaultView;
                        break;
                    }
                default:
                    {
                        textBox1.Text = "Choose option"; break;
                    }


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //FormCon formcon = this.Owner as FormCon;
            //DataTable dtupd = ds.Tables[0].GetChanges(DataRowState.Added);
            //air.Update(dtupd);
            //NpgsqlCommand addair = new NpgsqlCommand("INSERT INTO airports");
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Use search window to update or add additional airports to database. That data can be used to calculate any point on earth you need..";
            richTextBox2.Text = "Use free row to input data. Please ensure that at least airport, latitude and longitude are filled correctly. After, press Submit button to save changes to DB. Data cannot be deleted due to safety reasons. Please contact admin to clear unused data.";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
