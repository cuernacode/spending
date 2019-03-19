using Xunit;
using Moq;

namespace Spending.Tests
{
    public class TriggerUnusualSpendingEmail
    {
        private Mock<PaymentsFetcher> _fetcher;

        public TriggerUnusualSpendingEmail()
        {
            _fetcher = new Mock<PaymentsFetcher>();
        }

        [Fact]
        public void ShouldNotTriggerAnEmailForNormalSpending()
        {
            //trigger(userid) where userid has normal payment history
        }
    }
}
