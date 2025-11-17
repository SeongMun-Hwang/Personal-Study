#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<string>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N;
	cin >> N;

	vector<int> stuff(5, 0);
	while (N--) {
		int n;
		cin >> n;
		stuff[n]++;
	}

	int box = 0;
	box += stuff[4];

	box += stuff[3];
	stuff[1] = max(0, stuff[1] - stuff[3]);

	box += stuff[2] / 2;
	stuff[2] %= 2;

	if (stuff[2] == 1) {
		box++;
		stuff[1] = max(0, stuff[1] - 2);
		stuff[2] = 0;
	}
	box += (stuff[1] + 3) / 4;

	cout << box;

	return 0;
}
