namespace TestZmianyh
{
    public class Tests
    {
        [Test]
        public void TestVar()
        {
            var v1 = 1;
            var v2 = 1;
            Assert.AreEqual(v1, v2);
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
            int lc = 0;
            for (int i = 0; i < 10; i++)
            {
                lc++;
            }
            Assert.AreEqual(10, lc);
        }
        [Test]
        public void TestConvertIntInCharAndDouble()
        {
            int lc = 1;
            char ch = Convert.ToChar(lc);
            byte b = Convert.ToByte(ch);
            int i = Convert.ToInt32(b);

            Assert.AreEqual(1, i);
        }
    }
}