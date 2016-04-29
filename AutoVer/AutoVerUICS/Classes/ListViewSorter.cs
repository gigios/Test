using System;
using System.Collections;
using System.Windows.Forms;

namespace AutoVerUICS.Classes
{
    public class ListViewSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;

        private CaseInsensitiveComparer ObjectCompare;
        public ListViewSorter()
        {
            // Initialize the column to '0'.
            ColumnToSort = 0;

            // Initialize the sort order to 'none'.
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object.
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int compareResult = 0;
            ListViewItem listviewX = default(ListViewItem);
            ListViewItem listviewY = default(ListViewItem);

            // Cast the objects to be compared to ListViewItem objects.
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items. Try converting to date, size, and decimal before sorting.
            decimal decX = default(decimal);
            decimal decY = default(decimal);
            string strX = null;
            string strY = null;
            strX = listviewX.SubItems[ColumnToSort].Text;
            strY = listviewY.SubItems[ColumnToSort].Text;
            DateTime datX = default(DateTime);
            DateTime datY = default(DateTime);
            if (DateTime.TryParse(strX, out datX) & DateTime.TryParse(strY, out datY))
            {
                compareResult = ObjectCompare.Compare(datX, datY);
            }
            else if (strX.EndsWith("KB") & strY.EndsWith("KB"))
            {
                strX = strX.Replace("KB", string.Empty);
                strY = strY.Replace("KB", string.Empty);
                if (decimal.TryParse(strX, out decX) & decimal.TryParse(strY, out decY))
                {
                    compareResult = ObjectCompare.Compare(decX, decY);
                }
                else
                {
                    compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                }
            }
            else if (decimal.TryParse(strX, out decX) & decimal.TryParse(strY, out decY))
            {
                compareResult = ObjectCompare.Compare(decX, decY);
            }
            else
            {
                compareResult = ObjectCompare.Compare(strX, strY);
            }
            // Calculate the correct return value based on the object 
            // comparison.
            if ((OrderOfSort == SortOrder.Ascending))
            {
                // Ascending sort is selected, return typical result of 
                // compare operation.
                return compareResult;
            }
            else if ((OrderOfSort == SortOrder.Descending))
            {
                // Descending sort is selected, return negative result of 
                // compare operation.
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate that they are equal.
                return 0;
            }
        }

        public int SortColumn
        {
            get { return ColumnToSort; }
            set { ColumnToSort = value; }
        }

        public SortOrder Order
        {
            get { return OrderOfSort; }
            set { OrderOfSort = value; }
        }

    }
}
