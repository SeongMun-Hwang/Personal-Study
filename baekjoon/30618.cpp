#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    vector<int> v(N);
    int cur = N;

    int center = (N - 1) / 2;

    v[center] = cur--;
    if (N % 2 == 0) { 
        v[center + 1] = cur--;
    }

    for (int k = 1; k <= N; k++) {
        int left = center - k;
        if (left >= 0)
            v[left] = cur--;

        int right = center + k + (N % 2 == 0);
        if (right < N)
            v[right] = cur--;
    }

    for (int i = 0; i < N; i++) {
        cout << v[i] << ' ';
    }
    cout << '\n';
}