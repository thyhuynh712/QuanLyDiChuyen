-- Viết các store procedure cho data base quản lý di chuyển
use QUANLYDICHUYEN
go

-- Tài khoản
-- check tài khoản và mật khẩu có thuộc database hay không
-- nếu có và là admin thì trả về 0 , nếu có và là canbo thì trả về 1 , nếu có là nguoidan trả về 2, sai mật khẩu thì trả về 3 và không tồn tại trả về 4
CREATE PROC spCheckLogin 
@MaND char(12),
@MatKhau varchar(40)
as
begin
	if exists (select * from NGUOIDUNG where MAND = @MaND and MatKhau = @MatKhau and MaNhom = 1)
        select 0 as code
    else if exists (select * from NGUOIDUNG where MAND = @MaND and MatKhau = @MatKhau and MaNhom = 2)
        select 1 as code
	else if exists (select * from NGUOIDUNG where MAND = @MaND and MatKhau = @MatKhau and MaNhom = 3)
        select 2 as code
    else if exists(select * from NGUOIDUNG where MAND = @MaND and MatKhau != @MatKhau) 
        select 3 as code
    else select 4 as code
end
go

-- Thay đổi thông tin tài khoản cho người dùng (chỉ đổi được tên đăng nhâp hoặc mật khẩu)
CREATE PROC spChangeAccountByUser
@MaND char(12),
@MatKhauMoi varchar(40)
as
begin
	UPDATE NGUOIDUNG
	SET MatKhau = @MatKhauMoi
	WHERE MAND = @MaND
end
go

-- Thay đổi thông tin tài khoản cho admin (mật khẩu + loại tài khoản)
CREATE PROC spUpdateAccount
@MaND char(12),
@MatKhau varchar(40),
@MaNhom int
as
begin
	UPDATE NGUOIDUNG 
	SET MatKhau = @MatKhau , MaNhom = @MaNhom
	WHERE MAND = @MaND
end
GO
-- Thêm một tài khoản mới (admin)
CREATE PROC spAddNewAccount
@MaND char(12),
@MatKhau varchar(40),
@MaNhom int
as 
begin
	insert into NGUOIDUNG(MAND, MatKhau , MaNhom) values(@MaND, @MatKhau, @MaNhom);
end
GO
-- Xóa một tài khỏa (admin)
CREATE PROC spDeleteAccount
@MaND char(12)
as 
begin
	DELETE FROM NGUOIDUNG
	WHERE MAND = @MaND;
end
GO
-- Lấy ra danh sách tất cả các tài khoản hiện tại có trong hệ thống 
CREATE PROC spGetAllAccount
as
begin
	SELECT nd.MAND as N'Mã người dân' , nd.MatKhau N'Mật Khẩu', nnd.TenNhom N'Loại Tài Khoản'
	FROM NGUOIDUNG nd, NHOMNGUOIDUNG nnd
	WHERE nd.MaNhom = nnd.MaNhom
end
go

-- Kiểm tra tên đăng nhập đã tồn tại trong hệ thống hay chưa
CREATE PROC spCheckUserName
@MaND char(12)
as
begin
	if exists (select * from NGUOIDUNG where MAND = @MaND)
		select 1 as code
	if exists (select * from NGUOIDUNG where MAND = @MaND)
		select 2 as code	
	if exists (select * from NGUOIDUNG where MAND = @MaND)
		select 3 as code	
	else select 0 as code
end
go

-- Viết sp cho bảng tham số :
-- Thay đổi giá trị của tham số 

-- Thêm mới một tham số 

