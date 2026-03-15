#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    int n, w, L;
    cin >> n >> w >> L;

    vector<int> trucks(n);
    for (int i = 0; i < n; i++) cin >> trucks[i];

    queue<int> bridge;
    int time = 0;
    int weightSum = 0;
    int idx = 0;

    for (int i = 0; i < w; i++)
        bridge.push(0);

    while (idx < n) {
        time++;

        weightSum -= bridge.front();
        bridge.pop();

        if (weightSum + trucks[idx] <= L) {
            bridge.push(trucks[idx]);
            weightSum += trucks[idx];
            idx++;
        }
        else {
            bridge.push(0);
        }
    }

    time += w;

    cout << time;

    return 0;
}