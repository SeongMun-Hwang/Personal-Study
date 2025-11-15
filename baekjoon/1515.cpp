#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<string>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	string S;
	cin >> S;

	int index = 0;
	int N = 0;

	while (index < (int)S.size()) {
		N++;
		string str = to_string(N);

		for (char c : str) {
			if (index < S.size() && S[index] == c) {
				index++;
			}
		}
	}
	cout << N;

	return 0;
}
