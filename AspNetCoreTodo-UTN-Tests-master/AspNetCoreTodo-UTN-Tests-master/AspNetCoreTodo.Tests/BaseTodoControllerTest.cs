using System;
using AspNetCoreTodo.Controllers;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Moq;
using Xunit;

namespace AspNetCoreTodo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        public abstract class BaseTodoControllerTest 
        {
            protected readonly TodoItem[] Items;
            protected readonly Mock<ITodoItemService> MockService;
            protected readonly TodoController todoControllerUnderTest;

            protected BaseTodoControllerTest (TodoItem[] items)
            {
                Items = items;

                MockService = new Mock<ITodoItemService>();

                MockService.
                Setup( svc => svc.GetIncompleteItemsAsync() )
                .ReturnsAsync(Items);

                todoControllerUnderTest = new TodoController(MockService.Object);
            }
        }
    }
}
