#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <cmath>
#include <climits>
using namespace std;

int T;

int main() {
	cin >> T;
	while (T--) {
		int n;
		cin >> n;
		vector<int> people(n);
		vector<int> cnt(201,0);
		for (int i = 0; i < n; i++) {
			cin >> people[i];
			cnt[people[i]]++;
		}
		int score = 1;
		vector<vector<int>> scores(201);
		vector<int> total(201, 0);
		for (int i = 0; i < n; i++) {
			int team = people[i];
			if (cnt[team] == 6) {
				scores[team].push_back(score);
				if (scores[team].size() <= 4) {
					total[team] += score;
				}
				score++;
			}
		}
		int winner = 0;
		int best = INT_MAX;
		int maxTeam = *max_element(people.begin(), people.end());
		for (int i = 1; i <= maxTeam; i++) {
			if (cnt[i] == 6) {
				if (best > total[i]) {
					best = total[i];
					winner = i;
				}
				else if (total[i] == best) {
					if (scores[i][4] < scores[winner][4]) {
						winner = i;
					}
				}
			}
		}
		cout << winner << "\n";
	}

	return 0;
}