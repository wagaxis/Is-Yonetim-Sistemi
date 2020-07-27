using AbcManagement.DataAccess.Abstract;
using AbcManagement.DataAccess.ORMs.EF;
using AbcManagement.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcManagement.DataAccess.Concrete.EF
{
    public class EFDA_Users : CrudBase_EF<User,DatabaseContext>, IDA_Users
    {
    }
}
