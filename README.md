> Tugas Besar 3 IF2211 Strategi Algoritma
> Semester II tahun 2023/2024

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Setup](#setup)
* [Usage](#usage)
* [Jobdesk](#jobdesk)


## General Information

Di dalam Tugas Besar 3 ini, kami diminta untuk mengimplementasikan sistem yang dapat melakukan identifikasi individu berbasis biometrik dengan menggunakan sidik jari. Metode yang akan digunakan untuk melakukan deteksi sidik jari adalah Boyer-Moore dan Knuth-Morris-Pratt. Selain itu, sistem ini akan dihubungkan dengan identitas sebuah individu melalui basis data sehingga harapannya terbentuk sebuah sistem yang dapat mengenali identitas seseorang secara lengkap hanya dengan menggunakan sidik jari

## Technologies Used
- WindowsFormApps
- .NET
- NuGet
- Sql
- C#



## Features
List the ready features here:
- Search

## Setup

1. Pastikan Git terinstall pada sistem

2. Pastikan juga Visual Studio versi terbaru dan MariaDB Server terinstall pada sistem

3. Clone repository ini lalu buka dengan Visual Studio

4. Buat database test dalam my sql dengan command
`mysql -u {username} -p`

5. Lalu Masukan password my sql 

6. Buat Database pada mysql
`create database t`

6. Keluar dari Mysql lalu jalankan command berikut
`mysql -u {username} -p t < {namafile sql}`

7. Lalu ubah password pada code di file DatabaseOperations. Ada di connectionstring


## Usage

Jalankan dengan 
`ctrl + f5`


## Jobdesk

<table>
    <tr>
      <td><b>NIM</b></td>
      <td><b>Nama</b></td>
      <td><b>Pembagian Pekerjaan</b></td>
    </tr>
    <tr>
      <td>13522026</td>
      <td>Rici Trisna Putra</td>
      <td>GUI</td>
    </tr>
    <tr>
      <td>13522082</td>
      <td>Keanu Amadius Gonza Wrahatno</td>
      <td>Database</td>
    </tr>
    <tr>
      <td>13522112</td>
      <td>Dimas Bagoes Hendrianto</td>
      <td>Algoritma</td>
    </tr>
</table>
