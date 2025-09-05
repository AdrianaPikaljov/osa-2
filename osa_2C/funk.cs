using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osa_2C
{
    internal class funk
    {
            public static string pikkus(int pikknr)
            {
                string pikk = "";
                if (pikknr <= 130)
                {
                    pikk = "luhike";
                }
                else if (pikknr >= 140 && pikknr <= 150)
                {
                    pikk = "kesk";
                }
                else if (pikknr >= 160 && pikknr <= 180)
                {
                    pikk = "pikk";
                }
                else if (pikknr >= 190)
                {
                    pikk = "vaga pikk";
                }
                else
                {
                    pikk = "???";
                }
                return pikk;

            }
        }
}
