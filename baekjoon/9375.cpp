#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<map>
using namespace std;

vector<int> meats(5);

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int t;
	cin >> t;

	while (t--) {
		int n;
		cin >> n;
		map<string, int> clothes;

		while (n--) {
			string a, b;
			cin >> a >> b;
			clothes[b]++;
		}

		int sum = 1;
		for (auto &a : clothes) {
			sum *= (a.second + 1);
		}
		cout << sum - 1 << "\n";
	}
	return 0;
}
