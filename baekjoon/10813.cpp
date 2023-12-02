#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
#include<climits>
using namespace std;

vector<int> v;

void f(int a, int b) {
    int c;
    c = v[a];
    v[a] = v[b];
    v[b] = c;
}

int main(){
    int n, m;
    cin >> n >> m;
    for (int i = 1; i <= n; i++) {
        v.push_back(i);
    }
    for (int i = 0; i < m; i++) {
        int a, b;
        cin >> a >> b;
        f(a-1, b-1);
    }
    for (int i = 0; i < n; i++) {
        cout << v[i] << " ";
    }
}