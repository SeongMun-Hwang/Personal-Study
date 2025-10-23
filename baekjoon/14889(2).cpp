#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
using namespace std;

int N;
int S[20][20];
int answer = INT_MAX;
vector<bool> selected;

int calculateDifference() {
    int start = 0, link = 0;

    for (int i = 0; i < N; ++i) {
        for (int j = i + 1; j < N; ++j) {
            if (selected[i] && selected[j])
                start += (S[i][j] + S[j][i]);
            else if (!selected[i] && !selected[j])
                link += (S[i][j] + S[j][i]);
        }
    }

    return abs(start - link);
}

void dfs(int idx, int count) {
    if (count == N / 2) {
        answer = min(answer, calculateDifference());
        return;
    }

    for (int i = idx; i < N; ++i) {
        selected[i] = true;      
        dfs(i + 1, count + 1);  
        selected[i] = false;
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N;
    selected.resize(N, false);

    for (int i = 0; i < N; ++i)
        for (int j = 0; j < N; ++j)
            cin >> S[i][j];

    dfs(0, 0);
    cout << answer << endl;
}
