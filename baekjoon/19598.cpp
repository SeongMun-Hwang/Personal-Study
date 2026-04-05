#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int N;
    cin >> N;

    vector<pair<int, int>> meetings(N);

    for (int i = 0; i < N; i++) {
        cin >> meetings[i].first >> meetings[i].second;
    }

    sort(meetings.begin(), meetings.end());

    priority_queue<int, vector<int>, greater<int>> pq;

    pq.push(meetings[0].second);

    for (int i = 1; i < N; i++) {
        int start = meetings[i].first;
        int end = meetings[i].second;

        if (!pq.empty() && pq.top() <= start) {
            pq.pop();
        }

        pq.push(end);
    }

    cout << pq.size() << '\n';
    return 0;
}