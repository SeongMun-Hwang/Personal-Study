#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
using namespace std;

int H, W, X, Y;

int main() {
	cin >> H >> W >> X >> Y;

	int row = H + X;
	int col = W + Y;

	vector<vector<int>> B(row, vector<int>(col));

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cin >> B[i][j];
			if (i >= X && j >= Y) {
				B[i][j] -= B[i - X][j - Y];
			}
		}
	}
	for (int i = 0; i < H; i++) {
		for (int j = 0; j < W; j++) {
			cout << B[i][j] << " ";
		}
		cout << "\n";
	}
	return 0;
}