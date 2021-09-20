namespace EstacionamientoNetCore.Factory
{
    using System.Net.Http;
    using System.Security.Cryptography.X509Certificates;

    public class HttpMessageHandlerFactory
    {
        public static HttpMessageHandler Create(X509Certificate2 cert)
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ClientCertificates.Add(cert);
            handler.ServerCertificateCustomValidationCallback = (request, serverCert, serverCertChain, error) =>
            {
                return true;
            };
            return handler;
        }
    }
}
