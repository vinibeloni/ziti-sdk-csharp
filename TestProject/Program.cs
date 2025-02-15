/*
Copyright NetFoundry Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using NLog;
using OpenZiti;
using System;
using System.Threading.Tasks;

namespace ConsoleTestApp {
    internal class Program {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string identityFile = @"c:\temp\id.json";

        private static async Task Main(string[] args) {
            Logging.SimpleConsoleLogging(LogLevel.Trace);
            Console.Clear();
            await OpenZiti.Samples.WeatherStream.Run(identityFile);
        }
    }
}
