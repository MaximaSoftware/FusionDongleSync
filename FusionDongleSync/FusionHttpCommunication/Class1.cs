using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FusionHttpCommunication
{
    public class Class1
    {
        public void stuff()
        {


            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://downloads.maximasoftware.co.za/Fusion/DongleCodes/DongleCodes.txt", @"c:\myfile.txt");


            //WebRequest req = WebRequest.Create("http://downloads.maximasoftware.co.za/Fusion/DongleCodes/DongleCodes.txt");
            //WebResponse response = req.GetResponse();
            //Stream file = response.GetResponseStream();



            //FileStream file = new FileStream("file.txt", FileMode.Create, System.IO.FileAccess.Write);
            //byte[] bytes = new byte[ms.Length];
            //ms.Read(bytes, 0, (int)ms.Length);
            //file.Write(bytes, 0, bytes.Length);
            //file.Close();
            //ms.Close();
        }
    }
}
