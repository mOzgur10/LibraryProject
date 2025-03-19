using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DATA.Enums
{
    public enum State
    {
        [Description("Ödünç Alınabilir")]
        Available,

        [Description("Ödünç Verildi")]
        Borrowed,

        [Description("Mevcut Değil")]
        NotAvailable
    }
}
