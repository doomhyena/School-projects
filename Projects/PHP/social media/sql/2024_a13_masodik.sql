-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 06. 16:18
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
-- Adatbázis: `2024_a13_masodik`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ertesitesek`
--

CREATE TABLE `ertesitesek` (
  `id` int(11) NOT NULL,
  `ertesitoid` int(11) NOT NULL,
  `ertesitettid` int(11) NOT NULL,
  `tipus` varchar(100) NOT NULL,
  `olvasott` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ertesitesek`
--

INSERT INTO `ertesitesek` (`id`, `ertesitoid`, `ertesitettid`, `tipus`, `olvasott`) VALUES
(20, 1, 2, 'kovetes', 'nem'),
(30, 1, 1, 'like', 'igen'),
(31, 1, 1, 'like', 'igen'),
(32, 1, 1, 'komment', 'igen'),
(33, 2, 1, 'kovetes', 'igen'),
(34, 1, 1, 'like', 'igen'),
(35, 2, 1, 'komment', 'igen');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kommentek`
--

CREATE TABLE `kommentek` (
  `id` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `postid` int(11) NOT NULL,
  `szoveg` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kommentek`
--

INSERT INTO `kommentek` (`id`, `userid`, `postid`, `szoveg`) VALUES
(1, 1, 5, 'Első komment'),
(2, 1, 5, 'Második komment'),
(4, 1, 13, 'negyedik'),
(5, 1, 16, 'asd'),
(6, 1, 16, 'második'),
(7, 1, 16, 'hali'),
(8, 2, 16, ':)');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kovetesek`
--

CREATE TABLE `kovetesek` (
  `id` int(11) NOT NULL,
  `koveto` int(11) NOT NULL,
  `kovetett` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kovetesek`
--

INSERT INTO `kovetesek` (`id`, `koveto`, `kovetett`) VALUES
(91, 1, 2),
(101, 2, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `likes`
--

CREATE TABLE `likes` (
  `id` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `postid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `likes`
--

INSERT INTO `likes` (`id`, `userid`, `postid`) VALUES
(59, 1, 5),
(65, 1, 16);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `posztok`
--

CREATE TABLE `posztok` (
  `id` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `szoveg` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `posztok`
--

INSERT INTO `posztok` (`id`, `userid`, `szoveg`) VALUES
(4, 2, 'hali'),
(5, 2, 'második :)'),
(13, 1, 'Balázs'),
(16, 1, 'szerkesztendő szöveg.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'Balázs', 'testpass'),
(2, 'TestUser', 'testpass'),
(4, 'asd', 'asd'),
(5, 'asdasd', 'asd');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ertesitesek`
--
ALTER TABLE `ertesitesek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kommentek`
--
ALTER TABLE `kommentek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kovetesek`
--
ALTER TABLE `kovetesek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `likes`
--
ALTER TABLE `likes`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `posztok`
--
ALTER TABLE `posztok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ertesitesek`
--
ALTER TABLE `ertesitesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT a táblához `kommentek`
--
ALTER TABLE `kommentek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `kovetesek`
--
ALTER TABLE `kovetesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT a táblához `likes`
--
ALTER TABLE `likes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT a táblához `posztok`
--
ALTER TABLE `posztok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
