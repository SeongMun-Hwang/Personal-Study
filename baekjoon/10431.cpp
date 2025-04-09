#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int t;
		cin >> t;
		int count = 0;
		vector<int> v;
		for (int j = 0; j < 20; j++) {
			int height;
			cin >> height;
			bool inserted = false;

			for (int k = 0; k < v.size(); k++) {
				if (height < v[k]) {
					v.insert(v.begin() + k, height);
					count += v.size() - k - 1;
					inserted = true;
					break;
				}
			}
			if (!inserted) {
				v.push_back(height);
			}
		}
		cout << t << " " << count << "\n";
	}
}