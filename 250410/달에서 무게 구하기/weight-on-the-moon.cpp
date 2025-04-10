#include <iostream>
using namespace std;

int main() {
    int weight = 13;
    double g = 0.165;

    cout << fixed;
    cout.precision(6);
    cout << weight << " * " << g << " = " << weight*g;
    return 0;
}