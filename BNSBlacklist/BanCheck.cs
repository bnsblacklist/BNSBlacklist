using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNSBan
{
    public class BanRecord
    {
        public int bancode;
        public string reason;
        public string url;
    }

    public class BanCheck
    {
        public List<BanRecord> records;

        public BanCheck()
        {
            records = new List<BanRecord>();
        }

        public static BanCheck RetriveBanRecords(Profile profile)
        {
            BanCheck result = new BanCheck();
            return result;
        }
    }
}
