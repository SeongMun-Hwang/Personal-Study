#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<stack>
using namespace std;

vector<int> meats(5);

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int T;
	cin >> T;
	while (T--) {
		int X, Y;
		cin >> X >> Y;
		for (int i = 0; i < 5; i++) {
			cin >> meats[i];
		}

		bool isValid = false;
		for (int i = 0; i < 32; i++) {
			int sum = 0;
			for (int j = 0; j < 5; j++) {
				if (i & (1 << j))sum += meats[j];
			}
			if (sum >= X && sum <= Y) {
				isValid = true;
				break;
			}
		}
		cout << (isValid ? "YES\n" : "NO\n");
	}

	return 0;
}
