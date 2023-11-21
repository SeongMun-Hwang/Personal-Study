#include<iostream>
#include <vector>
#include<algorithm>
using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int k = 0; k < n; k++) {
		int l=0;
		string str;
		cin >> l >> str;
		if (str.length() < 2 || str.length()%2==1) {
			cout << "#" << k + 1 << " No" << "\n";
		}
		else if (str.substr(0, l / 2) == str.substr(l / 2, l / 2)) {
			cout << "#" << k+1<<" Yes" << "\n";
		}
		else {
			cout << "#" << k + 1 << " No" << "\n";
		}
	}
	return 0;
}