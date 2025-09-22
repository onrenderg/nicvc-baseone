using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace NICVC.Model
{
    class SearchByVcIdDatabase
    {
        private SQLiteConnection conn;
        public SearchByVcIdDatabase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<SearchByVcId>();
        }
        public IEnumerable<SearchByVcId> GetSearchByVcId(String Querryhere)
        {
            var list = conn.Query<SearchByVcId>(Querryhere);
            return list.ToList();
        }
        //public IEnumerable<SearchByVcId> GetSearchByVcIdByParameter(String Querryhere, string[] arrayhere)
        //{
        //    var list = conn.Query<SearchByVcId>(Querryhere, arrayhere);
        //    return list.ToList();
        //}
        public string AddSearchByVcId(SearchByVcId service)
        {
            conn.Insert(service);
            return "success";
        }
        public string DeleteSearchByVcId()
        {
            var del = conn.Query<StateMaster>("delete from SearchByVcId");
            return "success";
        }
    }
}
