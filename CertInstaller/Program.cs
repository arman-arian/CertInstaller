using System;
using System.Security.Cryptography.X509Certificates;

namespace CertInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Certificate Installer v1.0");

            var certificate = new X509Certificate2(Certificates.QTasCert, "12345");
            var rootStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            rootStore.Open(OpenFlags.ReadWrite);
            rootStore.Add(certificate);
            rootStore.Close();

            var myStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            myStore.Open(OpenFlags.ReadWrite);
            myStore.Add(certificate);
            myStore.Close();

            Console.WriteLine(@"Certificate Installed Successfuly");
            Console.ReadKey();
        }
    }
}
