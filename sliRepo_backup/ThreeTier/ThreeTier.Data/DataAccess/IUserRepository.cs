﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeTier.Data.DataAccess
{
    public interface IUserRepository
    {
        User GetUser(User user);
        IList<User> GetUsers();
    }
}
