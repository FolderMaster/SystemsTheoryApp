using System.Collections.Generic;

using ClassificationApp.Models;

namespace ClassificationApp.Services
{
    public class Session
    {
        public List<Country> Education { get; set; } = new List<Country>();

        public List<Country> Test { get; set; } = new List<Country>();

        public Session()
        {
        }

        public Session(List<Country> education, List<Country> test)
        {
            Education = education;
            Test = test;
        }
    }
}