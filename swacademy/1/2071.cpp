#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int j = 0; j < n; j++) {
		int number[10];
		double sum = 0;
		for (int i = 0; i < 10; i++) {
			cin >> number[i];
			sum += number[i];
		}
		cout << "#" << j + 1 << " " << round(sum / 10) << "\n";
	}
	return 0;
}