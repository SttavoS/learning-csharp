using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entites;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var student = new Student("Gustavo", "Schneider", "12345678910", "gustavo.schneider.dev@gmail.com");
    }
}