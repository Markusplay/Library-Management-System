using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.View
{
    public interface IWishList : IAddBook
    {
        int GuestID { get; set; }
        int WishID { get; set; }
    }
}
