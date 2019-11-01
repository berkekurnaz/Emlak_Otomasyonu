using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Helpers
{
    public class GeneratorFolder
    {

        public void CreateFolder(string document_path, string id)
        {
            Directory.CreateDirectory(document_path + id);
        }

        public void DeleteFolder(string document_path, string id)
        {
            Directory.Delete(document_path + id);
        }

    }
}
