#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int N, L;
    if (!(cin >> N >> L)) return 0;

    vector<int> spots(N);
    for (int i = 0; i < N; i++) {
        cin >> spots[i];
    }

    sort(spots.begin(), spots.end());

    int count = 0;
    double range = 0;

    for (int i = 0; i < N; i++) {
        if (spots[i] > range) {
            count++;
            range = spots[i] - 0.5 + L;
        }
    }

    cout << count << endl;

    return 0;
}