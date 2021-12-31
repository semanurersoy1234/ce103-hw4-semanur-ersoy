using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using ce103_hw4_cs_dll2;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ce103_fibonacciNumber_test_1()
        {

            Class1 fibo = new Class1();
            int expected = fibo.ce103_fibonacciNumber_cs(9);

            Assert.AreEqual(expected, 34);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_test_2()
        {
            Class1 fibo = new Class1();
            int expected = fibo.ce103_fibonacciNumber_cs(24);

            Assert.AreEqual(expected, 46368);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_test_3()
        {
            Class1 fibo = new Class1();
            int expected = fibo.ce103_fibonacciNumber_cs(31);

            Assert.AreEqual(expected, 1346269);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_1()
        {
            Class2 fibo = new Class2();
            int expected = fibo.ce103_fibonacciNumber_cs_imported(44);

            Assert.AreEqual(expected, 433494437);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_2()
        {
            Class2 fibo = new Class2();
            int expected = fibo.ce103_fibonacciNumber_cs_imported(36);

            Assert.AreEqual(expected, 9227465);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_3()
        {
            Class2 fibo = new Class2();
            int expected = fibo.ce103_fibonacciNumber_cs_imported(39);

            Assert.AreEqual(expected, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_1()
        {
            Class2 importedFibo = new Class2();
            Class1 writtenFibo = new Class1();
            int written = writtenFibo.ce103_fibonacciNumber_cs(18);
            int imported = importedFibo.ce103_fibonacciNumber_cs_imported(19);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_2()
        {
            Class2 importedFibo = new Class2();
            Class1 writtenFibo = new Class1();
            int written = writtenFibo.ce103_fibonacciNumber_cs(12);
            int imported = importedFibo.ce103_fibonacciNumber_cs_imported(13);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_3()
        {
            Class2 importedFibo = new Class2();
            Class1 writtenFibo = new Class1();
            int written = writtenFibo.ce103_fibonacciNumber_cs(49);
            int imported = importedFibo.ce103_fibonacciNumber_cs_imported(50);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strrev_test_1()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();

            string original = "BinaryCode";
            string reversed = "edoCyraniB";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_2()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();

            string original = "Audio";
            string reversed = "oiduA";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_3()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();

            string original = "Hardware";
            string reversed = "erawdraH";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }


        [TestMethod]
        public void ce103_strrev_cs_import_test_1()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Linkage"), "egakniL");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Developer"), "repoleveD", Strrev.ce103_strrev_cs_imported("Computer"), "retupmoC");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_2()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Information Technology"), "ygolonhceT noitamrofnI");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Information Database"), "esabataD noitamrofnI", Strrev.ce103_strrev_cs_imported("Computer Engineer"), "reenignE retupmoC");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_3()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Machine"), "enihcaM");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("SemanurErsoy"), "yosrErunameS", Strrev.ce103_strrev_cs_imported("SemanurErsoy"), "yosrErunameS");
        }

        [TestMethod]
        public void ce103_strlen_written_test_1()
        {
            Class1 stringLength = new Class1();
            string text = "Memory";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 6);
        }

        [TestMethod]
        public void ce103_strlen_written_test_2()
        {
            Class1 stringLength = new Class1();
            string text = "Network";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 7);
        }

        [TestMethod]
        public void ce103_strlen_written_test_3()
        {
            Class1 stringLength = new Class1();
            string text = "Password";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 8);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_1()
        {
            Class2 stringLength = new Class2();
            string text = "Index";

            int expected = stringLength.ce103_strlen_cs_imported(text);
            Assert.AreEqual(expected, 5);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_2()
        {
            Class2 stringLength = new Class2();
            string text = "Keyboard";

            int expected = stringLength.ce103_strlen_cs_imported(text);
            Assert.AreEqual(expected, 8);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_3()
        {
            Class2 stringLength = new Class2();
            string text = "Message";

            int expected = stringLength.ce103_strlen_cs_imported(text);
            Assert.AreEqual(expected, 7);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_1()
        {
            Class2 importedStrlen = new Class2();
            Class1 writtenStrlen = new Class1();
            string text = "Debug";

            int imported = importedStrlen.ce103_strlen_cs_imported(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_2()
        {
            Class2 importedStrlen = new Class2();
            Class1 writtenStrlen = new Class1();
            string text = "Steel";

            int imported = importedStrlen.ce103_strlen_cs_imported(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_3()
        {
            Class2 importedStrlen = new Class2();
            Class1 writtenStrlen = new Class1();
            string text = "Windows";

            int imported = importedStrlen.ce103_strlen_cs_imported(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strcat_written_test_1()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();
            string word1 = "Operating";
            string word2 = "System";

            string result = "OperatingSystem";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_2()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();
            string word1 = "Prime";
            string word2 = "Number";

            string result = "PrimeNumber";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_3()
        {
            // we're creating object of it otherwise we cannot use Class1 class
            Class1 reverse = new Class1();
            string word1 = "Serial";
            string word2 = "Driver";

            string result = "SerialDriver";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }
        [TestMethod]

        public void ce103_strcat_cs_import_test_1()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Space", "Character"), "SpaceCharacter");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Speel", "Checking"), "SpeelChecking", Strcat.ce103_strcat_cs_imported("Speel", "Checking"), "SpeelChecking");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_2()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Text", "Editor"), "TextEditor");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Mouse", "Button"), "MouseButton", Strcat.ce103_strcat_cs_imported("Mouse", "Button"), "MouseButton");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_3()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("New", "Line"), "NewLine");
        }
        // -----------------------------


        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Operating", "System"), "OperatingSystem", Strcat.ce103_strcat_cs_imported("Operating", "System"), "OperatingSystem");
        }

        [TestMethod]
        public void ce103_strcmp_written_test1()
        {
            Class1 strcmp = new Class1();
            const string str1 = "hithere";
            const string str2 = "hithere";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test2()
        {
            Class1 strcmp = new Class1();
            const string str1 = "hi";
            const string str2 = "there";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test3()
        {
            Class1 strcmp = new Class1();
            const string str1 = "hello";
            const string str2 = "hello";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test1()
        {
            Class2 strcmp = new Class2();
            const string str1 = "whatsapp";
            const string str2 = "whatsapp";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test2()
        {
            Class2 strcmp = new Class2();
            const string str1 = "facebook";
            const string str2 = "facebook";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test3()
        {
            Class2 strcmp = new Class2();
            const string str1 = "vmware";
            const string str2 = "virtualbox";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test1()
        {
            Class2 importedStrcmp = new Class2();
            Class1 writtenStrcmp = new Class1();
            const string str1 = "whatareyoudoing";
            const string str2 = "whatareyoudoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_imported(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test2()
        {
            Class2 importedStrcmp = new Class2();
            Class1 writtenStrcmp = new Class1();
            const string str1 = "howitsgoing";
            const string str2 = "howitsgoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_imported(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test3()
        {
            Class2 importedStrcmp = new Class2();
            Class1 writtenStrcmp = new Class1();
            const string str1 = "whatareyoudoing";
            const string str2 = "whatareyoudoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_imported(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcpy_written_test1()
        {
            Class1 strcpy = new Class1();
            string str1 = "Who";
            string str2 = "ami";
            string expectedStr = "ami";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test2()
        {
            Class1 strcpy = new Class1();
            string str1 = "Icouldntdothishomework";
            string str2 = "Fail";
            string expectedStr = "Fail";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test3()
        {
            Class1 strcpy = new Class1();
            string str1 = "Str";
            string str2 = "Cat";
            string expectedStr = "Cat";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }
        [TestMethod]
        public void ce103_strcpy_cs_import_test_1()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Hi"), "Hi", Strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }

        [TestMethod]
        public void ce103_strcpy_cs_import_test_2()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Engineering"), "Engineering", Strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }

        [TestMethod]
        public void ce103_strcpy_cs_import_test_3()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Software", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Software", "Hello"), "Hello", Strcpy.ce103_strcpy_cs_imported("Software", "Hello"), "Hello");
        }

        [TestMethod]
        public void ce103_hex2bin_written_test1()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "1313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test2()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "1111111111111111";
            byte[] expectedArr = { 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test3()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "FAFAFAFAFAFAFAFA";
            byte[] expectedArr = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "AAFBCD234324";
            byte[] expectedArr = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "2348975982379872239487";
            byte[] expectedArr = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "1313131313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test1()
        {
            Class2 imported = new Class2();
            Class1 written = new Class1();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test2()
        {
            Class2 imported = new Class2();
            Class1 written = new Class1();
            string hexstring = "ABCDEAEC";
            byte[] expectedArr = { 0xAB, 0xCD, 0xEA, 0xEC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test3()
        {
            Class2 imported = new Class2();
            Class1 written = new Class1();
            string hexstring = "91423FC23A234832FA";
            byte[] expectedArr = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test1()
        {
            Class1 written = new Class1();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test2()
        {
            Class1 written = new Class1();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test3()
        {
            Class1 written = new Class1();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test1()
        {
            Class1 written = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test2()
        {
            Class1 written = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test3()
        {
            Class1 written = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
    }
}
