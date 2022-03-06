using DemoApp.Constant;
using DemoApp.Contract;
using DemoApp.Model;
using DemoApp.SnowflakeConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.QueryCreation;
using System.Data.Common;

namespace DemoApp.Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        #region Private Variables
        private ISnowflakeConnection _snowflakeConnection;
        private String CustomerTable = TableName.CustomerTable;
        #endregion

        #region Constructor
        public CustomerBusiness(ISnowflakeConnection snowconnect)
        {
            _snowflakeConnection = snowconnect;

        }    
        public List<CustomerDetails> getCustomerById(string id)
        {
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            String whereclause = " CID = " + id;
            String query = QueryStatement.getDataById(CustomerTable, whereclause);
            DbDataReader reader = _snowflakeConnection.ExecuteSnowflakeQuery(query);
            while (reader.Read())
            {
                CustomerDetails customer = new CustomerDetails();
                customer.Cid = reader.GetString(0);
                customer.Name = reader.GetString(1);
                customer.Email = reader.GetString(2);
                customer.City = reader.GetString(3);
                customer.PinCode = reader.GetString(4);
                customer.Phone = reader.GetString(5);
                customer.password = reader.GetString(6);

                customerList.Add(customer);

            }
            return customerList;
        }

        public List<CustomerDetails> getCustomerbyPhone(string phoneno)
        {
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            String whereclause = " Phone = " + phoneno;
            String query = QueryStatement.getDataById(CustomerTable, whereclause);         
            DbDataReader reader = _snowflakeConnection.ExecuteSnowflakeQuery(query);
            while (reader.Read())
            {
                CustomerDetails customer = new CustomerDetails();
                customer.Cid = reader.GetString(0);
                customer.Name = reader.GetString(1);
                customer.Email = reader.GetString(2);
                customer.City = reader.GetString(3);
                customer.PinCode = reader.GetString(4);
                customer.Phone = reader.GetString(5);
                customer.password = reader.GetString(6);

                customerList.Add(customer);

            }
            return customerList;
        }

        public List<CustomerDetails> getCustomerBypin(string pin)
        {
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            String whereclause = " PinCode = " + pin;
            String query = QueryStatement.getDataById(CustomerTable, whereclause);
            DbDataReader reader = _snowflakeConnection.ExecuteSnowflakeQuery(query);
            while (reader.Read())
            {
                CustomerDetails customer = new CustomerDetails();
                customer.Cid = reader.GetString(0);
                customer.Name = reader.GetString(1);
                customer.Email = reader.GetString(2);
                customer.City = reader.GetString(3);
                customer.PinCode = reader.GetString(4);
                customer.Phone = reader.GetString(5);
                customer.password = reader.GetString(6);

                customerList.Add(customer);

            }
            return customerList;
        }

        public List<CustomerDetails> GetCustomerDetails()
        {
            String query = QueryStatement.getAllFromTable(CustomerTable);
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            DbDataReader reader = _snowflakeConnection.ExecuteSnowflakeQuery(query);
            while (reader.Read())
            {
                CustomerDetails customer = new CustomerDetails();
                customer.Cid = reader.GetString(0);
                customer.Name = reader.GetString(1);
                customer.Email = reader.GetString(2);
                customer.City = reader.GetString(3);
                customer.PinCode = reader.GetString(4);
                customer.Phone = reader.GetString(5);
                customer.password = reader.GetString(6);

                customerList.Add(customer);

            }
            return customerList;
        }

        public bool deleteCustomerInfoById(string id)
        {
            String whereclause = " Cid = " + id;
            String query = QueryStatement.deletebyId(CustomerTable, whereclause);
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            DbDataReader reader = _snowflakeConnection.ExecuteSnowflakeQuery(query);
            return true;
        }

        public bool saveCustomerDetails(CustomerDetails obj)
        {

            //Yet to be implemented
            throw new NotImplementedException();
        }

        public bool updateCustomerDetails(CustomerDetails obj)
        {
            //Yet to be Implemented
            throw new NotImplementedException();
        }

      
        #endregion
    }
}
