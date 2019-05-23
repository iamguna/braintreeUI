using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_braintree.Controllers
{
    public class HomeController : Controller
    {
        public BraintreeGateway gateway = new BraintreeGateway
        {
            Environment = Braintree.Environment.SANDBOX,
            MerchantId = "z2pjndgnj4n3tx7k",
            PublicKey = "9wv2qkn5f5np6c6g",
            PrivateKey = "50338bf1cdca41ccd5515a941291e938"
        };

        public ActionResult Index()
        {
            return View();
        }

        public string GetToken()
        {


            var clientToken = gateway.ClientToken.Generate(
              new ClientTokenRequest
             {
                    
             }
            );

            return clientToken;
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}