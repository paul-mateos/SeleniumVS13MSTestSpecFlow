using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAAutomationSolution.Environment
{
    public class TestEnvironment
    {

        public static TestEnvironment GetEnvironment()
        {
            switch (Properties.Settings.Default.Environment)
            {
                case EnvironmentType.PreProd:
                   //return GetPreProdEnvironment();
                    return new TestEnvironment("http://preprod.cpaaustralia.com.au");
                case EnvironmentType.SIT_BLACK:
                    return new TestEnvironment("http://black.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_WHITE:
                    return new TestEnvironment("http://white.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_GREEN:
                    return new TestEnvironment("http://green.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_ORANGE:
                    return new TestEnvironment("http://orange.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_BLUE:
                    return new TestEnvironment("http://blue.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_BROWN:
                    return new TestEnvironment("http://brown.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_PINK:
                    return new TestEnvironment("http://pink.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_PURPLE:
                    return new TestEnvironment("http://purple.ext.test.cpaaustralia.com.au/");
                case EnvironmentType.SIT_YELLOW:
                    return new TestEnvironment("http://yellow.ext.test.cpaaustralia.com.au/");
                default:
                    throw new ArgumentException("Invalid Environment Setting has been used");

            }
        }

       

        public string Url
        {
            get;
            private set;
        }
        public TestEnvironment(string URL)
        {
            this.Url = URL;
        }
    }
}
