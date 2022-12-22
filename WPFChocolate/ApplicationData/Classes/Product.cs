using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFChocolate.ApplicationData
{
    public partial class Product
    {
        public string CorrectImage
        {
            get
            {
                if (File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Images\\" + Image))
                {
                    return "\\Images\\" + Image;
                }
                else
                {
                    return "\\Images\\picture.jpg";
                }
            }
        }
    }
}
