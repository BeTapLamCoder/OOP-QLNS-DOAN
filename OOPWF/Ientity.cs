﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    //lớp thực thể có dùng cho mọi lớp, bởi lớp chính nào cũng sẽ có ID riêng và tên riêng
    public interface Ientity
    {
        string Id { get; set; }
        string Name { get; set; }
    }
}
