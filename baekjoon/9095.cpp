#include<iostream>
#include<vector>
#include<string>
using namespace std;

int main() {
	std::ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	int n;
	cin >> n;
	vector<int> v;
	v.push_back(1);
	v.push_back(2);
	v.push_back(4);
	for (int i = 3; i < 10; i++) {
		v.push_back(v[i - 1] + v[i - 2] + v[i - 3]);
	}
	for (int i = 0; i < n; i++) {
		int m;
		cin >> m;
		cout << v[m - 1] << "\n";
	}
}