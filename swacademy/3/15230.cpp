#include<iostream>
#include <vector>
#include<cmath>
#include<algorithm>
using namespace std;

bool check(long long n) {
	if (n <= 3) return false;
	for (long long i = 2; i <= sqrt(n); ++i) {
		if (n % i == 0) {
			return true;
		}
	}
	return false;
}

int main()
{
	int n;
	cin >> n;
	for (int k = 0; k < n;k++) {
		string s;
		cin >> s;
		for (int i = 0; i <= 26; i++) {
			if (s[i] != 'a' + i) {
				cout << "#" << k + 1 << " " << i << "\n";
				break;
			}
		}
	}
	return 0;
}