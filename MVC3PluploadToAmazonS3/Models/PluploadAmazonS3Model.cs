using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC3PluploadToAmazonS3.Models
{
    public class PluploadAmazonS3Model
    {
        public string AWSAccessKeyId { get; set; }
        public string Policy { get; set; }
        public string Signature { get; set; }
        public string Bucket { get; set; }
        public string Acl { get; set; }
    }

}