-- Bảng LOGIN
create database QuanLyPhongTro02
<<<<<<< HEAD

use QuanLyPhongTro02

=======
use QuanLyPhongTro02
>>>>>>> origin/master
CREATE TABLE LOGIN (
    UserName NVARCHAR(50) PRIMARY KEY NOT NULL,
    PassWords NVARCHAR(50) NOT NULL
);




<<<<<<< HEAD
=======



>>>>>>> origin/master
create table LoaiPhong(
     id int identity primary key not null,
	 TenLoaiPhong nvarchar(50) not null,
	 SoLuongNguoiO int not null,
	 DonGia int not null,
	 CoSoVatChat nvarchar(50)
)
alter table LoaiPhong 
add DienTich nvarchar(10)
delete from LoaiPhong
select *from LoaiPhong
insert into LoaiPhong values('Phong Don',1,1500000,'1 ghe 1 ban 1 giuong','15m2')
insert into LoaiPhong values('Phong Doi',2,2000000,'1 ghe 1 ban 1 giuong','20m2')


-- Bảng PHONG
CREATE TABLE PHONG (
    IDPhong INT IDENTITY PRIMARY KEY NOT NULL,
	
    TenLoaiPhong NVARCHAR(50) NOT NULL,
    GiaPhong int NOT NULL,
    HienTrang NVARCHAR(50) NOT NULL
<<<<<<< HEAD
);

=======
	
);
>>>>>>> origin/master
alter table Phong 
add IdLoaiPhong int not null FOREIGN KEY (IdLoaiPhong) REFERENCES LoaiPhong(id)
alter table Phong 
drop column GiaPhong


-- Bảng DICHVU
CREATE TABLE DICHVU (
    IDDichVu INT IDENTITY PRIMARY KEY NOT NULL,
    TenDichVu NVARCHAR(50) NOT NULL,
    DonGia DECIMAL(10,2) NOT NULL CHECK (DonGia >= 0)
);

<<<<<<< HEAD
=======
-- Bảng HOPDONG
CREATE TABLE HOPDONG (
    IDHopDong INT IDENTITY PRIMARY KEY NOT NULL,
    IDPhong INT NOT NULL,
    IDKhach INT NOT NULL,
  
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    FOREIGN KEY (IDPhong) REFERENCES PHONG(IDPhong),
    FOREIGN KEY (IDKhach) REFERENCES KHACHTHUEPHONG(IDKhach)
);
alter table KHACHTHUEPHONG
DROP column IDPhong,IDKhach,HoVaTen,QueQuan,CMMND

>>>>>>> origin/master

-- Bảng KHACHTHUEPHONG
CREATE TABLE KHACHTHUEPHONG (
    IDKhach INT IDENTITY PRIMARY KEY NOT NULL,
    IDPhong INT NOT NULL,
    
    HoVaTen NVARCHAR(50) NOT NULL,
	 NgaySinh DATE NOT NULL,
    QueQuan NVARCHAR(50) NOT NULL,
    CMND NVARCHAR(50) NOT NULL,
    
    FOREIGN KEY (IDPhong) REFERENCES PHONG(IDPhong),
<<<<<<< HEAD
);

alter table KHACHTHUEPHONG 
add GioiTinh nvarchar(10)

-- Bảng HOPDONG
CREATE TABLE HOPDONG (
    IDHopDong INT IDENTITY PRIMARY KEY NOT NULL,
    IDPhong INT NOT NULL,
    IDKhach INT NOT NULL,
 
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    FOREIGN KEY (IDPhong) REFERENCES PHONG(IDPhong),
    FOREIGN KEY (IDKhach) REFERENCES KHACHTHUEPHONG(IDKhach)
);

alter table KHACHTHUEPHONG
DROP column IDPhong,IDKhach,HoVaTen,QueQuan,CMMND

=======
   
);
alter table KHACHTHUEPHONG 
add GioiTinh nvarchar(10)

>>>>>>> origin/master
-- Bảng PHONGSUDUNGDICHVU
CREATE TABLE PHONGSUDUNGDICHVU (
    IDPhong INT NOT NULL,
    IDDichVu INT NOT NULL,
    DonGia int NOT NULL CHECK (DonGia >= 0),
    PRIMARY KEY (IDPhong, IDDichVu),
    FOREIGN KEY (IDPhong) REFERENCES PHONG(IDPhong),
    FOREIGN KEY (IDDichVu) REFERENCES DICHVU(IDDichVu)
);

-- Bảng HOADON
CREATE TABLE HOADON (
    IDHoaDon INT IDENTITY PRIMARY KEY NOT NULL,
    IDPhong INT NOT NULL,
    TienNha DECIMAL(10,2) NOT NULL,
    TienDichVu DECIMAL(10,2) NOT NULL,
    TienDien DECIMAL(10,2) NOT NULL,
    TienNuoc DECIMAL(10,2) NOT NULL,
    TongCong DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDPhong) REFERENCES PHONG(IDPhong)
);
<<<<<<< HEAD

select * from LOGIN
insert into LOGIN values('truong','123123')
insert into LOGIN values('van','123')

select * from KHACHTHUEPHONG

select * from LoaiPhong where TenLoaiPhong  = 'Phong Don'

select * from PHONG
insert into PHONG values('100',N'Không hoạt động','2')
insert into PHONG values('101',N'Không hoạt động','3')
insert into PHONG values('102',N'Không hoạt động','3')


=======
select * from LOGIN
insert into LOGIN values('truong','123123')
select * from KHACHTHUEPHONG
select * from LoaiPhong where TenLoaiPhong  = 'Phong Don'
select * from PHONG
insert into PHONG values('100',N'Không hoạt động','2')
select * from KHACHTHUEPHONG
insert into PHONG values('101',N'Không hoạt động','3')
insert into PHONG values('102',N'Không hoạt động','3')
>>>>>>> origin/master
update PHONG
set HienTrang  = N'Còn trống'
where TenLoaiPhong = '100' and  TenLoaiPhong = '101';
