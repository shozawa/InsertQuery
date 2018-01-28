using System;
using Xunit;
using InsertQuery;

namespace InsertQueryTest
{
    public class UnitTest1
    {
        [Fact]
        public void ConstructTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Simple()
        {
            var expect = "INSERT FOO SET (a, b, c) VALUES (1, 'B', 'C')";
            var actual = Query.Construct(new Foo());
            Assert.Equal(expect, actual);
        }
        class Foo
        {
            public int a = 1;
            public string b = "B";
            public string c = "C";
        }
    }
}
