using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBeltCollection
    {

        //constructor
        public clsBeltCollection()
        {
            //instance of class
            clsDataConnection DB = new clsDataConnection();
            //execute stored proc
            DB.Execute("sproc_tblBelt_SelectAll");
            //get count
            Int32 RecordCount = DB.Count;
            //set up index for loop
            Int32 Index = 0;
            //while
            while (Index < RecordCount)
            {
                //instance of class
                clsBelt ABelt = new clsBelt();
                //get belt name
                ABelt.BeltName = DB.DataTable.Rows[Index]["BeltName"].ToString();
                //getPK
                ABelt.BeltNo = Convert.ToInt32(DB.DataTable.Rows[Index]["BeltNo"]);
                //private data member
                mAllBelts.Add(ABelt);
                //increment
                Index++;
            }

            ////instance of class
            //clsBelt ABelt = new clsBelt();
            ////set belt name
            //ABelt.BeltName = "Undisputed";
            ////add to list
            //mAllBelts.Add(ABelt);
            ////instance of class
            //ABelt = new clsBelt();
            ////set belt name
            //ABelt.BeltName = "Big Gold";
            ////add to list
            //mAllBelts.Add(ABelt);
        }
        private List<clsBelt> mAllBelts = new List<clsBelt>();

        public int Count
        {
            get
            {
                //return count
                return mAllBelts.Count;
            }
            set
            {
                //enter code
            }

        }

        //public list
        public List<clsBelt> AllBelts
        {
            //getter sends data
            get
            {
                //return private data member
                return mAllBelts;
            }
            //setter accepts data
            set
            {
                //assign values
                mAllBelts = value;
            }
        }
    }
}