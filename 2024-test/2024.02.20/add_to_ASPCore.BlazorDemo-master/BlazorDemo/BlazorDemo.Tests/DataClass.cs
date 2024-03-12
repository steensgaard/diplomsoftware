using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Tests
{
   public class DataClass : IEnumerable<object[]>
    {
        private IEnumerable<object[]> data => new[]
        {
            new object[]
            {
                new List<string> { "1", "2", "3" }
            },
            new object[]
            {
                new List<string> { "3", "6", "9" }
            }
         };
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
