using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Genesys_DashBoard
{
    class ListViewColumnSorter : IComparer
    {
        /// Specifies the column to be sorted
        private int ColumnToSort;

        /// Specifies the order in which to sort (i.e. 'Ascending').
        private SortOrder OrderOfSort;

        /// Case insensitive comparer object
        private CaseInsensitiveComparer ObjectCompare;

        /// Class constructor.  Initializes various elements
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items
            //Check if the string as Gb or % in it
            string strx = listviewX.SubItems[ColumnToSort].Text;
            string stry = listviewY.SubItems[ColumnToSort].Text;

            compareResult=0;

            try
            {


                if (Convert.ToDouble(strx).ToString() == strx && Convert.ToDouble(stry).ToString() == stry)
                {
                    double fx = 0;
                    double fy = 0;
                    fx = Convert.ToDouble(strx);
                    fy = Convert.ToDouble(stry);
                    compareResult = ObjectCompare.Compare(fx, fy);
                }
            }
            catch (Exception e) { }

            try
            {
                if ((strx.Substring(strx.Length - 2, 2) == "Gb" || strx.Substring(strx.Length - 1, 1) == "%"))
                {
                    double fx = 0;
                    double fy = 0;

                    if (strx.Substring(strx.Length - 2, 2) == "Gb")
                    {
                        fx = Convert.ToDouble(strx.Substring(0, strx.Length - 2));
                        fy = Convert.ToDouble(stry.Substring(0, stry.Length - 2));
                    }

                    if (strx.Substring(strx.Length - 1, 1) == "%")
                    {
                        fx = Convert.ToDouble(strx.Substring(0, strx.Length - 1));
                        fy = Convert.ToDouble(stry.Substring(0, stry.Length - 1));
                    }

                    compareResult = ObjectCompare.Compare(fx, fy);
                }
                else
                {
                    compareResult = ObjectCompare.Compare(strx, stry);
                }
            }
            catch (Exception e) {  }

            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }

        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
    }
}
