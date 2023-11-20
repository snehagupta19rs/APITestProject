using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemo
{
    public class CreateRequest
    {
        public ListOfUsersDTO GetUsers()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("/api/users?page2", Method.Get);
            restRequest.AddHeader = ("Accept", "application/json");
        }
    }
}
