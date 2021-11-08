using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2010A_UWP.Models.Entity;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using T2010A_UWP.Adapters;


namespace T2010A_UWP.Services
{
    class Apiservice
    {
        public async Task<Categories> GetCategories()
        {
            HttpClient client = new HttpClient();//lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategories());// lấy data từ api về
            if(rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//chuyển dữ liệu thành 1 string 
                // tìm cách convert string ở trên thành 1 object Categories
                Categories categories = JsonConvert.DeserializeObject<Categories>(rsContent);
                return categories;
            }
            return null;
        }
        //new
        public async Task<CategoryDetail> CategoryDetail(Category category)
        {
            HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategoryDetail(category.id)); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
                                                                        // timf cách convert string ở trên thành 1 object Categories
                CategoryDetail detail = JsonConvert.DeserializeObject<CategoryDetail>(rsContent);
                return detail;
            }
            return null;
        }
    }
}
