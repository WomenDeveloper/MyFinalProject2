﻿using System;
using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);//need join
    }
}

