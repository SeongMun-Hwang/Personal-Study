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

    vector<int> result(N, 0);

    for (int i = 1; i <= N; i++) {
        int left_count;
        cin >> left_count;

        int empty = 0;
        for (int j = 0; j < N; j++) {
            if (result[j] == 0) {
                if (empty == left_count) {
                    result[j] = i;
                    break;
                }
                empty++;
            }
        }
    }

    for (int i = 0; i < N; i++) {
        cout << result[i] << " ";
    }

    return 0;
}