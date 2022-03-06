using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Contract
{
    public interface ICustomerBusiness
    {
        public List<CustomerDetails> GetCustomerDetails();

        public bool saveCustomerDetails(CustomerDetails obj);

        public bool updateCustomerDetails(CustomerDetails obj);

        public List<CustomerDetails> getCustomerBypin(String pin);

        public List<CustomerDetails> getCustomerById(String id);

        public List<CustomerDetails> getCustomerbyPhone(String phoneno);

        public bool deleteCustomerInfoById(String id);
    }
}
