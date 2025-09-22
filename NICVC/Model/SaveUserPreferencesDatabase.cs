using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;


namespace NICVC.Model
{
    class SaveUserPreferencesDatabase
    {
        private SQLiteConnection conn;
        public SaveUserPreferencesDatabase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<SaveUserPreferences>();
        }
        public IEnumerable<SaveUserPreferences> GetSaveUserPreferences(String Querryhere)
        {
            var list = conn.Query<SaveUserPreferences>(Querryhere);
            return list.ToList();
        }
        public string AddSaveUserPreferences(SaveUserPreferences service)
        {
            conn.Insert(service);
            return "success";
        }
        public string DeleteSaveUserPreferences()
        {
            var del = conn.Query<SaveUserPreferences>("delete from SaveUserPreferences");
            return "success";
        }


        public string CustomSaveUserPreferences(string query)
        {
            conn.Query<SaveUserPreferences>(query);
            return "success";
        }

    }
}
