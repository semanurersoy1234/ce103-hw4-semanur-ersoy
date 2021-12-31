using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll2
{
    public class Class2
    {
        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp(int fiIndex);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_strrev_cpp(string fiStr);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_strlen_cpp(string fiStr);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_strcat_cpp(string fiDest, string fiSrc);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int ce103_strcmp_cpp(string fiLhs, string fiRhs);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern string ce103_strcpy_cpp(string foDestination, string fiSource);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern void ce103_hex2bin_cpp(string fiHex, int fiHexlen, byte[] foBin);

        [DllImport("ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern void ce103_bin2hex_cpp([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);



        public int ce103_fibonacciNumber_cs_imported(int fiIndex)
        {
            return ce103_fibonacciNumber_cpp(fiIndex);
        }
        public string ce103_strrev_cs_imported(string fiStr)
        {
            return ce103_strrev_cpp(fiStr);
        }
        public int ce103_strlen_cs_imported(string fiStr)
        {
            return ce103_strlen_cpp(fiStr);
        }
        public string ce103_strcat_cs_imported(string fiDest, string fiSrc)
        {
            return ce103_strcat_cpp(fiDest, fiSrc);
        }
        public int ce103_strcmp_cs_imported(string fiLhs, string fiRhs)
        {
            return ce103_strcmp_cpp(fiLhs, fiRhs);
        }
        public string ce103_strcpy_cs_imported(string foDestination, string fiSource)
        {
            return ce103_strcpy_cpp(foDestination, fiSource);
        }
        public void ce103_hex2bin_cs_imported(string fiHex, int fiHexLen, byte[] foBin)
        {
            ce103_hex2bin_cpp(fiHex, fiHexLen, foBin);
        }
        public void ce103_bin2hex_cs_imported([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
            ce103_bin2hex_cpp(fiBin, fiBinLen, foHex);
        }
    }
}