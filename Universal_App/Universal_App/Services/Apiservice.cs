using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Universal_App.Models.Entity;
using Universal_App.Adapters;

namespace Universal_App.Services
{
    class Apiservice
    {
        // home
        public async Task<homes> GetHome()
        {
            HttpClient client = new HttpClient();//lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiHome());// lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//chuyển dữ liệu thành 1 string 
                // tìm cách convert string ở trên thành 1 object Categories
                homes categories = JsonConvert.DeserializeObject<homes>(rsContent);
                return categories;
            }
            return null;
        }

        //eat in
        public async Task<Eat> GetEat()
        {
            HttpClient client = new HttpClient();//lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiEatin());// lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//chuyển dữ liệu thành 1 string 
                // tìm cách convert string ở trên thành 1 object Categories
                Eat eats = JsonConvert.DeserializeObject<Eat>(rsContent);
                return eats;
            }
            return null;
        }

        //detail burger
        public async Task<Burger> GetDetailBurger()
        {
            HttpClient client = new HttpClient();//lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiEatin());// lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//chuyển dữ liệu thành 1 string 
                // tìm cách convert string ở trên thành 1 object Categories
                Burger eatburger = JsonConvert.DeserializeObject<Burger>(rsContent);
                return eatburger;
            }
            return null;
        }

    }
}
