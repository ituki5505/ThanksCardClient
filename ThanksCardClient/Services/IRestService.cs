using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanksCardClient.Models;


namespace ThanksCardClient.Services
{
    interface IRestService
    {
        Task<Employee> LogonAsync(Employee employee);
    }
}
