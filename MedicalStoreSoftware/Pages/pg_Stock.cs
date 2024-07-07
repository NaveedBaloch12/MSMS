using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware.Pages
{
    public partial class pg_Stock : UserControl
    {
        public pg_Stock()
        {
            InitializeComponent();
        }
        static string ConnectionString = "Data Source=NAVEED-PC;Initial Catalog=MSMS;Integrated Security=True";
        static string PurchaseDGVQuery = "SELECT M_ID AS ID, M_Name AS Name, M_Price AS Price, M_Quantity AS Quantity, M_Size AS Size, M_Type AS [Type], M_Company Company FROM Products";
        SQLAdapter SQLConnstion = new SQLAdapter(ConnectionString);

        // Events..................
        private void pg_Stock_Load(object sender, EventArgs e)
        {
            SQLConnstion.DisplayDGV(dgv_AllStock, PurchaseDGVQuery);
        }
    }
}
