using System.Data;

namespace Data_Grid_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nome", typeof(string));

            DataRow linhaData1 = dt.NewRow();
            linhaData1["id"] = 1;
            linhaData1["nome"] = "Samira";
            dt.Rows.Add(linhaData1);

            DataRow linhaData2 = dt.NewRow();
            linhaData2["id"] = 2;
            linhaData2["nome"] = "Alvaro";
            dt.Rows.Add(linhaData2);

            DataRow linhaData3 = dt.NewRow();
            linhaData3["id"] = 3;
            linhaData3["nome"] = "Pedro";
            dt.Rows.Add(linhaData3);

            dataGridView1.DataSource = dt;
        }
    }
}