using Lab3;
using System.Windows.Forms;

namespace Lab3
{
    public partial class F3 : Form
    {
       public static  Products result = new Products();
        public F3()
        {
            InitializeComponent();
        }

        private void F3_Shown(object sender, System.EventArgs e)
        {
            dataGridView11.Rows.Clear();
            foreach (Product p in F3.result.list)
            {
                dataGridView11.Rows.Add();
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["nameProd"].Value = p.Name;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["numbProd"].Value = p.Number;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["weightProd"].Value = p.Weight;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["heightProd"].Value = p.Height;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["typeProd"].Value = p.type;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["countProd"].Value = p.Count;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["priceProd"].Value = p.Price;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["dateProd"].Value = p.Date;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["orgManuf"].Value = p.Manuf.Organization;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["adrManuf"].Value = p.Manuf.Adress;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["numbManuf"].Value = p.Manuf.PhoneNumb;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["fioStK"].Value = p.storekeeper.FIO;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["adrStK"].Value = p.storekeeper.Adress;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["expStK"].Value = p.storekeeper.Experience;
                dataGridView11.Rows[dataGridView11.RowCount - 1].Cells["dopProd"].Value = p.dopInf;
            }
        }
    }
}
