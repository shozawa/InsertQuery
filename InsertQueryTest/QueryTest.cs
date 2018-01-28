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
            var expect = "INSERT Foo SET (A, B) VALUES (@A, @B)";
            var actual = Query.Construct(new Foo());
            Assert.Equal(expect, actual);
        }
        public class Foo
        {
            public int A { get; } = 1;
            public string B { get; } = "B";
            private string C { get; } = "C";
        }
    }
}
