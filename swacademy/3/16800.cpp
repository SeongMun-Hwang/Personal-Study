#include<iostream>
#include <vector>
#include<cmath>
#include<algorithm>
using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int k = 0; k < n; k++) {
		long long num;
		cin >> num;
		long long  a, b;
		a = 1;
		b = num;
		long long diff = num;
		for (long long i = 2; i < sqrt(num)+1; i++) {
			if (num % i == 0) {
				if (diff > num / i - i) {
					diff = num / i - i;
					a = i;
					b = num / i;
				}
			}
		}
		cout << "#" << k + 1 << " " << a+b-2 << "\n";
	}
	return 0;
}