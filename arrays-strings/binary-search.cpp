#include <bits/stdc++.h>
#include <array>

using namespace std;

int  binarySearch(int arr[], int target) {
    int lo = 0;
    int hi = sizeof(arr)/sizeof(arr[0]);

    while(lo < hi){
        int mid = lo + (hi - lo) / 2;
        if(arr[mid]==target)
            return mid;
        else if(arr[mid] < target)
            lo = mid+1;
        else
            hi = mid-1;
    }

    return -1;
}

int main() {
    int arr[] = { 2, 3, 4, 10, 40 };
    int result = binarySearch(arr, 10);

    cout << "Element is presente at index: " << result;
}


