
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.API.Helpers
{
    public interface IApiKeyValidator
    {
        public bool IsValid(string apikey);
    }
}