using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Views
{

    public class TrangChuMenuItem
    {
        public TrangChuMenuItem()
        {
            TargetType = typeof(TrangChuDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}