using CoreServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServices.Services
{
    public class TestService : ITestService
    {
        public IEnumerable<string> getTest(){
            return new string[] { "Soy un", "Crack" }; 
        }
    }
}
