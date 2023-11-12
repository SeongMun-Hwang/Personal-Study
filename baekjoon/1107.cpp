#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
#include <string>

using namespace std;

bool broken[10];

// 해당 채널을 누를 수 있는지 확인하는 함수
bool canPress(int channel) {
    if (channel == 0) return !broken[0];
    while (channel > 0) {
        if (broken[channel % 10]) return false;
        channel /= 10;
    }
    return true;
}

int main() {
    int N, M;
    cin >> N >> M;
    for (int i = 0; i < M; i++) {
        int x;
        cin >> x;
        broken[x] = true;
    }

    // +, - 버튼만 사용하는 경우
    int minPress = abs(N - 100);

    // 0부터 100만0까지 모든 채널을 검사
    for (int i = 0; i <= 1000000; i++) {
        if (canPress(i)) {
            int press = to_string(i).length() + abs(i - N);
            minPress = min(minPress, press);
        }
    }

    cout << minPress << endl;

    return 0;
}
