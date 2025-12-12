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
	
	int mid = N / 2;
	int l = 1;
	int r = mid + 1;
	for (int i = 0; i < N; i++) {
		if (i % 2 == 0) {
			cout << r++ << " ";
		}
		else {
			cout << l++ << " ";
		}
	}

	return 0;
}