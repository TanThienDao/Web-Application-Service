using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        // service to test DLL
        [OperationContract]
        string Encrypt(string plaintext);
        [OperationContract]
        string Decrypt(string encryptedText);
        // service develop 
        [OperationContract]
        double GetWindEnergyIndex(Int32 lattitude, Int32 longitude);
        [OperationContract]
        string GetVerifierString(string length);
        [OperationContract]
        Stream GetImage(string myString);
        [OperationContract]
        string addAcoundt(string username, string password, int role);
        [OperationContract]
        string[] search(string username, int role);
        [OperationContract]
        bool removeFromXML(string username, int role);
        [OperationContract]
        string returnXML(string xmlfile);
        [OperationContract]
        bool myAuthenticate(string username, string password);

        // TODO: Add your service operations here
    }


  
}
