# Mảng ngẫu nhiên

*Sinh ngẫu nhiên n số nguyên không âm cho mảng nguyên a*

## Đặc tả

Trong Turbo Pascal, hàm `random(n)` sinh một số ngẫu nhiên kiểu nguyên nằm trong khoảng từ 0 đến n-1.

Trong C#, phương thức `Next(n)` của lớp `Random` hoạt động tương tự.

## Chú ý

(1) Trước khi gọi hàm `random` ta cần gọi thủ tục `randomize` để máy tính khởi động cơ chế phát sinh số ngẫu nhiên.

(2) Thủ tục `Gen(m)` trong chương trình dưới đây sinh số ngẫu nhiên m số nguyên trong khoảng từ 0 đến m-1. Ta có thể cải tiến để viết thủ tục Gen(n, d, c) để sinh ngẫu nhiên n số nguyên dương trong khoảng từ d đến c (d < c).

Để ý rằng `random(c-d+1)` biến thiên trong khoảng từ 0 đến c-d, do đó `d + random(c-d+1)` sẽ biến thiên trong khoảng từ d đến `d+c-d = c`

## Kết quả

```

```
