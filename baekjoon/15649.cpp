#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int n, m;
vector<int> arr;
vector<bool> visited(10, false);
void BackTrack(int depth) {
    if (depth == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << " ";
        }
        cout << "\n";
        return;
    }
    for (int i = 1; i <= n; i++) {
        if (!visited[i]) {
			visited[i] = true;
			arr.push_back(i);
			BackTrack(depth + 1);
			arr.pop_back();
			visited[i] = false;
        }
    }
}

int main() {
    cin >> n >> m;
	BackTrack(0);

    return 0;
}