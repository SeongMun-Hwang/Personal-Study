#include <iostream>
#include <string>

using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    string s;
    if (!(cin >> s)) return 0;

    int state = 0;
    bool fail = false;

    for (char c : s) {
        if (state == 0) {
            if (c == '0') state = 1;
            else if (c == '1') state = 2;
        } else if (state == 1) {
            if (c == '1') state = 0;
            else { fail = true; break; }
        } else if (state == 2) {
            if (c == '0') state = 3;
            else { fail = true; break; }
        } else if (state == 3) {
            if (c == '0') state = 4;
            else { fail = true; break; }
        } else if (state == 4) {
            if (c == '0') state = 4;
            else if (c == '1') state = 5;
        } else if (state == 5) {
            if (c == '1') state = 6;
            else if (c == '0') state = 1;
            else { fail = true; break; }
        } else if (state == 6) {
            if (c == '1') state = 6;
            else if (c == '0') state = 7;
        } else if (state == 7) {
            if (c == '0') state = 4;
            else if (c == '1') state = 0;
            else { fail = true; break; }
        }
        if (fail) break;
    }

    if (!fail && (state == 0 || state == 5 || state == 6)) {
        cout << "SUBMARINE";
    } else {
        cout << "NOISE";
    }

    return 0;
}