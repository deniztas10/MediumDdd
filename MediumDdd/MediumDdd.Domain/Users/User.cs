using System;
using System.Collections.Generic;
using System.Text;

namespace MediumDdd.Domain.Users
{
    public class User // TODO:: Aggregete Root
    {
        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }

    }
}
