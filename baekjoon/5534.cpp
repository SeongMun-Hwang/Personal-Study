#include <iostream>
using namespace std;

bool CheckName(string sign, string name) {
	int n = sign.size(), m = name.size();
	for (int gap = 1; gap * (m - 1) < n; ++gap) {
		for (int start = 0; start + (m - 1) * gap < n; ++start) {
			bool match = true;
			for (int i = 0; i < m; ++i) {
				if (sign[start + i * gap] != name[i]) {
					match = false;
					break;
				}
			}
			if (match) return true;
		}
	}
	return false;
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int N;
	cin >> N;
	string name;
	cin >> name;
	int count = 0;

	for (int i = 0; i < N; i++) {
		string sign;
		cin >> sign;
		if (CheckName(sign, name)) {
			count++;
		}
	}
	cout << count;
	return 0;
}