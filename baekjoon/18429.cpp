#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <iomanip>
using namespace std;

int N, K;
int A[9];
bool used[9];
int cnt = 0;

void DFS(int day, int weight) {
    if (day == N) {
        cnt++;
        return;
    }
    for (int i = 0; i < N; i++) {
        if (!used[i]) {
            int nextWeight = weight + A[i] - K;
            if (nextWeight >= 500) {
                used[i] = true;
                DFS(day + 1, nextWeight);
                used[i] = false;
            }
        }
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N >> K;
    for (int i = 0; i < N; i++) {
        cin >> A[i];
    }
    DFS(0, 500);
    cout << cnt;
    return 0;
}