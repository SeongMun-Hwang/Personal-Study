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
    v.resize(N);
    for (int i = 0; i < N; i++) {
        cin >> v[i];
    }

    vector<int> v2(N, 1);
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < i; j++) {
            if (v[j] > v[i]) {
                v2[i] = max(v2[j] + 1, v2[i]);
            }
        }
    }
    cout << *max_element(v2.begin(), v2.end());
    return 0;
}
