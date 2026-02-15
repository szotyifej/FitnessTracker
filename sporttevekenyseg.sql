-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Feb 14. 12:43
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `fitnesstracket`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `sporttevekenyseg`
--

CREATE TABLE `sporttevekenyseg` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Sportag` varchar(100) NOT NULL,
  `Datum` date NOT NULL,
  `IdotartamPerc` int(11) NOT NULL,
  `Helyszin` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `sporttevekenyseg`
--

INSERT INTO `sporttevekenyseg` (`Id`, `Sportag`, `Datum`, `IdotartamPerc`, `Helyszin`) VALUES
(0, '\r\nroplabda', '2026-02-14', 60, 'linkin Park');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `sporttevekenyseg`
--
ALTER TABLE `sporttevekenyseg`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
