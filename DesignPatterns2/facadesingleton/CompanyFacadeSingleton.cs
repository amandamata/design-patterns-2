namespace DesignPatterns2.facadesingleton
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
