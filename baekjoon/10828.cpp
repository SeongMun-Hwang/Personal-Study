#include <iostream>
#include<stack>
using namespace std;

int main(){
    int n;
    stack<int> st;
    cin >> n;
    while (n--) {
        string s;
        int num;
        cin >> s;
        if (s == "push") {
            cin >> num;
            st.push(num);
        }
        else if (s == "pop") {
            if (st.size() == 0) {
                cout << "-1\n";
            }
            else {
                cout << st.top() << "\n";
                st.pop();
            }
        }
        else if (s == "size") {
            cout << st.size() << "\n";
        }
        else if (s == "empty") {
            if (st.empty()) {
                cout << "1\n";
            }
            else { cout << "0\n"; }
        }
        else if (s == "top") {
            if (st.size() == 0) {
                cout << "-1\n";
            }
            else {
                cout << st.top() << "\n";
            }
        }
    }
    return 0;
}