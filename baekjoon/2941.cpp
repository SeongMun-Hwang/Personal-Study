#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
#include<climits>
using namespace std;

int main(){
    int num = 0;
    string s[] = { "c=","c-","dz=","d-","lj","nj","s=","z=" };
    string input;
    cin >> input;

    for (int i = 0; i < input.length(); i++) {
        for (int j = 0; j < 8; j++) {
            if (input.substr(i, s[j].size()) == s[j]) {
                i += s[j].size() - 1;
                break;
            }
        }
        num++;
    }
    cout << num;
    return 0;
}