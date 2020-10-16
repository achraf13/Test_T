using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Model
{
    class ProductModel
    {
       
            public string codeBarre { get; set; }
            
            public string image { get; set; }


            public ProductModel(String _codeBarre, String _image)
            {
                this.codeBarre = _codeBarre;
                this.image = _image;
            }

        
    }
}
