--Kupac

create proc GetKupac
@id int
as
begin
select * from Kupac
where Kupac.IDKupac = @id
end
go

create proc GetKupci
as
begin
select * from Kupac
end
go

create proc UpdateKupac
@id int,
@ime nvarchar(50),
@prezime nvarchar(50),
@email nvarchar(50),
@telefon nvarchar(25),
@GradID int
as
begin
UPDATE Kupac
SET 
	Ime = @ime,
	Prezime = @prezime,
	Email = @email,
	Telefon = @telefon,
	@GradID = @GradID 
WHERE Kupac.IDKupac = @id;
end
go

--Drzava
Create proc GetDrzave
as
select * from Drzava
go

--Gradovi
Create proc GetGradovi
as
select * from Grad
go

--Komercijalist
Create proc GetKomercijalisti
as
select * from Komercijalist
go

Create proc GetKomercijalist
@id int
as
select * from Komercijalist
where IDKomercijalist = @id
go

--Racun

create proc GetRacuniForKupac
@KupacID int	
as
begin
select * from Racun where KupacID = @KupacID
end
go

--Stavka

create proc GetStavkeForRacun
@RacunID int
as
begin
select * from Stavka
where RacunID = @RacunID
end
go

--Kartica
create proc GetKartica
@IDKartica int
as
begin
select * from KreditnaKartica
where IDKreditnaKartica = @IDKartica
end
go

--Proizvod
create proc GetProizvodi
as
begin
select * from Proizvod
end
go

create proc GetProizvod
@id int
as
begin
select * from Proizvod where IDProizvod = @id
end
go



create proc DeleteProizvod
@id int
as
begin
delete from Proizvod where IDProizvod = @id
end
go

--Podkategorija
create proc GetPodkategorije
as
begin
select * from Podkategorija
end
go

create proc GetPodkategorija
@id int
as
begin
select * from Podkategorija where IDPodkategorija = @id
end
go

create proc InsertPodkategorija
@Naziv nvarchar(50)
as
begin
insert into Podkategorija (Naziv)
values (@Naziv)
end
go

create proc UpdatePodkategorija
@id int,
@Naziv nvarchar(50)
as
begin
update Podkategorija
set
	IDPodkategorija = @id,
	Naziv = @Naziv
end
go


create proc DeletePodkategorija
@id int
as
begin
delete from Podkategorija where Podkategorija = @id
end
go

--Kategorija
create proc GetKategorija
as
begin
select * from Kategorija
end
go

create proc InsertKategorija
@Naziv nvarchar(50)
as
begin
insert into Kategorija (Naziv)
values (@Naziv)
end
go

create proc GetKategorija
@id int
as
begin
select * from Kategorija where IDKategorija = @id
end
go

create proc UpdateKategorija
@id int,
@Naziv nvarchar(50)
as
begin
update Kategorija
set
	IDKategorija = @id,
	Naziv = @Naziv
end
go


create proc DeleteKategorija
@id int
as
begin
delete from Kategorija where Kategorija = @id
end
go