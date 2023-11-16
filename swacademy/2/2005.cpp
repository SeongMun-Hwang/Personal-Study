#include<iostream>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int height;
		cin >> height;
		int** pascal = new int* [height];
		for (int j = 0; j < height; j++) {
			pascal[j] = new int[j+1];
			pascal[j][0] = 1;
			pascal[j][j] = 1;
		}
		for (int j = 2; j < height; j++) {
			for (int k = 1; k < j; k++) {
				pascal[j][k] = pascal[j - 1][k-1] + pascal[j - 1][k];

			}
		}
		cout << "#" << i + 1 << "\n";
		for (int j = 0; j < height; j++) {
			for (int k = 0; k < j+1; k++) {
				cout << pascal[j][k] << " ";
			}
			cout << "\n";
		}
		delete[] pascal;
	}
	return 0;
}