namespace TestZmianyh
{
    public class Tests
    {
        [Test]
        public void TestVar()
        {
            var liczba1 = 1;
            var liczba2 = 1;
            Assert.AreEqual(liczba1, liczba2);
        }
        [Test]
        public void TestInt()
        {
            int liczba1 = 1;
            int liczba2 = 1;
            Assert.AreEqual(liczba1, liczba2);
        }
        [Test]
        public void TestString()
        {
            string str1 = "a";
            string str2 = "a";
            Assert.AreEqual(str1, str2);
        }
        [Test]
        public void TestBool()
        {
            bool bl1 = false;
            bool bl2 = false;
            Assert.AreEqual(bl1, bl2);
        }
        [Test]
        public void Test1Double()
        {
            double dob1 = 1.8;
            double dob2 = 1.8;
            Assert.AreEqual(dob1, dob2);
        }
        [Test]
        public void TestChar()
        {
            char c1 = 'q';
            char c2 = 'q';
            Assert.AreEqual(c1, c2);
        }
        [Test]
        public void TestFor()
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                a++;
            }
            Assert.AreEqual(10, a);
        }
        [Test]
        public void TestConvertIntInCharAndDouble()
        {
            int a = 1;
            char ch = Convert.ToChar(a);
            byte b = Convert.ToByte(ch);
            int o = Convert.ToInt32(b);

            Assert.AreEqual(1, o);
        }
    }
}
