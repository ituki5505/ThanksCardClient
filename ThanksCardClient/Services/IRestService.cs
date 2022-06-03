using System.Threading.Tasks;
using ThanksCardClient.Models;


namespace ThanksCardClient.Services
{
    interface IRestService
    {
        Task<Employee> LogonAsync(Employee employee);
    }
}