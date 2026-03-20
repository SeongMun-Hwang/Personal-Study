#include <iostream>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int n;
    while (cin >> n) {
        int remainder = 1 % n;
        int length = 1;

        while (remainder != 0) {
            remainder = (remainder * 10 + 1) % n;
            length++;
        }

        cout << length << '\n';
    }

    return 0;
}