CREATE DATABASE QLBanHang
GO
USE QLBanHang
GO

-- tạo bảng loại mặt hàng
CREATE TABLE LoaiMatHang
(
 MaLoai INT IDENTITY(1,1) PRIMARY KEY,
 TenLoai NVARCHAR(100) NOT NULL UNIQUE
--IDENTITY(1,1) tự khởi tạo mã loại mặt hàng không trùng,
--khi thêm mới mặt hàng k phải(được) thêm mã mặt hàng 
--vd INSERT INTO LoaiMatHang VALUES (N'Không thêm mã mặt hàng')
-- NOT NULL= giá trị này k được để trống
--UNIQUE giá trị này không thể trùng 
)
GO
--thêm dữ liệu cho bảng
INSERT INTO LoaiMatHang VALUES (N'Đồ gốm')
INSERT INTO LoaiMatHang VALUES (N'Đồ gia dụng')
INSERT INTO LoaiMatHang VALUES (N'Đồ vệ sinh cá nhân')
SELECT * FROM LoaiMatHang
---------------------------------------------------------------

-- tạo bảng mặt hàng
CREATE TABLE MatHang(
MaMatHang INT IDENTITY PRIMARY KEY,
TenLoaiMatHang NVARCHAR(500) NOT NULL UNIQUE,
LoaiMatHang INT REFERENCES LoaiMatHang(MaLoai),--khóa ngoại liên kết tới mã loại của loại mặt hàng 
SoLuongTon INT not null,
CONSTRAINT SoLuongTonKhongAm CHECK(SoLuongTon>=0),
-- hàm kiểm tra số lượng tồn lớn hơn 0 trước khi thêm mặt hàng vào bảng
DonGia INT not null,
CONSTRAINT DonGiaKhongAm CHECK(DonGia>=0),
)
GO

-- thủ tục thêm mặt hàng mới
CREATE PROC USP_ThemHang
@TenLoaiMatHang NVARCHAR(500),
@LoaiMatHang INT,
@SoLuongTon INT,
@DonGia INT
AS
BEGIN
	INSERT INTO MatHang VALUES (@TenLoaiMatHang,@LoaiMatHang,@SoLuongTon,@DonGia)
END
--thêm mặt hàng bằn thủ tục
EXEC USP_ThemHang N'Bình đựng trà',1,40,50000
EXEC USP_ThemHang N'Chậu cây',1,10,25000
EXEC USP_ThemHang N'Chén hoa',1,105,20000
EXEC USP_ThemHang N'Chổi lông gà',2,5,10000
EXEC USP_ThemHang N'Khăn lau bàn',2,70,5000
EXEC USP_ThemHang N'Nước rửa chén',2,16,28000
EXEC USP_ThemHang N'Khăn mặt',3,61,15000
EXEC USP_ThemHang N'Dao cạo râu',3,30,8000
EXEC USP_ThemHang N'Kem đánh răng',3,20,38000
select * from MatHang
-------------------------------------------------------------------------------
--thủ tục sửa hàng
CREATE PROC USP_SuaHang
@MaMatHang int,
@TenLoaiMatHang NVARCHAR(500),
@LoaiMatHang INT,
@SoLuongTon INT,
@DonGia INT
AS
BEGIN
	UPDATE MatHang SET TenLoaiMatHang=@TenLoaiMatHang,
						LoaiMatHang=@LoaiMatHang,
						SoLuongTon=@SoLuongTon,
						DonGia=@DonGia
	WHERE MaMatHang=@MaMatHang
END
GO
---------------------------------------------------------
EXEC USP_SuaHang 9,N'Kem đánh răng',3,10,40000
select * from MatHang
-----------------------------------------------------

--LƯU Ý KHI LƯU FILE PHẢI LƯU CHUẨN UTF8(SAVE->SAVE WITH ENCODING->ENCODING:UNICODE UTF8
--------------------------------------------------------