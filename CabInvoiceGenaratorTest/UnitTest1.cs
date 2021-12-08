using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenearator invoiceGeneartor = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGeneartor = new InvoiceGenearator(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGeneartor.CalcaulateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);

        }


        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGeneartor = new InvoiceGenearator(RideType.Normal);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGeneartor.CalcaulateFare(rides);
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
    }
}

