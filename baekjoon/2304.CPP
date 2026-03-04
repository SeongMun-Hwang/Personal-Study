#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    vector<pair<int, int>> v(N);

    for (int i = 0; i < N; i++)
        cin >> v[i].first >> v[i].second;

    sort(v.begin(), v.end());

    int index = 0;
    for (int i = 1; i < N; i++)
        if (v[i].second > v[index].second)
            index = i;

    int area = 0;

    int height = v[0].second;
    for (int i = 0; i < index; i++) {
        height = max(height, v[i].second);
        int width = v[i + 1].first - v[i].first;
        area += height * width;
    }

    height = v[N - 1].second;
    for (int i = N - 1; i > index; i--) {
        height = max(height, v[i].second);
        int width = v[i].first - v[i - 1].first;
        area += height * width;
    }

    area += v[index].second;

    cout << area;
}