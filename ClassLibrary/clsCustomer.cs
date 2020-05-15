using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerNo;

        // WrestlerNo public property.
        public Int32 CustomerNo
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerNo;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerNo = value;
            }
        }

        // FirstName private member variable.
        private string mCustomerFirstName;
        // FirstName public property.
        public string CustomerFirstName
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerFirstName;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerFirstName = value;
            }
        }
        // CustomerLastName private member variable.
        private string mCustomerLastName;
        // FirstName public property.
        public string CustomerLastName
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerLastName;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerLastName = value;
            }
        }

        // CustomerEmail private member variable.
        private string mCustomerEmail;
        // FirstName public property.
        public string CustomerEmail
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerEmail;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerEmail = value;
            }
        }

        // CustomerPostcode private member variable.
        private string mCustomerPostcode;
        // FirstName public property.
        public string CustomerPostcode
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerPostcode;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerPostcode = value;
            }
        }

        // CustomerTelNo private member variable.
        private Int32 mCustomerTelNo;
        // FirstName public property.
        public Int32 CustomerTelNo
        {
            get
            {
                // This line of code sends data out of the property.
                return mCustomerTelNo;
            }
            set
            {
                // This line of code allows data into the property.
                mCustomerTelNo = value;
            }
        }

        // BuyerStatus private member variable.
        private Boolean mBuyerStatus;
        // RetiredStatus public property.
        public Boolean BuyerStatus
        {
            get
            {
                // This line of code sends data out of the property.
                return mBuyerStatus;
            }
            set
            {
                // This line of code allows data into the property.
                mBuyerStatus = value;
            }
        }

        // SellerStatus private member variable.
        private Boolean mSellerStatus;
        // RetiredStatus public property.
        public Boolean SellerStatus
        {
            get
            {
                // This line of code sends data out of the property.
                return mSellerStatus;
            }
            set
            {
                // This line of code allows data into the property.
                mSellerStatus = value;
            }
        }

        public string CustomerValidated(string CustomerFirstName,
                                string CustomerLastName,
                                string CustomerEmail,
                                string CustomerPostcode,
                                string CustomerTelNo)
                                //string BuyerStatus,
                                //string SellerStatus)
        {
            string ErrorMsg;
            ErrorMsg = "";

            // Set the validation that the characters must be between 2 and 11 characters for CustomerFirstName.
            if (CustomerFirstName.Length < 2 | CustomerFirstName.Length > 11)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The CustomerFirstName must be between 2 and 11 characters. ";
            }

            // Check the min length of the CustomerFirstName.
            if (CustomerFirstName.Length == 0)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerFirstName is blank. Please enter at least two characters. ";
            }

            // Check the max length of the CustomerFirstName.
            if (CustomerFirstName.Length > 11)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerFirstName must not exceed 11 characters. ";
            }

            // Set the validation that the characters must be between 2 and 11 characters for CustomerLastName.
            if (CustomerLastName.Length < 2 | CustomerLastName.Length > 11)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The CustomerFirstName must be between 2 and 11 characters. ";
            }

            // Check the min length of the CustomerLastName.
            if (CustomerLastName.Length == 0)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerLastName is blank. Please enter at least two characters. ";
            }

            // Check the max length of the CustomerLastName.
            if (CustomerLastName.Length > 11)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerLastName must not exceed 11 characters. ";
            }

            // Check the min length of the CustomerEmail.
            if (CustomerEmail.Length == 0)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "Please enter a valid CustomerEmail, no less than 11 characters";
            }

            // Set the validation that the characters must be between 5 and 8 characters for CustomerEmail.
            if (CustomerEmail.Length < 11 | CustomerPostcode.Length > 50)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The CustomerEmail must be between 11 and 50 characters. ";
            }

            // Set the validation that the characters must be between 5 and 8 characters for CustomerPostcode.
            if (CustomerPostcode.Length < 6 | CustomerPostcode.Length > 8)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The CustomerPostcode must be between 6 and 8 characters. ";
            }

            // Check the min length of the CustomerPostcode.
            if (CustomerPostcode.Length == 0)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerPostcode is blank. Please enter at least six characters. ";
            }

            // Check the max length of the CustomerPostcode.
            if (CustomerPostcode.Length > 8)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerPostcode must not exceed 8 characters. ";
            }

            // Set Temp as CustomerTelNo.
            try
            {
                Int32 temp;
                temp = Convert.ToInt32(CustomerTelNo);

                // Set the validation for CustomerTelNo - Not NULL.
                if (CustomerTelNo.Length == 0)
                {
                    // Set the error message.
                    ErrorMsg = ErrorMsg + "CustomerTelNo must not be NULL. ";
                }
            }
            catch
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo was not an integer. ";
            }

            // Set the validation for CustomerTelNo - 1.
            if (CustomerTelNo.Length == 1)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 2.
            if (CustomerTelNo.Length == 2)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 3.
            if (CustomerTelNo.Length == 3)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 4.
            if (CustomerTelNo.Length == 4)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 5.
            if (CustomerTelNo.Length == 5)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 6.
            if (CustomerTelNo.Length == 6)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 7.
            if (CustomerTelNo.Length == 7)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 8.
            if (CustomerTelNo.Length == 8)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 9.
            if (CustomerTelNo.Length == 9)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the validation for CustomerTelNo - 10.
            if (CustomerTelNo.Length == 10)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "CustomerTelNo MUST be 11 characters";
            }

            // Set the limit for CustomerTelNo. 
            if (CustomerTelNo.Length > 12)
            {
                // Set the error message.
                ErrorMsg = ErrorMsg + "The most characxters this can exceed is 11 - as this is how many numbers are in a telephone number";
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

        // Function for the find method.
        public Boolean Find(Int32 CustomerNo)
        {
            clsDataConnection dbConnection = new clsDataConnection();
            dbConnection.AddParameter("@CustomerNo", CustomerNo);
            dbConnection.Execute("sproc_tblCustomer_FilterByCustomerNo");
            if (dbConnection.Count == 1)
            {
                mCustomerNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["CustomerNo"]);
                mCustomerFirstName = Convert.ToString(dbConnection.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(dbConnection.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmail = Convert.ToString(dbConnection.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPostcode = Convert.ToString(dbConnection.DataTable.Rows[0]["CustomerPostcode"]);
                mCustomerTelNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["CustomerTelNo"]);
                try
                {
                    mBuyerStatus = Convert.ToBoolean(dbConnection.DataTable.Rows[0]["BuyerStatus"]);
                    mSellerStatus = Convert.ToBoolean(dbConnection.DataTable.Rows[0]["SellerStatus"]);
                }
                catch
                {
                    mBuyerStatus = true;
                    mSellerStatus = true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
