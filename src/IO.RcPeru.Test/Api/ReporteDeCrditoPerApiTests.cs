using NUnit.Framework;
using IO.RcPeru.Api;
using IO.RcPeru.Model;
using System;

namespace IO.RcPeru.Test
{
    [TestFixture]
    public class ReporteDeCrditoPerApiTests
    {
        private string xApiKey;
        private string username;
        private string password;
        private ReporteDeCrditoPerApi api;

        [SetUp]
        public void Init()
        {
            string basePath = "the_url";
            this.xApiKey = "your_api_key";
            this.username = "your_username";
            this.password = "your_password";
            this.api = new ReporteDeCrditoPerApi(basePath);
        }

        [Test]
        public void GetRCTest()
        {
            Peticion request = new Peticion();
            request.Folio = "XXXXXXXX";
            request.TipoDocumento = "X";
            request.NumeroDocumento = "XXXXXXXX";
            var response = this.api.GetRC(this.xApiKey, this.username, this.password, request);
            Assert.IsInstanceOf<Respuesta> (response, "response is Respuesta");
            Console.WriteLine(response.ToString());
        }
        
    }
}
