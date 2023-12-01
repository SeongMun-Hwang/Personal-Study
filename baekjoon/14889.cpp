#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
#include<climits>
using namespace std;

int N;
int S[20][20];

int calculateDifference(vector<int>& team) {
    int start = 0, link = 0;

    for (int i = 0; i < N; ++i) {
        for (int j = i + 1; j < N; ++j) {
            if (team[i] && team[j]) start += (S[i][j] + S[j][i]);
            if (!team[i] && !team[j]) link += (S[i][j] + S[j][i]);
        }
    }

    return abs(start - link);
}

int main() {
    cin >> N;
    vector<int> team(N);

    for (int i = 0; i < N; ++i) {
        for (int j = 0; j < N; ++j) {
            cin >> S[i][j];
        }
    }

    fill(team.begin() + N / 2, team.end(), 1);
    int answer = INT_MAX;

    do {
        int diff = calculateDifference(team);
        answer = min(answer, diff);
    } while (next_permutation(team.begin(), team.end()));

    cout << answer << endl;

    return 0;
}
