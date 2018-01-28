using System;
using Xunit;
using InsertQuery;

namespace InsertQueryTest
{
    public class QueryTest 
    {
        [Fact]
        public void Simple()
        {
            var expect = "INSERT Foo SET (a, b, c) VALUES (@a, @b, @c)";
            var actual = Query.Construct(new Foo());
            Assert.Equal(expect, actual);
        }
        public class Foo
        {
            public int a { get; } = 1;
            public string b { get; } = "B";
            public string c { get; } = "C";
        }
    }
}
