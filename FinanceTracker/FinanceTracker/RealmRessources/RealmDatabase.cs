using MongoDB.Bson;
using Realms;

namespace FinanceTracker.RealmRessources
{
    public static class RealmDatabase
    {
        static Realm realm = Realm.GetInstance();

        public static void createRealmObject<T>(T obj)where T : RealmObject
        {
            realm.Write(() =>
            {
                return realm.Add(obj);
            });
        }

        public static void updateRealmObject<T>(T oldObj, T newObj)where T : RealmObject
        {
            realm.Write(() =>
            {
                oldObj = newObj;
            });
        }

        public static void deleteRealmObject<T>(T obj) where T : RealmObject
        {
            realm.Write(() =>
            {
                realm.Remove(obj);
            });
        }

        public static void deleteAllRealmObjects<T>() where T : RealmObject
        {
            realm.Write(realm.RemoveAll<T>);
        }

        public static void deleteAllRealmObjects()
        {
            realm.Write(realm.RemoveAll);
        }

        public static T readObjectByPrimaryKey<T>(ObjectId id) where T : RealmObject
        {
            T myObj = realm.Find<T>(id);
            return myObj;
        }

        public static IQueryable<T> readAllObjects<T>() where T : RealmObject
        {
            IQueryable<T> objects = realm.All<T>();
            return objects;
        }
    }
}
