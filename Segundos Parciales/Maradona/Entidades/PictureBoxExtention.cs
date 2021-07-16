using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class PictureBoxExtention
    {
        public static string ReturnLastChar(this PictureBox picture)
        {
            return picture.Name.Substring(picture.Name.Length - 1);
        }
    }
}
