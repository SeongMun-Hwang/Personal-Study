#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <limits.h>
#include <algorithm>
using namespace std;

int N;
string balls;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	cin >> N >> balls;

	int leftR = 0, rightR = 0, leftB = 0, rightB = 0;
	for (int i = 0; i < N; i++) {
		if (balls[i] == 'R') leftR++;
		else break;
	}
	for (int i = N - 1; i >= 0; i--) {
		if (balls[i] == 'R')rightR++;
		else break;
	}
	for (int i = 0; i < N; i++) {
		if (balls[i] == 'B') leftB++;
		else break;
	}
	for (int i = N - 1; i >= 0; i--) {
		if (balls[i] == 'B') rightB++;
		else break;
	}
	int totalR = count(balls.begin(), balls.end(), 'R');
	int totalB = N - totalR;

	int moveRleft = totalR - leftR;
	int moveRright = totalR - rightR;
	int moveBleft = totalB - leftB;
	int moveBright = totalB - rightB;

	cout << min({ moveRleft, moveRright, moveBleft, moveBright });

	return 0;
}