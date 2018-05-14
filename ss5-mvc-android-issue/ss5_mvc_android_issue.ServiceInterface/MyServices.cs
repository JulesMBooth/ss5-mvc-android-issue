using ServiceStack;
using ss5_mvc_android_issue.ServiceModel;

namespace ss5_mvc_android_issue.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}