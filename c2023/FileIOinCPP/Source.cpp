#include<iostream>
#include<fstream>
#include<string>
using namespace std;

int main()
{
	fstream myFile;
	myFile.open("D:\\test.txt", ios::out); //out - write
	if (myFile.is_open())
	{
		myFile << "Hello\nI am Dr. Aung Win Htut";
		myFile.close();
	}
	system("notepad d:\\test.txt");

}