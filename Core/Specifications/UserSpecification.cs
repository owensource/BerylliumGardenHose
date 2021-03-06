﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Entities;

namespace Core.Specifications
{
    public sealed class UserSpecification : BaseSpecification<User>
    {
        public UserSpecification(string identityId) : base(u => u.IdentityId == identityId)
        {
            AddInclude(u => u.RefreshTokens);
        }
    }
}
