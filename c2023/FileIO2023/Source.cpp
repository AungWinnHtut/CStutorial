#include<iostream>
#include<fstream>
#include<string>
using namespace std;
int main()
{
	ofstream fo;
	fo.open("d:\\test.txt", ios::app); //in,out,app   r,w,a
	if (fo.fail())
	{
		cout << "Error! File cannot be opened!" << endl;
		return 1;
	}
	cout << "writing into file1" << endl;
	fo<< "1 into file2" << endl;
	fo << "2 into file3" << endl;
	fo << "3 into file4" << endl;
	fo.close();
	system("notepad d:\\test.txt");
	ifstream fi("d:\\test.txt");
	if (fi.fail())
	{
		cout << "Error! File cannot be opened!" << endl;
		return 1;
	}
	string line = "";
	fi >> line;
	cout << line << endl;
	fi.close();

	
	return 0;
}