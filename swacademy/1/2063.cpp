#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

int main(){
    int n;
    cin >> n;
    vector<int> number(n);
    for(int i=0;i<n;i++){
        cin >> number[i];
    }
    sort(number.begin(),number.end());
    cout << number[n/2];
}