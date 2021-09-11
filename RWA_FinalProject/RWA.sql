USE [AdventureWorksOBP]
GO
/****** Object:  StoredProcedure [dbo].[CreateProizvod]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CreateProizvod]
@naziv nvarchar(50),
@brojProizvoda nvarchar(25),
@boja nvarchar(15),
@minKolNaSkladistu smallint,
@cijenaBezPDV money,
@podkategorijaID int
as
begin
	insert into Proizvod(Naziv,BrojProizvoda,Boja,MinimalnaKolicinaNaSkladistu,CijenaBezPDV,PotkategorijaID)
	values (@naziv,@brojProizvoda,@boja, @minKolNaSkladistu,@cijenaBezPDV,@podkategorijaID)
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteKategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[DeleteKategorija]
@id int
as
begin
delete from Kategorija where IDKategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePodkategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[DeletePodkategorija]
@id int
as
begin
delete from Potkategorija where IDPotkategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteProizvod]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteProizvod]
@id int
as
begin
delete from Proizvod where IDProizvod = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetDrzave]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Drzava
Create proc [dbo].[GetDrzave]
as
select * from Drzava
GO
/****** Object:  StoredProcedure [dbo].[GetGradovi]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Gradovi
Create proc [dbo].[GetGradovi]
as
select * from Grad
GO
/****** Object:  StoredProcedure [dbo].[GetKartica]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Kartica
create proc [dbo].[GetKartica]
@IDKartica int
as
begin
select * from KreditnaKartica
where IDKreditnaKartica = @IDKartica
end
GO
/****** Object:  StoredProcedure [dbo].[GetKategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetKategorija]
@id int
as
begin
select * from Kategorija where IDKategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetKategorije]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Kategorija
create proc [dbo].[GetKategorije]
as
begin
select * from Kategorija
end
GO
/****** Object:  StoredProcedure [dbo].[GetKomercijalist]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[GetKomercijalist]
@id int
as
select * from Komercijalist
where IDKomercijalist = @id
GO
/****** Object:  StoredProcedure [dbo].[GetKomercijalisti]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Komercijalist
Create proc [dbo].[GetKomercijalisti]
as
select * from Komercijalist
GO
/****** Object:  StoredProcedure [dbo].[GetKupac]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Kupac

create proc [dbo].[GetKupac]
@id int
as
begin
select * from Kupac
where Kupac.IDKupac = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetKupci]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetKupci]
as
begin
select * from Kupac
end
GO
/****** Object:  StoredProcedure [dbo].[GetPodkategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetPodkategorija]
@id int
as
begin
select * from Potkategorija where IDPotkategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetPotkategorije]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Podkategorija
create proc [dbo].[GetPotkategorije]
as
begin
select * from Potkategorija
end
GO
/****** Object:  StoredProcedure [dbo].[GetProizvod]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetProizvod]
@id int
as
begin
select * from Proizvod where IDProizvod = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetProizvodi]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Proizvod
CREATE proc [dbo].[GetProizvodi]
as
begin
select 
Proizvod.*,
Potkategorija.Naziv as 'PotkategorijaNaziv'
from Proizvod
inner join Potkategorija on Potkategorija.IDPotkategorija = Proizvod.PotkategorijaID
end
GO
/****** Object:  StoredProcedure [dbo].[GetRacun]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetRacun]
@id int
as
begin
select * from Racun
where IDRacun = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetRacuniForKupac]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Racun

create proc [dbo].[GetRacuniForKupac]
@KupacID int	
as
begin
select * from Racun where KupacID = @KupacID
end
GO
/****** Object:  StoredProcedure [dbo].[GetStavkeForRacun]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Stavka

CREATE proc [dbo].[GetStavkeForRacun]
@RacunID int
as
begin
select 
Stavka.*,
Proizvod.*
from Stavka
inner join Proizvod on Stavka.ProizvodID = Proizvod.IDProizvod
where RacunID = @RacunID
end
GO
/****** Object:  StoredProcedure [dbo].[InsertKategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertKategorija]
@Naziv nvarchar(50)
as
begin
insert into Kategorija (Naziv)
values (@Naziv)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertPodkategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertPodkategorija]
@Naziv nvarchar(50)
as
begin
insert into Potkategorija (Naziv)
values (@Naziv)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateKategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateKategorija]
@id int,
@Naziv nvarchar(50)
as
begin
update Kategorija
set Naziv = @Naziv
where IDKategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateKupac]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateKupac]
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
GO
/****** Object:  StoredProcedure [dbo].[UpdatePodkategorija]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdatePodkategorija]
@id int,
@Naziv nvarchar(50)
as
begin
update Potkategorija
set Naziv = @Naziv
where IDPotkategorija = @id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateProizvod]    Script Date: 12.9.2021. 0:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateProizvod]
@idProizvod int,
@naziv nvarchar(50),
@brojProizvoda nvarchar(25),
@boja nvarchar(15),
@minKolNaSkladistu smallint,
@cijenaBezPDV money,
@podkategorijaID int
as
begin
	update Proizvod
	set Naziv = @naziv, BrojProizvoda = @brojProizvoda, Boja = @boja, MinimalnaKolicinaNaSkladistu = @minKolNaSkladistu, CijenaBezPDV = @cijenaBezPDV, PotkategorijaID = @podkategorijaID
	where IDProizvod = @idProizvod
end
GO
