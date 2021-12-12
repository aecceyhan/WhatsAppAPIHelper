using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using WhatsAppAPIHelper;

namespace Example
{
    class Program
    {
        private static string ServiceUrl { get; set; }
        private static string AuthKey { get; set; }
        private static string PhoneNumberToTest { get; set; }


        static void Main(string[] args)
        {
            ServiceUrl = "WhatsApp solition providers api url";
            AuthKey = "your auth from solution provider";
            PhoneNumberToTest = "phone number to test with country code";


            SendBasicMessage();

            SendInteractiveMessage();


        }

        public static void SendBasicMessage()
        {
            MainRequestModel mainRequestModel = new MainRequestModel
            {
                recipient_type = recipient_type_enum.individual,
                to = PhoneNumberToTest,
                type = mainRequest_type_enum.text,
                text = new Text
                {
                    body = "Hello World!"
                },
            };

            SendAPIRequest(mainRequestModel);
        }

        public static void SendInteractiveMessage()
        {
            MainRequestModel mainRequestModel = new MainRequestModel
            {
                recipient_type = recipient_type_enum.individual,
                to = PhoneNumberToTest,
                type = mainRequest_type_enum.interactive,
                interactive = new Interactive
                {
                    type = interactive_type_enum.list,
                    body = new Body
                    {
                        text = "body text"
                    },
                    footer = new Footer
                    {
                        text = new Text
                        {
                            body = "Powerd by Emre Ceyhan"
                        }
                    },
                    action = new WhatsAppAPIHelper.Action
                    {
                        button = "Press me",
                        sections = new List<Section>
                        {
                            new Section
                            {
                                title = "first section",
                                rows = new List<Row>
                                {
                                    new Row
                                    {
                                        id = "unique123",
                                        title = "row title 1",
                                        description = "description abc"
                                    },
                                    new Row
                                    {
                                        id = "unique456",
                                        title = "row title 2",
                                        description = "description xyz"
                                    }
                                }
                            },
                            new Section
                            {
                                title = "second section",
                                rows = new List<Row>
                                {
                                    new Row
                                    {
                                        id = "unique321",
                                        title = "row title 1",
                                        description = "description abc"
                                    },
                                    new Row
                                    {
                                        id = "unique654",
                                        title = "row title 2",
                                        description = "description xyz"
                                    }
                                }
                            }
                        }
                    }
                }
            };


            SendAPIRequest(mainRequestModel);


        }

        public static void SendAPIRequest(MainRequestModel mainRequestModel)
        {

            var jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;

            var client = new RestClient(ServiceUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            request.AddHeader("D360-Api-Key", AuthKey); // I am currently use 360dialog.com for accessing official WhatsApp APIs

            var body = JsonConvert.SerializeObject(mainRequestModel, jsonSerializerSettings);

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
    }
}
