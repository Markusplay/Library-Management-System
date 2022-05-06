using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.View
{
    public interface IAdminLog
    {
        string AdminLoginText { get; set; }

        string PasswordText { get; set; }
    }
}
