#include<iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    for (int j = 0; j < n; j++) {
        int number[10];
        int sum = 0;
        for (int i = 0; i < 10;i++) {
            cin >> number[i];
            if (number[i] % 2 != 0) {
                sum += number[i];
            }
        }
        cout << "#" << j + 1 << " " << sum << "\n";
    }
    return 0;
}