using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAPI.Core.Logger
{
    public interface ILogger
    {
        void Log(string message);
        void Log(Exception ex);
    }
}
