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
------------------------
create view vwProfile 

select MaNVFT,HoTen,NgaySinh,DienThoai,DiaChi ,iif(GioiTinh =0,REPLACE(GioiTinh,0,N'Nam'),(REPLACE(GioiTinh,1,'Nu'))) as GioiTinh
	  from tbChamCong_NhanVien_Fulltime	


	  ---------------------------
	  select iif(@gender =0,(REPLACE(cast(@gender as nvarchar(100)),0,N'Nam')), 
(REPLACE(cast(@gender as nvarchar(100)),1,N'Nữ')))
end	

select MaNVFT,HoTen,NgaySinh,DienThoai,DiaChi ,iif(GioiTinh =0,REPLACE(GioiTinh,0,N'Nam'),(REPLACE(GioiTinh,1,'Nu'))) as GioiTinh
	  from tbChamCong_NhanVien_Fulltime
--- insert profile ---------------------
IF OBJECT_ID(' uspInsertProfile', 'P') is not null
	DROP PROC  uspInsertProfile
CREATE PROCEDURE uspInsertProfile
 --@user int
@hoten nvarchar(50)
,@gioitinh nvarchar(50) 
,@ngaysinh datetime 
,@dienthoai char(11)
,@diachi nvarchar(50)
as
insert into tbChamCong_NhanVien_Fulltime
(HoTen, GioiTinh, NgaySinh, DienThoai, DiaChi)
values (@hoten, @gioitinh, @ngaysinh, @dienthoai, @diachi)

-------------proc dang ky-----------
IF OBJECT_ID('uspDangNhap', 'P') is not null
	DROP PROC  uspDangNhap
CREATE PROCEDURE uspDangNhap
@UserName int,
@Password varchar(50)
as
insert into tbChamCong_DangNhap(UserName, Password)
values (@UserName, @Password)