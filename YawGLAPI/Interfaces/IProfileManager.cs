﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace YawGLAPI
{
    public interface IProfileManager
    {
        public abstract void SetInput(int index, float value);
        public abstract void ResetYawOffset();
    }


}


