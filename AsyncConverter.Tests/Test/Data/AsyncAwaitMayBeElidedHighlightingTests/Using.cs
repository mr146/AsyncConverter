﻿using System.IO;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            using (new MemoryStream())
            {
                await Task.Delay(1000).ConfigureAwait(false);
            }
        }
    }
}
