using AspCoreModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<List<UsersModel>> GetUsers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, 
                "User/GetAllUsers"));
            return await GetAsync<List<UsersModel>>(requestUrl);
        }

        public async Task<Message<UsersModel>> SaveUser(UsersModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "User/SaveUser"));
            return await PostAsync<UsersModel>(requestUrl, model);
        }
    }
}
