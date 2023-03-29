#include<iostream>
#include<fstream>
#include<string>
using namespace std;
int main()
{	
	ofstream fo("d:\\test2.txt");
	fo << "123456789abcdefghijklmnopqrstuvwxyz";
	fo.close();

	//reading
	ifstream fi("d:\\test.txt");
	if (fi.fail())
	{
		cout << "Error! File cannot be opened!" << endl;
		return 1;
	}
	string word = "";
	char c;
	fi.seekg(0, ios::end);
	streampos fsize = fi.tellg();
	for (int i = 1; i <= fsize; i++)
	{
		fi.seekg(-i, ios::end);
		fi.get(c);
		if (c != char(10))
		{
			cout << i << " " << (int)c << "-" << c << endl;
		}
		
	}
	
	
	fi.close();


	return 0;
}