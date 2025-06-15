#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> v;
    int n;
    cin >> n;
    for(int i=0;i<n;i++){
        int number;
        cin >> number;
        if(number%2==0){
            v.push_back(number);
        }
    }
    for(int i=v.size()-1;i>=0;i--){
        cout << v[i] << " ";
    }
    return 0;
}