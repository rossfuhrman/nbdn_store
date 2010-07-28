using System;
using System.Web;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : RequestFactory
    {
        public Request create_request_from(HttpContext http_context)
        {
            return new StubRequest();
        }

        class StubRequest : Request
        {
            public string get_parameter(string department_name)
            {
                throw new NotImplementedException();
            }
        }


    }
}