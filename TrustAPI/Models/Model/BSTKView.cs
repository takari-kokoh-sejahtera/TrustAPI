using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrustAPI.Models.Model
{
    public class BSTKView
    {
        public int BSTKBefore_ID { get; set; }
        public string Company_Name { get; set; }
        public string license_no { get; set; }
        public string Type { get; set; }
        public bool IsCompleted { get; set; }

        private string gabungan;
        public string Gabungan
        {
            get
            {
                gabungan = license_no + ";" + Company_Name + ";" + Type + ";" + BSTKBefore_ID.ToString();
                return gabungan;
            }
        }
    }
}