using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FileWorxObjects;
using log4net.Core;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using log4net.Repository.Hierarchy;
using Microsoft.VisualBasic;
using WinSCP;

namespace WorkerServiceContact
{
   public class FTPRemotingService:MarshalByRefObject,
        IFTPRemotingService
    {
   
       
        public void UploadFileInFtpServer(List<FileOperation> ListNews)
        {
            foreach (var item in ListNews)
            {
                //Get a new FtpliebRequest object.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(item.Address + "/news" + Guid.NewGuid().ToString() + ".txt");
                //Method will be UploadFile.
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //Set our credentials.
                string password = Eramake.eCryptography.Decrypt(item.Password);
                request.Credentials = new NetworkCredential(item.UserName, password);
                //Setup a stream for the request and a stream for // the file we'll be uploading.
                request.UseBinary = false;
        
                //Setup variables we'll use to read the file.
                using (Stream requestStream = request.GetRequestStream())
                using (StreamWriter writer = new StreamWriter(requestStream, Encoding.UTF8))
                {
                    string data;
                    if (item.TypeFile == "News")
                        data = string.Format("title :{0} \ndescription :{1} \nbody:{2} \nNewsOrPhoto : {3} \nCategory :{4}\n", item.NameFileUser, item.DescriptionNewsPhoto, item.BodyFile, item.TypeFile, item.CategoryFile);
                    else
                        data = string.Format("title :{0} \ndescription :{1} \nbody:{2} \nNewsOrPhoto : {3} \nLocation Photo :{4}\n", item.NameFileUser, item.DescriptionNewsPhoto, item.BodyFile, item.TypeFile, item.LocationPhoto);
                    writer.Write(data);
                }
            }

        }
    }
      
     
    }

