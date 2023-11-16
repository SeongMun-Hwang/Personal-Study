#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int j = 0; j < n; j++) {
		int day;
		long long price_max = 0;
		cin >> day;
		int* price =new int[day];
		for (int i = 0; i < day; i++) {
			cin >> price[i];
		}
		int max = day - 1;
		for (int i = day-2; i >= 0; i--) {
			if (price[max] > price[i]) {
				price_max += price[max] - price[i];
			}
			else {
				max = i;
			}
		}
		cout << "#" << j + 1 << " " << price_max << "\n";
	}
	return 0;
}