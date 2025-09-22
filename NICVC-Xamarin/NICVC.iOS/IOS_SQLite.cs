﻿using System;
using System.IO;
using Xamarin.Forms;
using SQLite;
using NICVC.iOS;

[assembly: Dependency(typeof(IOS_SQLite))]
namespace NICVC.iOS
{
    public class IOS_SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "NICVC.db";
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder  
            string libraryPath = Path.Combine(dbPath, "..", "Library"); // Library folder  
            var path = Path.Combine(libraryPath, dbName);
            //Console.WriteLine("Database : "+path);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
