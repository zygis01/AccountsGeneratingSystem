using BankAccountsGeneratingSystem.Modules;
using BankAccountsGeneratingSystem.Repositories;

namespace BankSystemTests
{
    public class AccountsTests
    {
        [Fact]
        public void Amount_Should_Be_90()
        {
            //Arrange
            var accounts = new AccountsRepository();
            var accList = accounts.RetrieveList();
            var xAmount1 = accList.Sum(x => x.product1Amount);
            var xAmount2 = accList.Sum(x => x.product2Amount);
            var xAmount3 = accList.Sum(x => x.product3Amount);
            var sum = xAmount1 + xAmount2 + xAmount3;

            //Act
            var expectedAmount = 90;

            //Assert

            Assert.Equal(expectedAmount, sum);
        }
    }
}