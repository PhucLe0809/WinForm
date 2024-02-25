CREATE TABLE HocSinh (
 FullName varchar(100),
 Hometown varchar(255),
 ID varchar(100),
 Birthday dateTime,
);

INSERT INTO HocSinh (FullName, Hometown, ID, Birthday)
VALUES ('LE HONG PHUC', 'DONG THAP', '001', '01/01/2004');
INSERT INTO HocSinh (FullName, Hometown, ID, Birthday)
VALUES ('BUI KHAC DUY', 'KIEN GIANG', '002', '01/01/2004');
INSERT INTO HocSinh (FullName, Hometown, ID, Birthday)
VALUES ('TRINH NHAT HUY', 'NHA TRANG', '003', '01/01/2004');
INSERT INTO HocSinh (FullName, Hometown, ID, Birthday)
VALUES ('TRANG KIM LOI', 'BAC LIEU', '004', '01/01/2004');
INSERT INTO HocSinh (FullName, Hometown, ID, Birthday)
VALUES ('PHAM KHANH HUY', 'BINH PHUOC', '005', '01/01/2004');

SELECT *FROM HocSinh

CREATE TABLE GiaoVien (
 FullName varchar(100),
 Hometown varchar(255),
 ID varchar(100),
 Birthday dateTime,
);

INSERT INTO GiaoVien (FullName, Hometown, ID, Birthday)
VALUES ('NGUYEN VAN MAI', 'DONG THAP', '101', '01/01/1970');
INSERT INTO GiaoVien(FullName, Hometown, ID, Birthday)
VALUES ('LE LAM LUC', 'KIEN GIANG', '102', '01/01/1970');
INSERT INTO GiaoVien (FullName, Hometown, ID, Birthday)
VALUES ('TRUONG CONG TOAN', 'NHA TRANG', '103', '01/01/1970');
INSERT INTO GiaoVien (FullName, Hometown, ID, Birthday)
VALUES ('BUI THANH LIEM', 'BAC LIEU', '104', '01/01/1970');
INSERT INTO GiaoVien (FullName, Hometown, ID, Birthday)
VALUES ('PHAM TRUONG AN', 'BINH PHUOC', '105', '01/01/1970');

SELECT *FROM GiaoVien