#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

void solve() {
    int N, M;
    cin >> N >> M;

    vector<int> A(N);
    vector<int> B(M);

    for (int i = 0; i < N; i++) {
        cin >> A[i];
    }
    for (int i = 0; i < M; i++) {
        cin >> B[i];
    }

    sort(B.begin(), B.end());

    long long count = 0;

    for (int i = 0; i < N; i++) {
        count += lower_bound(B.begin(), B.end(), A[i]) - B.begin();
    }

    cout << count << "\n";
}

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);

    int T;
    cin >> T;
    while (T--) {
        solve();
    }

    return 0;
}