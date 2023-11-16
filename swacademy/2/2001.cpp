#include<iostream>
#include <vector>
#include<algorithm>
using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int k = 0; k < n; k++) {
		int n, m;
		cin >> n >> m;
		vector<vector<int>> vec(n,vector<int>(n));
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				cin >> vec[i][j];
;			}
		}
		int _max = 0;
		for (int a = 0; a < n - m+1; a++) {
			for (int b = 0; b < n - m+1; b++) {
				int sum = 0;
				for (int i = a; i < a + m; i++) {
					for (int j = b; j < b+m; j++) {
						sum += vec[i][j];
					}
				}
				_max = max(sum, _max);
			}
		}
		cout << "#" << k + 1 << " " << _max << "\n";
	}
	return 0;
}