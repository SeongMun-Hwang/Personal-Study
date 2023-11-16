#include<iostream>
#include<algorithm>
#include <iomanip>
using namespace std;

int main() {
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		string a, b;
		cin >> a >> b;
		if (a == b) {
			cout << "#" << i + 1 << " " << a << "\n";
		}
		else {
			cout << "#" << i + 1 << " " << 1 << "\n";
		}
	}
	return 0;
}