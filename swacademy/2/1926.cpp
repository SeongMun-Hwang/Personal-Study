#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int j = 1; j <= n; j++) {
		int count = 0;
		int num = j;
		while (num > 0) {
			if (num % 10 !=0 && num % 10 % 3 == 0) {
				count++;
			}
			num /= 10;
		}
		if (count > 0) {
			while (count > 0) {
				cout << "-";
				count--;
			}
		}
		else {
			cout << j;
		}
		cout << " ";
	}
	return 0;
}