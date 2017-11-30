using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DeleteEntscheidung
    {
        static bool delete;

        public void cEntscheidung(bool _delete)
        {
            delete = _delete;
        }

        public bool Delete
        {
            get
            {
                return delete;
            }
        }
    }
}
