#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		string sentence;
		cin >> sentence;
		for (int j = 1; j < 10; j++) {
			string s1, s2;
			s1 = sentence.substr(0,j);
			s2 = sentence.substr(j, j);
			if (s1.compare(s2)==0) {
				cout << "#"<<i+1<<" " << j << "\n";
				break;
			}
		}
	}
	return 0;
}