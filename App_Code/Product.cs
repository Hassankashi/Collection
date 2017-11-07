using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
/// 

    public class Product
    {
        public Product()
        {
        
        }
        public Product(string Code, string Name)
        {
            _Code = Code;
            _Name = Name;
        }

		    public string _Code {get; set;}
            public string _Name { get; set; }
    }