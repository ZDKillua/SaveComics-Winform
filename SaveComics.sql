Use master
Create database SaveComics
Go

Use SaveComics
Go

Create table LoaiTruyen(
	maLoai int identity(1,1) not null primary key,
	tenLoai nvarchar(100) not null
)

Create table Truyen(
	maTruyen int identity(1,1) primary key,
	tenTruyen nvarchar(100) not null,
	chap int,
	maLoai int,
	ngayDocCuoi datetime,
	img image,
	hot bit,
	blackList bit,
	noiDung nvarchar(200),
	Constraint FK_MaLoai Foreign Key(maLoai) References LoaiTruyen(maLoai)
)

Insert LoaiTruyen Values
('Manhwa'),
('Manhua'),
('Manga')