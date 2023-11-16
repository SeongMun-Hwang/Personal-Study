#include<iostream>
using namespace std;

int main() {
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        string date;
        cin >> date;
        string year, month, day;
        year = date.substr(0, 4);
        month = date.substr(4, 2);
        day = date.substr(6, 2);
        bool is = false;
        if (month == "01" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "02" && day >= "01" && day <= "28") {
            is = true;
        }
        else if (month == "03" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "04" && day >= "01" && day <= "30") {
            is = true;
        }
        else if (month == "05" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "06" && day >= "01" && day <= "30") {
            is = true;
        }
        else if (month == "07" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "08" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "09" && day >= "01" && day <= "30") {
            is = true;
        }
        else if (month == "10" && day >= "01" && day <= "31") {
            is = true;
        }
        else if (month == "11" && day >= "01" && day <= "30") {
            is = true;
        }
        else if (month == "12" && day >= "01" && day <= "31") {
            is = true;
        }
        if (is) {
            cout << "#" << i + 1 << " " << year << "/" << month << "/" << day  << "\n";
        }
        else {
            cout << "#" << i + 1 << " " << -1 << "\n";
        }
    }
}