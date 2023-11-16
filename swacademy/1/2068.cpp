#include<iostream>
#include<algorithm>
#include<vector>
using namespace std;

int main(){
    int n;
    cin >> n;
    for(int i=0;i<n;i++){
        vector<int> number(10);
        for(int j=0; j<10;j++){
            cin >> number[j];
        }
        sort(number.begin(),number.end());
        cout << "#" << i+1 << " " << number[9] << "\n";
    }
}