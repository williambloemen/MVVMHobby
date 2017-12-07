using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MVVMHobby.Model
{
    public class Hobby
    {
        public string Catergorie { get; set; }
        public string Activiteit { get; set; }
        public BitmapImage Symbool { get; set; }

        public Hobby(string nCategorie, string nActiviteit, BitmapImage nSymbool)
        {
            Catergorie = nCategorie;
            Activiteit = nActiviteit;
            Symbool = nSymbool;
        }
    }
}
