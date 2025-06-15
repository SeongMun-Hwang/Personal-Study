#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;
    int cnt=1;
    for(int i=1;i<=n;i++){
        for(int j=0;j<i;j++){
            cout << cnt << " ";
            cnt++;
        }
        cout << "\n";
    }
    return 0;
}