#include<iostream>
#include<vector>
using namespace std;

int main() {
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int h1, m1, h2, m2, h, m;
		cin >> h1 >> m1 >> h2 >> m2;
		m = m1 + m2;
		h = h1 + h2;
		if (m > 60) {
			m -= 60;
			h++;
		}
		if (h > 12) {
			h -= 12;
		}
		cout << "#" << i + 1 << " " << h << " "<<m << "\n";
	}
}