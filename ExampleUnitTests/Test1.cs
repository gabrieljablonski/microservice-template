using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;
using Liquid.Runtime.Test;
using Liquid.Base.Domain;
using Liquid.Domain;
using System.Net.Http;

namespace TasksUnitTest
{
    [Collection("Tasks")]
    public class Test1 : LightUnitTestCase<Test1, TasksFixture>
    {
        public Test1(TasksFixture fixture) : base(fixture) { }

        [Fact]
        public void TestCase1()
        {
        }
    }
}
