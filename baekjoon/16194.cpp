#include <iostream>
#include <algorithm>
using namespace std;

int N;
int P[1001];
int dp[1001];

int main()
{
    cin >> N;
    for(int i = 1; i <= N; i++)
        cin >> P[i];

    for(int i = 1; i <= N; i++)
    {
        dp[i] = 1e9;
        for(int j = 1; j <= i; j++)
        {
            dp[i] = min(dp[i], dp[i-j] + P[j]);
        }
    }

    cout << dp[N];
}