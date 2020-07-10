using Microsoft.Crm.Sdk.Messages;
using System;
using System.Net;

namespace ConnectD365ByCrmServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                var con = ConnectToCRM.ConnectWithOAuth();

                var req = new WhoAmIRequest();
                var response = (WhoAmIResponse)con.Execute(req);

                var userEntity = con.Retrieve("systemuser", response.UserId, new Microsoft.Xrm.Sdk.Query.ColumnSet(true));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
