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


--Proizvod
