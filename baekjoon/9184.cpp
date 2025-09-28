#include <iostream>
#include <stack>
#include <vector>
#include <string>
using namespace std;

int a, b, c;
int table[101][101][101];

int w(int a, int b, int c) {
	if (a <= 0 || b <= 0 || c <= 0) {
		return 1;
	}
	if (a > 20 || b > 20 || c > 20) {
		return w(20, 20, 20);
	}
	int& memory = table[a + 50][b + 50][c + 50];
	if (memory != 0) return memory;

	if (a < b && b < c) {
		memory = w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
	}
	else {
		memory = w(a - 1, b, c) + w(a - 1, b - 1, c) + w(a - 1, b, c - 1) - w(a - 1, b - 1, c - 1);
	}
	return memory;
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	while (true) {
		cin >> a >> b >> c;
		if (a == -1 && b == -1 && c == -1) return 0;
		cout << "w(" << a << ", " << b << ", " << c << ") = " << w(a, b, c) << "\n";
	}

	return 0;
}