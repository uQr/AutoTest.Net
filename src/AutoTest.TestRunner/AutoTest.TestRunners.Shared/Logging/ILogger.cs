﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoTest.TestRunners.Shared.Logging
{
    public interface ILogger
    {
		void Write(string message);
        void Write(string message, params object[] args);
		void WriteChunk(string message);
        void WriteChunk(string message, params object[] args);
        void Debug(string message);
        void Debug(string message, params object[] args);
		void DebugChunk(string message);
        void DebugChunk(string message, params object[] args);
        void Debug(Exception ex);
    }
}
