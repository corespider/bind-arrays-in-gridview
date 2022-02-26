using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BindArrays
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ComposeGridBind();
        }
        public void ComposeGridBind()
        {
            //1-Dimensional Array

            string[] arr1D = { "Ram", "John", "Stewart", "Sham", "Tod", "Bryan" };

            gridView1.DataSource = arr1D;

            gridView1.DataBind();

            //Tow Dimensional Array

            string[,] arr2D = {

                    { "Ram", "India" },
                    { "John", "USA" },
                    { "Stewart", "UK" },
                    { "Sham", "India"},
                    { "Tod","USA" },
                    { "Bryan","Russia" }
                 };
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                arrList.Add(new ListItem(arr2D[i, 0], arr2D[i, 1]));
            }
            gridView2.DataSource = arrList;
            gridView2.DataBind();

            //Multi Dimensional Array

            string[,] arrMultiD = {

                    { "Ram","Delhi", "India" },
                    { "John", "WS DC","USA" },
                    { "Stewart","London", "UK" },
                    { "Sham","Mumbai", "India"},
                    { "Tod","Florida","USA" },
                    { "Bryan","Kitet","Russia" }
                 };

            DataTable dt = new DataTable();

            dt.Columns.Add("Name", Type.GetType("System.String"));

            dt.Columns.Add("City", Type.GetType("System.String"));

            dt.Columns.Add("Country", Type.GetType("System.String"));

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add();
                dt.Rows[dt.Rows.Count - 1]["Name"] = arrMultiD[i, 0];
                dt.Rows[dt.Rows.Count - 1]["City"] = arrMultiD[i, 1];
                dt.Rows[dt.Rows.Count - 1]["Country"] = arrMultiD[i, 2];
            }

            gridView3.DataSource = dt;

            gridView3.DataBind();
        }
    }
}