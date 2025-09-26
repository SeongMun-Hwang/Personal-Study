#include <iostream>
#include <stack>
#include <vector>
#include <string>
using namespace std;

int N;
vector<int> apart;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	cin >> N;
	apart.resize(N);
	for (int i = 0; i < N; i++) {
		cin >> apart[i];
	}
	vector<int> visible(N, 0);
	for (int i = 0; i < N; i++) {
		for (int j = i + 1; j < N; j++) {
			bool canSee = true;
			for (int k = i + 1; k < j; k++) {
				double slopeIJ = (double)(apart[j] - apart[i]) / (j - i);
				double slopeIK= (double)(apart[k] - apart[i]) / (k - i);
				if (slopeIJ <= slopeIK) {
					canSee = false;
				}
			}
			if (canSee) {
				visible[i]++;
				visible[j]++;
			}
		}
	}
	cout << *max_element(visible.begin(), visible.end());
	return 0;
}