using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;

namespace BL.Interfaces
{
    public interface IUser
    {
        void Adduser(UsersDTO usersDTO);
        void Deleteuser(UsersDTO usersDTO);
        void Edituser(UsersDTO usersDTO);

    }
}
