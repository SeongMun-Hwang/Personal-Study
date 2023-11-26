#include <iostream>
#include <string>
#include <queue>
#include<cmath>
#include<algorithm>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);
	int x, y, z;
	cin >> x >> y >> z;
	if (x == y && y == z) {
		cout << 10000 + x * 1000;
	}
	else if (x == y || y == z || x == z) {
		int same;
		if (x == y || x == z) {
			same = x;
		}
		else {
			same = y;
		}
		cout << 1000 + same * 100;
	}
	else {
		cout << 100 * max(x, max(y, z));
	}
	return 0;
}