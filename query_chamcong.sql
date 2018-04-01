USE dbChamCong
GO

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [MaNVFT]
      ,[HoTen]
      ,[GioiTinh] 
      ,[NgaySinh]
      ,[DienThoai]
      ,[DiaChi]
      ,[GhiChu]
  FROM [dbChamCong].[dbo].[tbChamCong_NhanVien_Fulltime]

------update profile------
 IF OBJECT_ID('uspUpdateProfile', 'P') is not null
	DROP PROC uspUpdateProfile
GO
CREATE PROCEDURE uspUpdateProfile
 @user int
,@hoten nvarchar(50)
,@gioitinh nvarchar(50) 
,@ngaysinh datetime 
,@dienthoai char(11)
,@diachi nvarchar(50)

AS
UPDATE tbChamCong_NhanVien_Fulltime
SET  Hoten = @hoten
	,GioiTinh = @gioitinh
	,NgaySinh = @ngaysinh
	,DienThoai = @dienthoai
	,DiaChi = @diachi
WHERE MaNVFT = @user

GO
EXEC uspUpdateProfile 2, N'Trần Minh', N'Nam','12/3/2018','0144848', N'gò vấp'

select cast(NgaySinh as date) as NgaySinh from tbChamCong_NhanVien_Fulltime

--------tim kiem nhan vien --------------
IF OBJECT_ID('uspSearchNhanVien', 'P') is not null
	DROP PROC uspSearchNhanVien
CREATE PROCEDURE uspSearchNhanVien
AS
BEGIN
select 
nv.MaNVFT
,nv.HoTen
,nv.GioiTinh
,nv.NgaySinh
,nv.DienThoai
,nv.DiaChi
,cv.TenChucVu
,pb.TenPhongBan
from tbChamCong_NhanVien_Fulltime_ChiTiet nvct
inner join tbChamCong_NhanVien_Fulltime nv on nv.MaNVFT = nvct.MaNVFT
inner join tbChamCong_ChucVu cv on cv.MaCV = nvct.MaCV
inner join tbChamCong_PhongBan pb on pb.MaPB = nvct.MaPB  

where 
	HoTen like '%%'
	or GioiTinh like '%%'
	or NgaySinh like '%%'
	or TenChucVu like '%%'
	or TenPhongBan like '%%'

END
GO
EXEC uspSearchNhanVien
	-------------
select * from tbChamCong_NhanVien_Fulltime_ChiTiet
	
