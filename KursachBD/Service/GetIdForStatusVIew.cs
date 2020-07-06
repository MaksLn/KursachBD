using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Service
{
    public static class GetIdForStatusVIew
    {
        public static int GetIdStatus(this string status)
        {
            switch (status)
            {
                case "⧗ Хочу прочитать":
                    {
                        return 1;
                    }
                case "★ Любимые":
                    {
                        return 2;
                    }
                case "✓ Прочитал":
                    {
                        return 3;
                    }
            }

            return 3;
        }
    }
}
