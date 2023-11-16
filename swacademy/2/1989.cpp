#include<iostream>

using namespace std;
int main(){
    int n;
    cin >> n;
    for(int i=0;i<n;i++){
        string s;
        int pali=1;
        cin >> s;
        for(int j=0;j<s.length()/2;j++){
            if(s[j]!=s[s.length()-j-1]){pali=0; break;}
        }
        cout << "#"<<i+1<< " " <<pali<<"\n";
    }
}