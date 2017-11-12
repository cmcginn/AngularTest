using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngularTest.Models;

namespace AngularTest.Services
{
    public class LabOrderService
    {
        public async Task<List<LabOrderListViewModel>> GetLabOrderList()
        {
            var result = new List<LabOrderListViewModel>();
            //Load List from Context
            return result;
        }
    }
}