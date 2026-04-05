#include <iostream>
#include <vector>
using namespace std;

struct Query {
    int num;
    int strike;
    int ball;
};

int main() {
    int N;
    cin >> N;

    vector<Query> queries(N);

    for (int i = 0; i < N; i++) {
        cin >> queries[i].num >> queries[i].strike >> queries[i].ball;
    }

    int answer = 0;

    for (int i = 123; i <= 987; i++) {
        int a = i / 100;
        int b = (i / 10) % 10;
        int c = i % 10;

        if (a == 0 || b == 0 || c == 0) continue;
        if (a == b || b == c || a == c) continue;

        bool valid = true;

        for (auto& q : queries) {
            int x = q.num / 100;
            int y = (q.num / 10) % 10;
            int z = q.num % 10;

            int strike = 0;
            int ball = 0;

            if (a == x) strike++;
            if (b == y) strike++;
            if (c == z) strike++;

            if (a == y || a == z) ball++;
            if (b == x || b == z) ball++;
            if (c == x || c == y) ball++;

            if (strike != q.strike || ball != q.ball) {
                valid = false;
                break;
            }
        }

        if (valid) answer++;
    }

    cout << answer << endl;
    return 0;
}