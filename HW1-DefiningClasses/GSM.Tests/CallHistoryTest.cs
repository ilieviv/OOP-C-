namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class CallHistoryTest
    {
        public static void CallHistory()
        {
            GSM callTest = new GSM("Galaxy 5", "Samsung", 10, "Yordan Yordanov", new Battery(BatteryType.Unknown, 999999999, 99999999), new Display(1, 2));
            callTest.AddCall(DateTime.Now, "+359888111222", 360);
            callTest.AddCall(new DateTime(2016, 5, 30, 07, 10, 14), "+359888123456", 601);
            callTest.AddCall(new DateTime(2016, 5, 31, 15, 10, 18), "+359888123456", 128);

            Console.WriteLine("Call history:");
            Console.WriteLine(callTest.CallHistory);
            Console.WriteLine("Price for calls:");
            Console.WriteLine("${0:F2}", callTest.GetPrice());

            callTest.RemoveLongestCall();
            Console.WriteLine("Price after removed longest call:");
            Console.WriteLine("${0:F2}", callTest.GetPrice());

            callTest.ClearHistory();
            Console.WriteLine(callTest.CallHistory);
        }
    }
}
