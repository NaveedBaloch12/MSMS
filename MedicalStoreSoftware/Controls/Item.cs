using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware.Controls
{
    public partial class Item : UserControl
    {
        public Item(string prdID, string prdName, int pricePI, int Quantity, string Size)
        {
            InitializeComponent();

            lbprdID.Text = prdID;
            lbprdName.Text = prdName;
            lbprdPricePI.Text = Convert.ToString(pricePI);
            lbprdQuantity.Text = Convert.ToString(Quantity);
            lbprdSize.Text = Convert.ToString(Size);
            lbprdTPrice.Text = Convert.ToString(pricePI * Quantity);
        }


        //#region Properties

        //private string _prdID;
        //private string _preName;
        //private int _pricePI;
        //private int _Quantity;
        //private string _Size;
        //private int _TPrice;

        //public string prdID
        //{
        //    get { return _prdID; }
        //    set { _prdID = value; }
        //}

        //public string Name
        //{
        //    get { return _preName; }
        //    set { _preName = value;  }
        //}

        //public int pricePI
        //{
        //    get { return _pricePI; }
        //    set { _pricePI = value; }
        //}

        //public int prdQuantity
        //{
        //    get { return _Quantity; }
        //    set { _Quantity = value; }
        //}

        //public string prdSize
        //{
        //    get { return _Size; }
        //    set { _Size = value; }
        //}

        //public int TPrice
        //{
        //    get { return _TPrice; }
        //    set { _TPrice = value; }
        //}

        //#endregion


    }
}
