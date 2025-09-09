#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <deque>
using namespace std;

int N, K;
struct score {
	int country;
	int gold;
	int silver;
	int bronze;
};
bool cmp(score& a, score& b) {
	if (a.gold == b.gold) {
		if (a.silver == b.silver) {
			if (a.bronze == b.bronze) {
				return a.country == K;
			}
			return a.bronze > b.bronze;
		}
		return a.silver > b.silver;
	}
	return a.gold > b.gold;
}
int main() {
	cin >> N >> K;
	deque<score> scores(N);
	for (int i = 0; i < N; i++) {
		int n, a, b, c;
		cin >> scores[i].country >> scores[i].gold >> scores[i].silver >> scores[i].bronze;
	}
	sort(scores.begin(), scores.end(), cmp);
	for (int i = 0; i < N; i++) {
		if (scores[i].country == K) {
			cout << i + 1;
			return 0;
		}
	}
	return 0;
}