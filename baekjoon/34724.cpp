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

	int N, M;
	cin >> N >> M;

	vector<string> cancer(N);
	for (int i = 0; i < N; i++) {
		cin >> cancer[i];
	}

	bool isSick = false;
	for (int i = 0; i < N - 1; i++) {
		for (int j = 0; j < M - 1; j++) {
			if (cancer[i][j] == '1' &&
				cancer[i + 1][j] == '1' &&
				cancer[i][j + 1] == '1' &&
				cancer[i + 1][j + 1] == '1')
			{
				isSick = true;
				break;
			}
		}
	}
	cout << isSick;

	return 0;
}
