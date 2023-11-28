#include<iostream>
#include<stack>
#include<string>
using namespace std;

int main() {
	std::ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int m;
		cin >> m;
		switch (m)
		{
		case 1:
			cout << "1\n";
			break;
		case 2:
			cout << "2\n";
			break;
		case 3:
			cout << "4\n";
			break;
		case 4:
			cout << "7\n";
			break;
		case 5:
			cout << "13\n";
			break;
		case 6:
			cout << "24\n";
			break;
		case 7:
			cout << "44\n";
			break;
		case 8:
			cout << "81\n";
			break;
		case 9:
			cout << "149\n";
			break;
		case 10:
			cout << "274\n";
		}
	}
}