namespace SpecsFor.Mvc
{
    public interface IWebServerProcess
    {
        int? PortNumber { get; set; }
        bool UseHttps { get; set; }

        void Start();
        void Stop();
    }
}