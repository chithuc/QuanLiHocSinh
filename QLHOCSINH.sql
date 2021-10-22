create database QLHOCSINH
go
use QLHOCSINH
go

create table Account(
	DisplayName nvarchar(50) not null,
	UserName nvarchar(50) primary key not null,	
	PassWord nvarchar(50) not null
	)
GO

create table LopHoc(
	MaLop nchar(20) not null primary key,
	TenLop nvarchar(50) not null,
	SiSo int not null,
	KhoaHoc nvarchar(50)
)
Go

create table HocSinh(
	MaHS nchar(20) not null primary key,
	TenHS nvarchar(50) not null,
	MaLop nchar(20) not null,
	NgaySinh date,
	GioiTinh bit,
	DiaChi nvarchar(50),
	SDT int,
	constraint fk1 foreign key(MaLop)
	 references LopHoc(MaLop)
)
GO

create table MonHoc(
	MaMH nchar(20) not null primary key,
	TenMH nvarchar(50) not null,
	MaHS nchar(20) not null,
	HocKy nvarchar(50),
	SoTiet int,
	constraint fk2 foreign key(MaHS)
	  references HocSinh(MaHS)
)
Go

Create table BangDiem(
	MaBD nchar(20) primary key,
	MaHS nchar(20) not null,
	MaMH nchar(20) not null,
	Diem float not null,
	XepLoai nvarchar(20),
	constraint fk3 foreign key(MaHS)
	  references HocSinh(MaHS),
    constraint fk4 foreign key(MaMH)
	  references MonHoc(MaMH)
)

insert into Account values(N'Phạm Thị Chí Thức',N'chithuc',N'thuc1411')
insert into Account values(N'Phạm Thị Thu Trang',N'thutrang',N'trang0302')
insert into Account values(N'Trần Văn Hùng',N'vanhung',N'hung1234')
insert into Account values(N'Nguyễn Thị Nhung',N'Admin',N'123')
select * from Account

insert into LopHoc values('L001',N'10A1',40,N'2020-2021')
insert into LopHoc values('L002',N'11A1',38,N'2020-2021')
insert into LopHoc values('L003',N'10A2',39,N'2020-2021')
select * from LopHoc

insert into HocSinh values('HS001',N'Phạm Thị Chí Thức','L001',Cast(N'2000-11-14' AS DATE),0,N'Hà Nội',0354867689)
insert into HocSinh values('HS002',N'Phạm Thị Thu Trang','L002',Cast(N'2000-02-10'AS DATE),0,N'Hà Nội',0369878799)
insert into HocSinh values('HS003',N'Trần Văn Hùng','L002',Cast(N'2000-07-15'AS DATE),1,N'Hà Nội',0354867593)
insert into HocSinh values('HS004',N'Nguyễn Vũ Chí Tình','L003',Cast(N'2000-03-06'AS DATE),1,N'Hà Nội',0354343567)
select * from HocSinh

insert into MonHoc values('MH001',N'Toán','HS001',N'học kỳ 2','40')
insert into MonHoc values('MH002',N'Văn Học','HS001',N'học kỳ 2','40')
insert into MonHoc values('MH003',N'Vật Lý','HS001',N'học kỳ 2','38')
select * from MonHoc

insert into BangDiem values('BD001','HS001','MH001',9,N'Giỏi')
insert into BangDiem values('BD002','HS002','MH002',7,N'Khá')
insert into BangDiem values('BD003','HS003','MH002',4,N'Kém')
insert into BangDiem values('BD004','HS003','MH003',8,N'Giỏi')
select * from BangDiem
