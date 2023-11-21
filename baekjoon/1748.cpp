#include <iostream>
#include<cmath>
using namespace std;

long long countDigits(long long N) {
    long long count = 0;
    long long length = 1;

    while (N >= pow(10, length)) {
        count += 9 * pow(10, length - 1) * length;
        length++;
    }

    count += (N - pow(10, length - 1) + 1) * length;
    return count;
}

int main() {
    long long N;
    cin >> N;
    cout << countDigits(N) << endl;
    return 0;
}
