#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int Cal(int n, int r, int c) {
	if (n == 0) return 0;
	int half = 1 << (n - 1);
	int areaSize = half * half;

    if (r < half && c < half) {
        return Cal(n - 1, r, c);
    }
    else if (r < half && c >= half) { 
        return areaSize + Cal(n - 1, r, c - half);
    }
    else if (r >= half && c < half) {
        return 2 * areaSize + Cal(n - 1, r - half, c);
    }
    else { 
        return 3 * areaSize + Cal(n - 1, r - half, c - half);
    }
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n, r, c;
	cin >> n >> r >> c;
	cout << Cal(n, r, c) << '\n';
	return 0;
}