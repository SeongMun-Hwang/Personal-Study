#include <iostream>
#include <string>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    string alphabet;

    cin >> N;
    cin >> alphabet;

    for (int i = 0; i < N; i++) {
        cout << alphabet;
    }

    return 0;
}