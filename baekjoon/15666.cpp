#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
using namespace std;

int N, M;
vector<int> v;
vector<int> v2;

void DFS(int start, int depth) {
    if (depth == M) {
        for (int n : v2) {
            cout << n << " ";
        }
        cout << "\n";
        return;
    }

    int last = -1;
    for (int i = start; i < N; i++) {
        if (v[i] == last) continue;
        last = v[i];

        v2.push_back(v[i]);
        DFS(i, depth + 1);
        v2.pop_back();
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N >> M;
    v.resize(N);

    for (int i = 0; i < N; i++) {
        cin >> v[i];
    }
    sort(v.begin(), v.end());
    DFS(0, 0);
}
