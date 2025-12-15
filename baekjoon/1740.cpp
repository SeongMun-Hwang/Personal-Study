#include <iostream>
#include <random>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	long long n;
	cin >> n;

	long long result = 0;
	long long num = 1;

	while (n > 0) {
		if (n & 1) {
			result += num;
		}
		n >>= 1;
		num *= 3;
	}

	cout << result;
}