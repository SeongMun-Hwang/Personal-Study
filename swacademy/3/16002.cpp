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
	for (int k = 0; k < n; k++) {
		long long num;
		cin >> num;
		long long  a, b;
		a = 4 + num;
		b = 4;
		while (true) {
			if (check(a) && check(b)) {
				cout << "#" << k + 1 << " " << a << " " << b << "\n";
				break;
			}
			else {
				a++;
				b++;
			}
		}
	}
	return 0;
}