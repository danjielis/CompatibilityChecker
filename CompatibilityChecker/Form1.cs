using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompatibilityChecker
{
    public partial class Form1 : Form
    {
        List<Harness_drawing> Harness_drawing_list;
        List<Harness_wires> Harness_wires_list;

        public Form1()
        {
            InitializeComponent();

            // init required datagrid view
            Initialize_datagrid_view();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // auto gen
            // TODO: This line of code loads data into the 'database1DataSet.Harness_wires' table. You can move, or remove it, as needed.
            this.harness_wiresTableAdapter.Fill(this.database1DataSet.Harness_wires);
            // TODO: This line of code loads data into the 'database1DataSet.Harness_drawing' table. You can move, or remove it, as needed.
            this.harness_drawingTableAdapter.Fill(this.database1DataSet.Harness_drawing);

            // fetch database tables into app objs
            Harness_drawing_list = new List<Harness_drawing>();
            Fetch_DB_content_into_Harness_drawing_list();
            Harness_wires_list = new List<Harness_wires>();
            Fetch_DB_content_into_Harness_wires_list();
        }

        private void Fetch_DB_content_into_Harness_drawing_list()
        {
            // select first dataset table
            DataTable dt = database1DataSet.Harness_drawing;
            // fill object list 
            foreach(DataRow dr in dt.Rows)
            {
                Harness_drawing hd = new Harness_drawing();
                hd.ID               = Convert.ToInt32(dr[0]);
                hd.Harness          = Convert.ToString(dr[1]);
                hd.Harness_version  = Convert.ToString(dr[2]);
                hd.Drawing          = Convert.ToString(dr[3]);
                hd.Drawing_version  = Convert.ToString(dr[4]);
                this.Harness_drawing_list.Add(hd);
            }
        }

        private void Fetch_DB_content_into_Harness_wires_list()
        {
            // select second dataset table
            DataTable dt = database1DataSet.Harness_wires;
            // fill object list
            foreach(DataRow dr in dt.Rows)
            {
                Harness_wires hw = new Harness_wires();
                hw.ID               = Convert.ToInt32(dr[0]);
                hw.Harness_ID       = Convert.ToInt32(dr[1]);
                hw.Length           = Convert.ToDouble(dr[2]);
                hw.Color            = Convert.ToString(dr[3]);
                hw.Housing_1        = Convert.ToString(dr[4]);
                hw.Housing_2        = Convert.ToString(dr[5]);
                this.Harness_wires_list.Add(hw);
            }
        }

        private void Initialize_datagrid_view()
        {
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.ColumnHeadersVisible = true;
            this.dataGridView1.Columns[0].Name = "Harness ID 1 version";
            this.dataGridView1.Columns[1].Name = "Harness ID 2 version";
            this.dataGridView1.Columns[2].Name = "Drawing ID version";
            this.dataGridView1.Columns[3].Name = "Housing";
        }

        private void Generuoti_Click(object sender, EventArgs e)
        {
            // clear
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            this.textBox1.Text = "";

            // rnd obj, rnd collection, rnd wire collections (two collections since it is assumed that duplicates exists on one side only, either h1 or h2)
            Random rnd = new Random();
            List<Harness_drawing> Random_harness_drawing_list;
            List<Harness_wires> Random_harness_wire_list_housing1;
            List<Harness_wires> Random_harness_wire_list_housing2;

            for (int outer_loop = 0; outer_loop < 1; outer_loop++) //for multiple run test
            {
                // each iteration init empty rnd collection
                Random_harness_drawing_list = new List<Harness_drawing>();
                Random_harness_wire_list_housing1 = new List<Harness_wires>();
                Random_harness_wire_list_housing2 = new List<Harness_wires>();

                // get rnd number of selections to be made (range 3:4)
                int selection_count = rnd.Next(3, 5);
                for (int harnesses = 0; harnesses < selection_count; harnesses++)
                {
                    // for a number of selections in range select rnd harness IDs
                    Random_harness_drawing_list.Add(Harness_drawing_list[rnd.Next(0, Harness_drawing_list.Count)]);
                }

                foreach (Harness_drawing hd in Random_harness_drawing_list)
                {
                    this.textBox1.Text += hd.ID + " "; //just for task understanding
                }


                // check whether rnd harness collection' wires do not contain duplicates, if so add datagrid row msg in req format
                // for each harness out of rnd list of harnesses
                foreach (Harness_drawing rhd in Random_harness_drawing_list)
                {
                    // and each coresponding wire, that has the same harness ID
                    foreach (Harness_wires hw in Harness_wires_list.FindAll(i => i.Harness_ID == rhd.ID))
                    {
                        Harness_wires temp_hw_h1 = Random_harness_wire_list_housing1.Find(x => x.Housing_1 == hw.Housing_1);
                        Harness_wires temp_hw_h2 = Random_harness_wire_list_housing2.Find(x => x.Housing_2 == hw.Housing_2);

                        // if temp housing list does not containt certain wire, add it
                        // else if contains, then print that a duplicate has been found

                        if (temp_hw_h1 == null)
                            Random_harness_wire_list_housing1.Add(hw);
                        else
                        {
                            Harness_drawing first = Harness_drawing_list.Find(x => x.ID == temp_hw_h1.Harness_ID);
                            Harness_drawing second = Harness_drawing_list.Find(x => x.ID == hw.Harness_ID);

                            this.dataGridView1.Rows.Add(temp_hw_h1.Harness_ID.ToString() + ", version: " + first.Harness_version, 
                                                        hw.Harness_ID.ToString() + ", version: " + second.Harness_version, 
                                                        first.Drawing_version,
                                                        hw.Housing_1);
                            break;
                        }


                        if (temp_hw_h2 == null)
                            Random_harness_wire_list_housing2.Add(hw);
                        else
                        {
                            Harness_drawing first = Harness_drawing_list.Find(x => x.ID == temp_hw_h2.Harness_ID);
                            Harness_drawing second = Harness_drawing_list.Find(x => x.ID == hw.Harness_ID);

                            this.dataGridView1.Rows.Add(temp_hw_h2.Harness_ID.ToString() + ", version: " + first.Harness_version,
                                                        hw.Harness_ID.ToString() + ", version: " + second.Harness_version,
                                                        first.Drawing_version,
                                                        hw.Housing_2);
                            break;
                        }

                    }
                }
            }
        }
    }
}
