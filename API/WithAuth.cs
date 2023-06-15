using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.ComponentModel;

namespace API
{
    internal class WithAuth
    {

        RestClient client;

        [SetUp]
        public void Setup()
        {
            client = new RestClient("https://api.qase.io/v1");
        }

        [Test]
        public void GetProjects()
        {
            var request = new RestRequest("/project", Method.Get);

            request.AddHeader("Token", "52739bb601a659bc46083322635143162d8e3aca8d00c58bdbc5d80a4d0cd2ab");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content.ToString());
            }
            else
            {
                Console.WriteLine("failed: " + response.ErrorMessage);
            }


        }


    }
}
