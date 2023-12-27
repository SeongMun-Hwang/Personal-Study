#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    string s;
    vector<int> v(26, 0);
    cin >> s;

    for (int i = 0; i < s.length(); i++) {
        v[s[i] - 'a']++;
    }
    for (int i = 0; i < v.size(); i++) {
        cout << v[i] << " ";
    }
    return 0;
}
