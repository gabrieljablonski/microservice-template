using Liquid.Domain.API;
using Liquid.Runtime.Test;
using Xunit;

namespace TasksUnitTest
{
    [CollectionDefinition("Tasks")]
    public class TasksCollection : ICollectionFixture<TasksFixture> { }
}
