#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;
    for(int i=0;i<n;i++){
        int a, b;
        int cnt = 0;
        cin >> a >> b;
        for(int j=a; j<=b; j++){
            if(j%2==0) cnt+=j;
        }
        cout << cnt << "\n";
    }
    return 0;
}