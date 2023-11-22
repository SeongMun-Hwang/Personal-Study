#include <iostream>
#include <string>
#include <stack>
#include<algorithm>
using namespace std;

int main() {
	int n;
	cin >> n;
	while (n--) {
		int x, y;
		cin >> x >> y;
		if (min(x, y) == 1) {
			cout << max(x, y) << "\n";
		}
		else {
			for (int j = max(x, y); j <= x * y; j += max(x, y)) {
				if (j % x == 0 && j % y == 0) {
					cout << j << "\n";
					break;
				}
			}
		}
	}
	return 0;
}