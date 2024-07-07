using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware
{
    public static class Globals
    {
        // Variables....................
        public static Color headerColor = Color.SteelBlue;
        public static Color navbarColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        public static Color header_navbar_txt_Color = Color.White;
        public static Color BtnColors = Color.LightSteelBlue;
        public static Color BackGround = Color.White;

       
        // Functions....................
        public static void ChangeBGClr(int choice)
        {
            if (choice == 0)
                BackGround = Color.White;
            if (choice == 1)
                BackGround = Color.LightGray;
            if (choice == 2)
                BackGround = Color.Gray;
        }

        public static void footerText(Label lb, string Text, bool visible)
        {
            lb.Visible = visible;
            lb.Text = Text;
        }

        // functions to clear reset textboxes
        public static void CleartxtBoes(TextBox txtb1, TextBox txtb2)
        {
            txtb1.Text = "";
            txtb2.Text = "";
        }
        public static void CleartxtBoes(TextBox txtb1, TextBox txtb2, TextBox txtb3)
        {
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
        }
        public static void CleartxtBoes(TextBox txtb1, TextBox txtb2, TextBox txtb3, TextBox txtb4)
        {
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txtb4.Text = "";
        }
        public static void CleartxtBoes(TextBox txtb1, TextBox txtb2, TextBox txtb3, TextBox txtb4,TextBox txtb5)
        {
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txtb4.Text = "";
            txtb5.Text = "";
        }

        public static void CleartxtBoes(TextBox txtb1, TextBox txtb2, TextBox txtb3, TextBox txtb4, TextBox txtb5, TextBox txtb6)
        {
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txtb4.Text = "";
            txtb5.Text = "";
            txtb6.Text = "";
        }



        public struct Product
        {
            public string prdID;
            public string prdName;
            public int prdQuantity;
            public int pricePI;
            public string prdSize;
            public int TPrice;

            public int TotalPrice()
            {
                TPrice = pricePI * prdQuantity;
                return TPrice;
            }
        };
    }
}
