﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05.IService
{
    public interface ICongThucService
    {
        void ThemCongThuc();
        string UpdateCachLam(string tenMonAn);
    }
}
