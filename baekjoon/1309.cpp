#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
using namespace std;

int N;
int arr[100001][3];
int MOD = 9901;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N;
    arr[1][0] = 1;
    arr[1][1] = 1;
    arr[1][2] = 1;

    for (int i = 2; i <= N; i++) {
        arr[i][0] = (arr[i - 1][0] + arr[i - 1][1] + arr[i - 1][2]) % MOD;
        arr[i][1] = (arr[i - 1][0] + arr[i - 1][2]) % MOD;
        arr[i][2] = (arr[i - 1][0] + arr[i - 1][1]) % MOD;
    }
    cout << (arr[N][0] + arr[N][1] + arr[N][2]) % MOD;
    return 0;
}
