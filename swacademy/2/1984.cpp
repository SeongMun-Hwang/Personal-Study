#include<iostream>
#include<vector>
#include<algorithm>
#include<cmath>
using namespace std;

int main() {
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        vector<int> arr(10);
        for (int j = 0; j < 10; j++) {
            cin >> arr[j];
        }
        sort(arr.begin(), arr.end());
        float sum = 0;
        for (int j = 1; j < 9; j++) {
            sum += arr[j];
        }
        cout << "#" << i + 1 << " " << round(sum / 8) << "\n";
    }
}