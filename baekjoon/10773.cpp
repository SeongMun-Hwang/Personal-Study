#include<iostream>
#include<vector>
using namespace std;

int main() {
	int n;
	cin >> n;
	vector<int> sum;
	for (int i = 0; i < n; i++) {
		int input;
		cin >> input;
		if (input == 0) {
			sum.pop_back();
		}
		else {
			sum.push_back(input);
		}
	}
	int all = 0;
	for (int i = 0; i < sum.size(); i++) {
		all += sum[i];
	}
	cout << all;
}