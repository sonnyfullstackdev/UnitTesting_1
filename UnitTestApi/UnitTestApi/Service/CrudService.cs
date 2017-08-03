using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApi.Service
{
    public class CrudService
    {
        IDataStorage _dataStorage;

        public CrudService(IDataStorage datastorage)
        {
            _dataStorage = datastorage;
        }


        public int Create(string name)
        {
            return _dataStorage.Insert(name);
        }

        public string Read()
        {
            return "";
        }

        public int Update(string name)
        {
            return 0;
        }

        public void Delete(int id)
        {
            //TODO: put a delete
        }
    }

    public interface IDataStorage
    {
        int Insert(string name);
    }
}
