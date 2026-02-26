#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    vector<int> a(N);
    for (int i = 0; i < N; i++) {
        cin >> a[i];
    }

    if (next_permutation(a.begin(), a.end())) {
        for (int i = 0; i < N; i++) {
            cout << a[i] << ' ';
        }
    }
    else {
        cout << -1;
    }

    return 0;
}