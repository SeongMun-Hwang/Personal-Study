#include<iostream>

using namespace std;

int main(){
    int n;
    cin >> n;
    for(int i=0;i<n;i++){
        int num;
        int sum=0;
        cin >>num;
        for(int j=1;j<=num;j++){
            if(j%2==0){
                sum -=j;
            }
            else {
                sum+=j;
            }
        }
        cout <<"#"<<i+1<<" "<<sum <<"\n";
    }
}