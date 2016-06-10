namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class GSMTest
    {
        public static void DevicesTest()
        {
            GSM[] phoneArray =
            {
                new GSM("Iphone 4S", "Apple", 250, "Ivan Ivanov", new Battery(BatteryType.NiCd, 96, 24), new Display(4.0, 2000000)),
                new GSM("P9", "Huawei", 900, "Petar Petkov", new Battery(BatteryType.Li_Ion, 120, 36), new Display(6.2, 16000000)),
                new GSM("Galaxy S3", "Samsung", 400, "Maria Dimitrova", new Battery(BatteryType.NiCd, 120, 36), new Display(3.8, 1000000)),
                new GSM("Iphone 6", "Apple", 1200, "Stoicho Stoev", new Battery(BatteryType.Li_Ion , 72, 18), new Display(5.5, 16000000))
            };

            foreach (var phone in phoneArray)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
