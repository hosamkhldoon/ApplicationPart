
using System.Collections.Generic;

namespace IFTPRemotingService
{
    public interface IFTPRemotingService
    {
        void UploadFileInFtpServer(List<object> listcontact, List<object> listnews, List<object> listphotos);
           
    }
}
