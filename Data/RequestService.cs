using System.Collections.Generic;
using System.Linq;
using BlazorServerCRUD.Data;

namespace BlazorServerCRUD.Data
{
    public class RequestService
    {
        private List<Request> _requests = new List<Request>();

        public IEnumerable<Request> Requests => _requests;

        public void AddRequest(Request request)
        {
            _requests.Add(request);
        }

        public Request GetLastRequest()
        {
            return _requests.LastOrDefault();
        }
    }
}
