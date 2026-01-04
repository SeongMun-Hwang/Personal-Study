#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int ask(int k) {
    cout << "? " << k << '\n';
    cout.flush();

    int x;
    cin >> x;
    return x;
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    int first = ask(1);
    int last = ask(N);

    int answer;
    if (last > first) answer = 1;
    else if (last < first) answer = -1;
    else answer = 0;

    cout << "! " << answer << '\n';
    cout.flush();
    return 0;
}