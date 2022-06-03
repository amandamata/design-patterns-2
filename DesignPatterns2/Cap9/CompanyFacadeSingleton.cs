using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap9
{
    public class CompanyFacadeSingleton
    {
        private static FacadeCompany facade = new FacadeCompany();
        public FacadeCompany Instance
        {
            get {
               return facade;
            }
        }
    }
}
