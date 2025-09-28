#include <iostream>
#include <stack>
#include <vector>
#include <string>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int T, x1, y1, x2, y2;
	int n;

	cin >> T;
	while (T--) {
		cin >> x1 >> y1 >> x2 >> y2;
		cin >> n;
		int cnt = 0;
		while (n--) {
			int cx, cy, cr;
			cin >> cx >> cy >> cr;
			bool dot1 = ((x1 - cx) * (x1 - cx) + (y1 - cy) * (y1 - cy)) < cr * cr;
			bool dot2 = ((x2 - cx) * (x2 - cx) + (y2 - cy) * (y2 - cy)) < cr * cr;
			if (dot1 != dot2) cnt++;
		}
		cout << cnt << "\n";
	}

	return 0;
}