#pragma once
#include <iostream>
#include "../ce103-hw4-c-dll/ce103-hw4-c-dll.h"

extern "C" {
	__declspec(dllimport) int ce103_fibonacciNumber(int fiIndex);
	__declspec(dllexport) int ce103_fibonacciNumber_cpp(int fiIndex);
	__declspec(dllimport) char* ce103_strrev(char* fiStr);
	__declspec(dllexport) char* ce103_strrev_cpp(char* fiStr);
	__declspec(dllimport) int ce103_strlen(const char* fiStr);
	__declspec(dllexport) int ce103_strlen_cpp(const char* fiStr);
	__declspec(dllimport) char* ce103_strcat(char* fiDest, char* fiSrc);
	__declspec(dllexport) char* ce103_strcat_cpp(char* fiDest, char* fiSrc);
	__declspec(dllimport) int ce103_strcmp(const char* fiLhs, const char* fiRhs);
	__declspec(dllexport) int ce103_strcmp_cpp(const char* fiLhs, const char* fiRhs);
	__declspec(dllimport) char* ce103_strcpy(char* foDestination, const char* fiSource);
	__declspec(dllexport) char* ce103_strcpy_cpp(char* foDestination, const char* fiSource);
	__declspec(dllimport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin);
	__declspec(dllexport) void ce103_hex2bin_cpp(char* fiHex, int fiHexLen, unsigned char* foBin);
	__declspec(dllimport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex);
	__declspec(dllexport) void ce103_bin2hex_cpp(unsigned char* fiBin, int fiBinLen, char* foHex);
}