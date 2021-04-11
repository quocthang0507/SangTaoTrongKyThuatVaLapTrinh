# Số cấp nhân

*Tìm các số tự nhiên có ba chữ số. Ba chữ số này, theo trật tự từ trái qua phải tạo thành một cấp số nhân với công bội là một số tự nhiên khác 0.*

## Đặc tả

Chú ý rằng ta chỉ xét các cấp số trên dãy số tự nhiên với công bội d là một số nguyên dương. Gọi x là số cần tìm, ta có:

(1) x là số có ba chữ số: x = 100*a + 10*b + c

(2) a = 1..9; b = a*d; 0 < c = a*d*d <= 9

Hệ thức (2) cho phép tính giới hạn trên của d:

```c#
ad^2 <= 9
d <= sqrt(9/a)
```

Vì d là số nguyên nên ta phải có `d <= trunc(sqrt(9 div a))`, trong đó, `sqrt` là hàm tính căn bậc hai, `trunc` là hàm lấy phần nguyên.

Ta cho a biến thiên trong khoảng 1..9 rồi cộng cho bội d biến thiên trong khoảng từ `1..trunc(sqrt(9 div a))`. Với mỗi cặp số a và d ta tính:

```c#
x = 100*a + 10*a*d + a*d*d
= a*(100 + 10*d + d*d)
```

Tuy nhiên, ta có thể nhẩm tính trước cận trên của d thì sẽ đỡ phải gọi các hàm trunc và sqrt:

|a|1|2|3|4|5|6|7|8|9|
|-|-|-|-|-|-|-|-|-|-|
|Cận trên d|3|2|1|1|1|1|1|1|1|

## Kết quả

```
111 124 139 222 248 333 444 555 666 777 888 999
```
