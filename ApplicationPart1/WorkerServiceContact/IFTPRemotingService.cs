
using System.Collections.Generic;
using System.Text;
using System;
using FileWorxObjects;
namespace WorkerServiceContact
{
    public interface IFTPRemotingService
    {
        void UploadFileInFtpServer(List<FileOperation> ListNews);

    }
}
