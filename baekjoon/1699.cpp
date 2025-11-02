#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
using namespace std;

int N;
vector<int> v;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N;
    vector<int> v(N + 1, N);
    v[0] = 0;

    for (int i = 1; i <= N; i++) {
        for (int j = 1; j * j <= i; j++) {
            v[i] = min(v[i], v[i - j * j] + 1);
        }
    }
    cout << v[N];
    return 0;
}
