#include <iostream>
using namespace std;

int num_array[1025][1025];
int num_array_cal[1025][1025];

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n, m;
	cin >> n >> m;
	for (int i = 1; i <= n; i++) {
		for (int j = 1; j <= n; j++) {
			cin >> num_array[i][j];
			num_array_cal[i][j] = num_array[i][j]
				+ num_array_cal[i - 1][j]
				+ num_array_cal[i][j - 1]
				- num_array_cal[i - 1][j - 1];
		}
	}
	for (int i = 0; i < m; i++) {
		int x1, y1, x2, y2;
		cin >> x1 >> y1 >> x2 >> y2;

		int sum = num_array_cal[x2][y2]
			- num_array_cal[x1 - 1][y2]
			- num_array_cal[x2][y1 - 1]
			+ num_array_cal[x1 - 1][y1 - 1];

		cout << sum << "\n";
	}

	return 0;
}