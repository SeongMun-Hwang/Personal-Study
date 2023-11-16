#include<iostream>
#include<algorithm>
#include <iomanip>
using namespace std;

int main() {
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		float a, b, c;
		float x, y, z;
		float minnum;
		cin >> a >> b >> c;
		x = abs(2*b - a - c);
		y = abs((a + c) / 2 - b);
		z = abs(2 * b - a - c);
		minnum = min(x,y);
		minnum = min(minnum, z);
		cout << "#"<<i+1 <<" "<< fixed << setprecision(1) << minnum << "\n";
	}
}