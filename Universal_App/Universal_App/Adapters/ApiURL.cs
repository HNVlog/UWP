using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_App.Adapters
{
    sealed class ApiURL // k ai kế thừa được
    {
        private readonly String baseURL = "https://foodgroup.herokuapp.com";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        //singleton pattern -- "design pattern"

        public static ApiURL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }
        public string GetApiHome()
        {
            return String.Format(baseURL + "/api/today-special");
        }
        public string GetApiEatin()
        {
            return String.Format(baseURL + "/api/category/1  ");
        }
    }
}
