#include <iostream>
#include <vector>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    int N, M, R;
    cin >> N >> M >> R;

    vector<vector<int>> A(N, vector<int>(M));

    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            cin >> A[i][j];

    int layers = min(N, M) / 2;

    for (int l = 0; l < layers; l++) {
        vector<int> v;

        int top = l, bottom = N - 1 - l;
        int left = l, right = M - 1 - l;

        for (int j = left; j <= right; j++) v.push_back(A[top][j]);
        for (int i = top + 1; i < bottom; i++) v.push_back(A[i][right]);
        for (int j = right; j >= left; j--) v.push_back(A[bottom][j]);
        for (int i = bottom - 1; i > top; i--) v.push_back(A[i][left]);

        int len = v.size();
        int rot = R % len;

        int idx = 0;

        for (int j = left; j <= right; j++)
            A[top][j] = v[(idx++ + rot) % len];

        for (int i = top + 1; i < bottom; i++)
            A[i][right] = v[(idx++ + rot) % len];

        for (int j = right; j >= left; j--)
            A[bottom][j] = v[(idx++ + rot) % len];

        for (int i = bottom - 1; i > top; i--)
            A[i][left] = v[(idx++ + rot) % len];
    }

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++)
            cout << A[i][j] << " ";
        cout << "\n";
    }
}