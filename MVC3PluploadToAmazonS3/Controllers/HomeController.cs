using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3PluploadToAmazonS3.Helpers;
using MVC3PluploadToAmazonS3.Models;

namespace MVC3PluploadToAmazonS3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string acl = "private";
            string bucket = "YOUR S3 BUCKET NAME";
            string accessKeyId = "YOUR AMAZON ACCESS KEY ID";
            string secret = "YOUR AMAZON SECRET ACCESS KEY";
            string policy = AmazonS3Helper.ConstructPolicy(bucket, DateTime.UtcNow.Add(new TimeSpan(0, 10, 0, 0)), acl, accessKeyId);
            string signature = AmazonS3Helper.CreateSignature(policy, secret);

            var model = new PluploadAmazonS3Model()
            {
                AWSAccessKeyId = accessKeyId,
                Policy = policy,
                Signature = signature,
                Bucket = bucket,
                Acl = acl
            };

            return View(model);
        }

    }
}
