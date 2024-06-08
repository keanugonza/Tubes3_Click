DROP TABLE IF EXISTS `biodata`;
CREATE TABLE `biodata` (
  `NIK` varchar(16) NOT NULL,
  `nama` varchar(100),
  `tempat_lahir` varchar(50),
  `tanggal_lahir` date,
  `jenis_kelamin` varchar(20),
  `golongan_darah` varchar(5),
  `alamat` varchar(255),
  `agama` varchar(50),
  `status_perkawinan` varchar(20),
  `pekerjaan` varchar(100),
  `kewarganegaraan` varchar(50),
  PRIMARY KEY (`NIK`)
);

INSERT INTO `biodata` VALUES
('0123456789012345','Sari Melinda','Makassar','1997-10-10','Perempuan','A','Jl. Pettarani No.10','Kristen','Menikah','Chef','Indonesia'),
('0123456789012346','Dwi Cahyo','Jakarta','1985-01-01','Laki-Laki','B','Jl. Merdeka No.1','Islam','Menikah','Manager','Indonesia'),
('1123456789012347','Agus Tri','Bandung','1984-02-02','Laki-Laki','AB','Jl. Merpati No.2','Islam','Belum Menikah','Analyst','Indonesia'),
('1234567890123456','Ramadhan Budi','Jakarta','1990-01-01','Laki-Laki','O','Jl. Sudirman No.1','Islam','Belum Menikah','Programmer','Indonesia'),
('2123456789012348','Siti Rahma','Surabaya','1983-03-03','Perempuan','O','Jl. Mawar No.3','Kristen','Menikah','Doctor','Indonesia'),
('2345678901234567','Rina Yulianti','Bandung','1989-02-02','Perempuan','A','Jl. Gatot Subroto No.2','Kristen','Menikah','Designer','Indonesia'),
('9123456789012355','Indra Wijaya','Makassar','1976-10-10','Laki-Laki','B','Jl. Jeruk No.10','Kristen','Menikah','Programmer','Indonesia');

DROP TABLE IF EXISTS `sidik_jari`;
CREATE TABLE `sidik_jari` (
  `berkas_citra` text,
  `nama` varchar(100)
);

INSERT INTO `sidik_jari` VALUES
('test/gambar (1).BMP','Dwi cahyo'),
('test/gambar (2).BMP','R4mAdH4n budI'),
('test/gambar (3).BMP','inDr4 wij4Y4'),
('test/gambar (4).BMP','Rud1 h4rt0n0'),
('test/gambar (5).BMP','t1n4 m3L4ti'),
('test/gambar (6).BMP','S1t1 R4Hma'),
('test/gambar (7).BMP','t1n4 m3L4ti'),
('test/gambar (8).BMP','r1an pr4tama'),
('test/gambar (9).BMP','t1n4 m3L4ti'),
('test/gambar (10).BMP','yul1 4ND1n1');
