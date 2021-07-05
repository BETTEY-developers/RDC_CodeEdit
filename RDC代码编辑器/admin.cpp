#include<iostream>
#include<cstdlib>

using namespace std;

int zip(string filename)
{
	string zipfilename = "rar a \"" + filename + ".rar \" \"D:\\RDC代码编辑器CSharp\\0.0.1 Dll\"";
	system(zipfilename);
}

int main()
{
	cout << "请输入代码包名称：" << endl;
	string file;
	cin >> file;
	zip(file);

	return 0;
}