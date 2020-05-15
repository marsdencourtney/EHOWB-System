using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsBelt
    {
        private Int32 mBeltNo;

        // BeltNo public property.
        public Int32 BeltNo
        {
            get
            {
                // This line of code sends data out of the property.
                return mBeltNo;
            }
            set
            {
                // This line of code allows data into the property.
                mBeltNo = value;
            }
        }

        // BeltName private member variable.
        private string mBeltName;

        // BeltName public property.
        public string BeltName
        {
            get
            {
                // This line of code sends data out of the property.
                return mBeltName;
            }
            set
            {
                // This line of code allows data into the property.
                mBeltName = value;
            }
        }

        // BrandNo private member variable.
        private Int32 mBrandNo;

        // BrandNo public property.
        public Int32 BrandNo
        {
            get
            {
                // This line of code sends data out of the property.
                return mBrandNo;
            }
            set
            {
                // This line of code allows data into the property.
                mBrandNo = value;
            }
        }

        // ManufacturerNo private member variable.
        private Int32 mManufacturerNo;

        // ManufacturerNo public property.
        public Int32 ManufacturerNo
        {
            get
            {
                // This line of code sends data out of the property.
                return mManufacturerNo;
            }
            set
            {
                // This line of code allows data into the property.
                mManufacturerNo = value;
            }
        }

        // BeltDescription private member variable.
        private string mBeltDescription;

        // BeltDescription public property.
        public string BeltDescription
        {
            get
            {
                // This line of code sends data out of the property.
                return mBeltDescription;
            }
            set
            {
                // This line of code allows data into the property.
                mBeltDescription = value;
            }
        }

        public int Count { get; set; }

        public string BeltValidated(string BeltName,
                                string BrandNo,
                                string ManufacturerNo,
                                string BeltDescription)

        {
            string ErrorMsg;
            ErrorMsg = "";

            // Set the validation that the characters must be between 3 and 16 characters for BeltName.
            if (BeltName.Length < 3 | BeltName.Length > 16)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The BeltName must be between 3 and 16 characters. ";
            }

            // Set Temp as BrandNo.
            try
            {
                Int32 temp;
                temp = Convert.ToInt32(BrandNo);

                // Set the validation for BrandNo - Not NULL.
                if (BrandNo.Length == 0)
                {
                    // Set the error message.
                    ErrorMsg = ErrorMsg + "BrandNo must not be NULL. ";
                }
            }
            catch
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "BrandNo was not an integer. ";
            }

            // Set Temp as ManufacturerNo.
            try
            {
                Int32 temp;
                temp = Convert.ToInt32(ManufacturerNo);

                // Set the validation for ManufacturerNo - Not NULL.
                if (ManufacturerNo.Length == 0)
                {
                    // Set the error message.
                    ErrorMsg = ErrorMsg + "ManufacturerNo must not be NULL. ";
                }
            }
            catch
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "ManufacturerNo was not an integer. ";
            }

            // Check the min length of the BeltDesceiption.
            if (BeltDescription.Length == 0)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "BeltDescription is blank. Please enter at least 7 characters. ";
            }

            // Check the max length of the BeltDescription.
            if (BeltDescription.Length > 200)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "BeltDescription must not exceed 200 characters. ";
            }

            // If there were no errors.
            if (ErrorMsg == "")
            {
                // Return a blank string.
                return "";
            }
            else
            {
                // Return the errors string value.
                return "There were the following errors : " + ErrorMsg;
            }
        }

        public static implicit operator List<object>(clsBelt v)
        {
            throw new NotImplementedException();
        }

        //// Function for the find method.
        //public Boolean Find(Int32 BeltNo)
        //{
        //    clsDataConnection dbConnection = new clsDataConnection();
        //    dbConnection.AddParameter("@BeltNo", BeltNo);
        //    dbConnection.Execute("sproc_tblBelt_FilterByBeltNo");
        //    if (dbConnection.Count == 1)
        //    {
        //        mBeltNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["BeltNo"]);
        //        mBeltName = Convert.ToString(dbConnection.DataTable.Rows[0]["BeltName"]);
        //        mBrandNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["BrandNo"]);
        //        mManufacturerNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["ManufacturerNo"]);
        //        mBeltDescription = Convert.ToString(dbConnection.DataTable.Rows[0]["BeltDescription"]);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
