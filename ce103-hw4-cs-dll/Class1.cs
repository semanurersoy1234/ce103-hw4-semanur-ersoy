using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class Class1
    {
		public int ce103_fibonacciNumber_cs(int fiIndex)
		{
			int n = 0, first = 0, second = 1, result = 0, i;
			//INT, INTEGER, INT4		:	-2147483648, +2147483647
			for (i = 0; i < fiIndex; i++)
			{
				if (i <= 1)
					result = i;
				else
				{
					result = first + second;
					first = second;
					second = result;
				}
			}

			return result;
		}
		public string ce103_strrev_cs(string fiStr)
		{
			string rvrsdStr = "";
			for (int cnt = fiStr.Length - 1; cnt >= 0; cnt--)
			{
				rvrsdStr += fiStr[cnt];
			}
			return rvrsdStr;
		}
		public int ce103_strlen_cs(string fiStr)
		{
			int len = 0;
			foreach (char x in fiStr)
			{
				len += 1;
			}
			return len;
		}
		public string ce103_strcat_cs(string fiDest, string fiSrc)
		{
			return fiDest + fiSrc;
		}
		public int ce103_strcmp_cs(string fiLhs, string fiRhs)
		{
			int i1 = 0, i2 = 0;
			for (int x = 0; x < (fiLhs.Length > fiRhs.Length ? fiLhs.Length : fiRhs.Length); x++)
			{
				i1 += (x >= fiLhs.Length ? 0 : fiLhs[x]) - (x >= fiRhs.Length ? 0 : fiRhs[x]);
				if (i2 < 0)
				{
					if (i1 < 0)
						i2 += i1;
					if (i1 > 0)
						i2 += -i1;
				}
				else
				{
					i2 += i1;
				}
			}
			return i2;
		}
		public string ce103_strcpy_cs(string foDestination, string fiSource)
		{

			foDestination = fiSource;
			return foDestination;
		}
		public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
		{
			//char[] foBinArr = new char[fiHexLen / 2];

			int[] count = { 0, 0 };  // count array for storing ascii and hex value of selected element 
			for (int a = 0; a < fiHexLen; a += 2)
			{  // array for assigning foBin elements
				char[] temp = new char[2];  // store two character from fiHex func
				int hexint = 0;  // hexint stores sum of two ascii values generated from hex base
				for (int b = 0; b < 2; b++)
				{  // for loop for calculating sum of ascii values
					temp[b] = (char)fiHex[a + b];  // assigning first fiHex element to temp
					if (b == 0)
					{  // if b == 0 meaning first element of temp
					  
						if (temp[b] >= '0' && temp[b] <= '9')
						{  // bounds
							count[b] = temp[b] - '0';  // find int value of nibble
							count[b] *= 16;  // multiply by 16 because of 16^1*hex digit
						}
						else if (temp[b] >= 'A' && temp[b] <= 'F')
						{  // bounds
							count[b] = temp[b] - 'A' + 10;  // take difference between temp and 'A' then plus 10
							count[b] *= 16;
						}
					}
					else
					{  // means 1
						if (temp[b] >= '0' && temp[b] <= '9')
						{
							count[b] = temp[b] - '0';  // we're not multiplying by 16 because it's 16^0 digit
						}
						else if (temp[b] >= 'A' && temp[b] <= 'F')
						{
							count[b] = temp[b] - 'A' + 10;
						}
					}
					hexint += count[b];  // get two digit value's sum and assign it to hexint
				}
				foBin[a / 2] = (byte)hexint;  // assigning summed values to foBin
			}
		}
		public void ce103_bin2hex_cs(byte[] fiBin, int fiBinLen, char[] foHex)
		{
			//char[] foHexArr = new char[fiBinLen * 2];
			//foHexArr = foHex.ToCharArray();
			char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			
			for (int x = 0; x < fiBinLen; x++)
			{
				foHex[x * 2] = arr[fiBin[x] >> 4];  // it means divide by 16. arr[fiBin[i] / 16] is true also
				foHex[x * 2 + 1] = arr[fiBin[x] & 0x0F];  // if i = 0 then fiBin[0] & 0x0f Note: fiBin[0] = 0x13
			}                                            
		}
	}
}
