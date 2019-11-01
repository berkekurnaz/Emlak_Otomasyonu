using Emlak.DataAccess.Abstract;
using Emlak.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Concrete.TextDb
{
    public class TDUserDal : IUserDal
    {

        //string document_path = Application.StartupPath + "/user.txt";
        string document_path = "";

        public TDUserDal(string document_path)
        {
            this.document_path = document_path;
        }

        public void Add(User user)
        {
            string addUser = user.Username + "," + user.Password;
            StreamWriter sw = File.AppendText(document_path);
            sw.WriteLine(addUser);
            sw.Flush();
            sw.Close();
        }

        public void Delete(User user)
        {
            List<User> users = new List<User>();
            users = this.GetAll();
            int index = users.FindIndex(x => x.Username == user.Username && x.Password == user.Password);

            var file = new List<string>(File.ReadAllLines(document_path));
            file.RemoveAt(index);
            File.WriteAllLines(document_path, file.ToArray());
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            FileStream fs = new FileStream(document_path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string line = sw.ReadLine();
            while (line != null)
            {
                string[] splitLine = line.Split(',');

                User userModel = new User(splitLine[0], splitLine[1]);
                users.Add(userModel);
                line = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return users;
        }

        public List<User> GetAllWithFilter(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<User> GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public bool Login(User user)
        {
            List<User> users = new List<User>();
            users = this.GetAll();

            List<User> newUsers = users.Where(x => x.Username == user.Username && x.Password == user.Password).ToList();
            if (newUsers.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Update(User user, User newUser)
        {
            List<User> users = new List<User>();
            users = this.GetAll();
            int index = users.FindIndex(x => x.Username == user.Username && x.Password == user.Password);

            string oldUpdateUser = users[index].Username + "," + users[index].Password;
            string updateUser = newUser.Username + "," + newUser.Password;

            string text = File.ReadAllText(document_path);
            text = text.Replace(oldUpdateUser, updateUser);
            File.WriteAllText(document_path, text);
        }

    }
}
