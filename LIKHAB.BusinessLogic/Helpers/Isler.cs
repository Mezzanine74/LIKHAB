using LIKHAB.DataLayer.DBContext;
using System.Linq;

namespace LIKHAB.BusinessLogic.Helpers
{
    public class Isler
    {
        private static LikhabDBContext db = new LikhabDBContext();

        public static bool OnaylanmisMiByIsId(int id)
        {
            var a = db.IsAsamalaris.FirstOrDefault(c => c.IsId == id);
            if (a != null)
            {
                return a.Onaylanmis;
            }

            return false;
        }

        public static bool OnaylanmisMiByRandevuId(int id)
        {
            var a = db.Randevus.FirstOrDefault(c => c.Id == id);
            if (a != null)
            {
                return OnaylanmisMiByIsId(a.Is);
            }

            return false;
        }
    }
}