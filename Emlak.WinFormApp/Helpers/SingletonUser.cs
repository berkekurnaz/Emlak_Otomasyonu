using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.WinFormApp.Helpers
{
    public class SingletonUser
    {

        private static SingletonUser _singletonUser;
        private static object _lock = new object();

        private string userName;

        protected SingletonUser()
        {

        }

        public static SingletonUser CreateAsSingleton()
        {
            lock (_lock)
            {
                if (_singletonUser == null)
                {
                    _singletonUser = new SingletonUser();
                }
            }
            return _singletonUser;
        }

        public string ReadUsername()
        {
            return userName;
        }

        public void WriteUsername(string username)
        {
            userName = username;
        }

    }
}
