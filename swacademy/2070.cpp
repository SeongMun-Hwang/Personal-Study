#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int j = 0; j < n; j++) {
		int a, b;
		cin >> a >> b;
		if (a > b) {
			cout << "#" << j + 1 << " " << ">" << "\n";
		}
		else if (a < b) {
			cout << "#" << j + 1 << " " << "<" << "\n";
		}
		else if (a == b) {
			cout << "#" << j + 1 << " " << "=" << "\n";
		}
	}
	return 0;
}