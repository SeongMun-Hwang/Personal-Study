#include <iostream>
#include <vector>
#include <algorithm>
#include <regex>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    double C;
    cin >> C;

    int available_freezes = static_cast<int>(C * 100 / 99);
    if (available_freezes > 2) available_freezes = 2;

    int N;
    cin >> N;

    vector<int> solved(N);
    int max_solved = 0;
    for (int i = 0; i < N; ++i) {
        cin >> solved[i];
        if (solved[i] > max_solved) {
            max_solved = solved[i];
        }
    }

    int max_streak = 0;
    int left = 0;
    int zero_count = 0;

    for (int right = 0; right < N; ++right) {
        if (solved[right] == 0) {
            zero_count++;
        }

        while (zero_count > available_freezes) {
            if (solved[left] == 0) {
                zero_count--;
            }
            left++;
        }

        max_streak = max(max_streak, right - left + 1);
    }

    cout << max_streak << "\n";
    cout << max_solved << "\n";

    return 0;
}