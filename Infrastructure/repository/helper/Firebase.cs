using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Infrastructure.repository.helper
{
    public class Firebase
    {
        
        public FirestoreDb _firebase;

        public Firebase(string ID_FIREBASE)
        {
            FirestoreDb db = FirestoreDb.Create(ID_FIREBASE);
            _firebase = db;
        }

        public CollectionReference GetCollection()
        {
            return _firebase.Collection("tb_users");
        }

 
    }
}
