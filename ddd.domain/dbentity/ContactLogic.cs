using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class Contact
    {
        public Contact CreateContact(Guid dealerid,string name,string tel,string province,string city,
            string zero,string street,int isdefault)
        {
            this.Id = Guid.NewGuid();
            this.DealerId = dealerid;
            this.ContactName = name;
            this.ContactTel = tel;
            this.Province = province;
            this.City = city;
            this.Zero = zero;
            this.Street = street;
            switch (isdefault)
            {
                case 1:this.IsDefault = IsDefaultContact.默认;
                    break;
                case 2:this.IsDefault = IsDefaultContact.非默认;
                    break;
            }
            return this;

        }
    }
}
