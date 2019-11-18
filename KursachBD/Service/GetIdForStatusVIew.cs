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
                case "⧗ Просмотреть позже":
                    {
                        return 1;
                    }
                case "★ Понравившийся":
                    {
                        return 2;
                    }
                case "✓ Смотрел":
                    {
                        return 3;
                    }
            }

            return 3;
        }
    }
}
