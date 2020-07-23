﻿using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
        public interface IHandler
        {
            IHandler SetNext(IHandler handler);

            object Handle(object request);
        }

}
