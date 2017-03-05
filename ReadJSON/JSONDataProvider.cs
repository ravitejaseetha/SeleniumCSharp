using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReadJSON
{
    public class JsonDataProvider<T> : IDataProvider<T>
    {

        internal IEnumerable<Patient> datas;

        /// <summary>
        /// By convention, this will look for Patient.json file if the Type is Patient.cs
        ///     Json file Path = >
        ///         BaseDirectory (bin/{env}) for the runner project
        ///         appSettings of the runner project in a key named 'JsonDataProviderDirectory' + 
        ///         fileName (Patient.Json if the type argument is Patient.
        /// Make sure to set the Build Action to Content and set Copy Always for the Json files.
        /// </summary>
        public JsonDataProvider()
        {
            //var jsonDataProviderDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["JsonDataProviderDirectory"]);
            //var filePath = jsonDataProviderDirectory + typeof(T).Name;

            //if (!File.Exists(filePath))
            //    throw new FileNotFoundException(
            //        "Please ensure JsonDataProviderDirectory is set on the appsettings of the starter project and the json file is present");

            datas = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText("E:\\Patients.json")) ?? new List<Patient>();

        }
        public List<Patient> GetAllRecords()
        {
            return datas.ToList();

        }


        //public IEnumerable<Patient> GetFilteredRecords(Expression<Func<T, bool>> predicate)
        //{
        // //   return datas.Where(predicate.Compile());
        //}

        public Patient GetFirstRecord()
        {
            return datas.First();
        }

        //public T Get(Expression<Func<T, bool>> predicate)
        //{
        //    //return GetAllRecords().FirstOrDefault(predicate.Compile());
        //}
    }
}
