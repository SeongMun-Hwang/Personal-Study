#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<map>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N;
	cin >> N;
	
	vector<int> v(N);
	int l = 1, r = N;
	bool b = true;
	while (l <= r) {
		if (b) {
			cout << l++ << " ";
		}
		else {
			cout << r-- << " ";
		}
		b = !b;
	}

	return 0;
}