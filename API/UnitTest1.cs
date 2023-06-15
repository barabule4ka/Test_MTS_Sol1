using RestSharp;
using System.ComponentModel;

namespace API
{
    public class Tests
    {

        RestClient client;

        [SetUp]
        public void Setup()
        {
            client = new RestClient("https://reqres.in/api");
        }

        [Test]
        public void GetUserById()
        {
             var request = new RestRequest("/users/2", Method.Get);

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

        [Test]
        public void CreateUser_hard()
        {
            var request = new RestRequest("/users", Method.Post);

            var body = "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"leader\"\r\n}";

            request.AddBody(body);

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

        [Test]
        public void CreateUser_dictionary()
        {

            var request = new RestRequest("/users", Method.Post);
            var body = new Dictionary<string, object>()
            {
                { "Name", "Ivan"},
                { "Password", "password"}

            };

            request.AddBody(body);

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


        [Test]
        public void CreateUser_file()
        {

            var request = new RestRequest("/users", Method.Post);

            var body = File.ReadAllText("User.json");
          
            request.AddBody(body);

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

        [Test]
        public void CreateUser_model()
        {

            var request = new RestRequest("/users", Method.Post);
            var body = new User
            {
                Name = "qwe",
                Password =  "pass",
            };

            request.AddBody(body);
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