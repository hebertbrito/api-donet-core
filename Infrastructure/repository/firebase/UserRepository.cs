using Infrastructure.models;
using Infrastructure.repository.helper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.repository.firebase
{
    public class UserRepository : IGetUsers
    {
        public Firebase _firebase;

        public UserRepository(Firebase firebase)
        {
            _firebase = firebase;
        }

        public async Task<LinkedList<UserModelRepository>> GetUsers()
        {
            var docRef = _firebase.GetCollection();
            LinkedList<UserModelRepository> lstUser = new LinkedList<UserModelRepository>();
            var collection = await docRef.GetSnapshotAsync();
            if (collection.Count > 0)
            {
                foreach (var itemCollection in collection)
                {
                    var data = itemCollection.ToDictionary();
                    UserModelRepository objresponse = new UserModelRepository();
                    foreach (var item in data)
                    {
                        if ("firstname" == item.Key.ToString())
                            objresponse.firstname = item.Value.ToString();

                        if ("lastname" == item.Key.ToString())
                            objresponse.lastname = item.Value.ToString();
                    }
                    if(objresponse != null)
                        lstUser.AddLast(objresponse);
                }
            }
            return lstUser;
        }
    }
}
