#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
using namespace std;

int m, n, x, y;

int gcd(int a, int b) {
	if (b == 0) {
		return a;
	}
	else {
		return gcd(b, a % b);
	}
}
int Cal(int a, int b) {
	int n = gcd(a, b);
	return a * b / n;
}
int main() {
	int num;
	cin >> num;
	for (int j = 0; j < num; j++) {
		cin >> m >> n >> x >> y;
		int limit = Cal(m, n);
		int k = x;
		bool found = false;
		while (k <= limit) {
			if ((k - y) % n == 0) {
				cout << k << "\n";
				found = true;
				break;
			}
			k += m;
		}
		if (!found) cout << "-1\n";
	}
	return 0;
}