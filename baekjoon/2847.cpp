#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int N;
    cin >> N;

    vector<int> score(N);
    for (int i = 0; i < N; i++)
        cin >> score[i];

    int answer = 0;

    for (int i = N - 2; i >= 0; i--) {
        if (score[i] >= score[i + 1]) {
            int newScore = score[i + 1] - 1;
            answer += score[i] - newScore;
            score[i] = newScore;
        }
    }

    cout << answer;

    return 0;
}