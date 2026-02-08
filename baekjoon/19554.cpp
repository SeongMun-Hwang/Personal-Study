#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    long long N;
    cin >> N;

    long long l = 1, r = N;

    while (l <= r) {
        long long mid = (l + r) / 2;

        cout << "? " << mid << endl;
        int result;
        cin >> result;

        if (result == 0) {
            cout << "= " << mid << endl;
            break;
        }
        else if (result == -1) {
            l = mid + 1;
        }
        else {
            r = mid - 1;
        }
    }
}