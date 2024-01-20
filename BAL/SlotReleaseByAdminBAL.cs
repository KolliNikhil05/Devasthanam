using DAL;
using DevasthanamDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class SlotReleaseByAdminBAL
    {
        SlotReleaseByAdminDAL objDal = new SlotReleaseByAdminDAL();
        public DataTable SlotRelease()
        {
            try
            {
                return objDal.SlotRelease();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
