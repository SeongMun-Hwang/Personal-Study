#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int T;
    cin >> T;

    while (T--) {
        int N;
        cin >> N;

        vector<vector<int>> tree(N + 1);
        vector<int> parent(N + 1, 0);
        vector<bool> isRoot(N + 1, true);


        for (int i = 0; i < N - 1; i++) {
            int A, B;
            cin >> A >> B;
            tree[A].push_back(B);
            parent[B] = A;
            isRoot[B]=false;
        }

        int root = 1;
        for (int i = 1; i <= N; i++) {
            if (isRoot[i]) {
                root = i;
                break;
            }
        }

        vector<int> depth(N + 1, 0);
        stack<int> st;
        st.push(root);

        while (!st.empty()) {
            int cur = st.top();
            st.pop();
            for (int next : tree[cur]) {
                depth[next] = depth[cur] + 1;
                st.push(next);
            }
        }

        int u, v;
        cin >> u >> v;

        while (depth[u] > depth[v]) u = parent[u];
        while (depth[v] > depth[u]) v = parent[v];

        while (u != v) {
            u = parent[u];
            v = parent[v];
        }

        cout << u << "\n";
    }
}