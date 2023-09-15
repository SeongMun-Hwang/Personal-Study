#include <iostream>
#include <vector>
#include <numeric>
#include<algorithm>

using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> height;
    for (int i = 0; i < 9; i++) {
        int n;
        cin >> n;
        height.push_back(n);
    }
    sort(height.begin(), height.end());
    int sum = accumulate(height.begin(), height.end(), 0);
    for (int i = 0; i < height.size()-1; i++) {
        for (int j = i + 1; j < height.size(); j++) {
            if (height[i] + height[j] == sum - 100) {
                height.erase(height.begin() + j);
                height.erase(height.begin() + i);
                for (int k = 0; k < height.size(); k++) {
                    cout << height[k] << "\n";
                }
                return 0;
            }
        }
    }

    return 0;
}
