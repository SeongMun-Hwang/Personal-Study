#include<iostream>
#include<vector>
using namespace std;

int main() {
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int w, length;
		cin >> w >> length;
		vector<vector<int>> square(w, vector<int>(w));
		for (int j = 0; j < w; j++) {
			for (int k = 0; k < w; k++) {
				cin >> square[j][k];
			}
		}
		int count = 0;
		for (int j = 0; j < w; j++) {
			int sum1 = 0, sum2 = 0;
			for (int k = 0; k < w; k++) {
				if (square[j][k] == 1) {
					sum1 += square[j][k];
				}
				else {
					if (sum1 == length) { count++; }
					sum1 = 0;
				}
				if (square[k][j] == 1) {
					sum2 += square[k][j];
				}
				else {
					if (sum2 == length) { count++; }
					sum2 = 0;
				}
			}
			if (sum1 == length) { count++; }
			if (sum2 == length) { count++; }
		}
		cout << "#" << i + 1 << " " << count << "\n";
	}
}