using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2010A_UWP.Adapters
{
    sealed class ApiURL // k ai kế thừa được
    {
        private readonly String baseURL = "http://foodgroup.herokuapp.com";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        //singleton pattern -- "design pattern"

        public static ApiURL GetInstance()
        {
            if(instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }
        public string GetApiCategories()
        {
            return String.Format(baseURL + "/api/menu");
        }
        //new
        public string GetApiTodaySpecial()
        {
            return String.Format(baseURL + "...");
        }

        public string GetApiCategoryDetail(int id)
        {
            return String.Format(baseURL + "/api/category/" + Convert.ToString(id));
        }
    }
}
