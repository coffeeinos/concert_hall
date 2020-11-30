-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Ноя 30 2020 г., 12:49
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `concert hall`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `login` varchar(50) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone_number` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `question` text NOT NULL,
  `answer` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `admin`
--

INSERT INTO `admin` (`id`, `login`, `full_name`, `phone_number`, `email`, `pass`, `question`, `answer`) VALUES
(2, 'login', 'full_name', 'phone_number', 'email', 'pass', 'question', 'answer'),
(3, 'test1', 'test1', 'test1', 'test1', 'test1', 'test1', 'test1'),
(4, 'test2', 'test2', 'test2', 'test2', 'test2', 'test2', 'test2');

-- --------------------------------------------------------

--
-- Структура таблицы `advertising_campaign`
--

CREATE TABLE `advertising_campaign` (
  `id` int(11) NOT NULL,
  `id_performance` int(11) NOT NULL,
  `id_marketing_firm` int(11) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `advertising_campaign`
--

INSERT INTO `advertising_campaign` (`id`, `id_performance`, `id_marketing_firm`, `cost`) VALUES
(2, 3, 3, 400);

-- --------------------------------------------------------

--
-- Структура таблицы `advertising_campaign_archive`
--

CREATE TABLE `advertising_campaign_archive` (
  `id_performance` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `advertising_campaign_archive`
--

INSERT INTO `advertising_campaign_archive` (`id_performance`, `name`, `phone_number`, `cost`) VALUES
(1, 'Navitdoj', '3809979999', 400);

-- --------------------------------------------------------

--
-- Структура таблицы `guest_artist`
--

CREATE TABLE `guest_artist` (
  `id` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `guest_artist`
--

INSERT INTO `guest_artist` (`id`, `full_name`, `phone_number`) VALUES
(1, 'Соловьёв Пантелеймон Антонинович', '3806333333'),
(2, 'Рожков Илья Игоревич', '3806333332'),
(3, 'Шестаков Лавр Федосеевич', '3806333331'),
(4, 'Егоров Ефрем Миронович', '3806333330'),
(5, 'Тетерин Гурий Проклович', '3806333334'),
(6, 'test', 'test');

--
-- Триггеры `guest_artist`
--
DELIMITER $$
CREATE TRIGGER `add_archive_guest_artist` BEFORE DELETE ON `guest_artist` FOR EACH ROW BEGIN
INSERT INTO guest_artist_archive SET
full_name = OLD.full_name,
phone_number = OLD.phone_number;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `guest_artist_archive`
--

CREATE TABLE `guest_artist_archive` (
  `full_name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `hall`
--

CREATE TABLE `hall` (
  `id` int(11) NOT NULL,
  `hall_number` int(11) NOT NULL,
  `number_seats` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `hall`
--

INSERT INTO `hall` (`id`, `hall_number`, `number_seats`) VALUES
(1, 14, 500),
(2, 324, 400),
(3, 32, 300),
(4, 421, 200),
(5, 234, 100);

-- --------------------------------------------------------

--
-- Структура таблицы `marketing_firm`
--

CREATE TABLE `marketing_firm` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `marketing_firm`
--

INSERT INTO `marketing_firm` (`id`, `name`, `phone_number`, `address`, `email`) VALUES
(1, 'Rokline', '3809999999', '1-й Ключевой переулок', 'ippiffagomm-1495@yopmail.com'),
(2, 'Yahpu', '3809999998', '1-й Александра Невского переулок', 'lejexannak-9415@yopmail.com'),
(3, 'Navitdoj', '3809979999', '1-й Амундсена переулок', 'effigyruz-7610@yopmail.com'),
(4, 'Hsens', '3809999969', '1-й Амурский переулок', 'uffammawyllu-9043@yopmail.com'),
(5, 'Puressice', '3809599999', '1-й Аркадийский переулок', 'oddessawe-0743@yopmail.com');

--
-- Триггеры `marketing_firm`
--
DELIMITER $$
CREATE TRIGGER `delet_marketing_firm` BEFORE DELETE ON `marketing_firm` FOR EACH ROW BEGIN
INSERT INTO marketing_firm_archive SET
name = OLD.name,
phone_number = OLD.phone_number,
address = OLD.address,
email = OLD.email;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `marketing_firm_archive`
--

CREATE TABLE `marketing_firm_archive` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `performance`
--

CREATE TABLE `performance` (
  `id` int(11) NOT NULL,
  `id_hall` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `genre` varchar(20) NOT NULL,
  `day` date NOT NULL,
  `start_of_performance` time NOT NULL,
  `end_of_performance` time NOT NULL,
  `summary` text NOT NULL,
  `age_limit` int(11) NOT NULL,
  `use_of_phonogram` tinyint(1) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance`
--

INSERT INTO `performance` (`id`, `id_hall`, `name`, `genre`, `day`, `start_of_performance`, `end_of_performance`, `summary`, `age_limit`, `use_of_phonogram`, `cost`) VALUES
(3, 1, 'La Traviat', 'Опера', '2020-11-10', '20:00:00', '23:00:00', 'По роману', 15, 0, 300),
(6, 2, 'test1', 'test1', '2020-05-01', '18:00:00', '20:00:00', 'test1', 14, 1, 123),
(7, 3, 'test2', 'test2', '2021-05-02', '17:00:00', '21:00:00', 'test2', 12, 1, 1233),
(8, 4, 'test3', 'test3', '2022-05-03', '16:00:00', '22:00:00', 'test3', 16, 1, 122),
(9, 2, 'test12', 'test12', '2020-05-01', '18:00:00', '20:00:00', 'test1', 14, 1, 123);

--
-- Триггеры `performance`
--
DELIMITER $$
CREATE TRIGGER `archive_performance` BEFORE DELETE ON `performance` FOR EACH ROW BEGIN


INSERT INTO performance_archive SET
id_hall = OLD.id_hall,
name = OLD.name,
genre = OLD.genre,
day = OLD.day,
age_limit = OLD.age_limit,
use_of_phonogram = OLD.use_of_phonogram,
cost = OLD.cost;


INSERT INTO performance_theater_worker_archive (id_performance, full_name, phone_number, cost)
SELECT performance_archive.id, theater_worker.full_name,theater_worker.phone_number, performance_theater_worker.cost
FROM performance_theater_worker
INNER JOIN performance_archive ON (SELECT id FROM performance_archive WHERE name = (SELECT name FROM performance WHERE id = OLD.id)) = performance_archive.id
INNER JOIN theater_worker ON performance_theater_worker.id_theater_worker = theater_worker.id;

DELETE FROM performance_theater_worker WHERE id_performance = OLD.id;


INSERT INTO performance_guest_artist_archive (id_performance, full_name, phone_number, cost)
SELECT performance_archive.id, guest_artist.full_name, guest_artist.phone_number, performance_guest_artist.cost
FROM performance_guest_artist
INNER JOIN performance_archive ON (SELECT id FROM performance_archive WHERE name = (SELECT name FROM performance WHERE id = OLD.id)) = performance_archive.id
INNER JOIN guest_artist ON performance_guest_artist.id_guest_artist = guest_artist.id;



DELETE FROM performance_guest_artist WHERE id_performance = OLD.id;

INSERT INTO ticket_archive (id_performance, id_place, buyer_full_name, cost)
SELECT performance_archive.id, ticket.id_place, ticket.buyer_full_name, ticket.cost
FROM ticket
INNER JOIN performance_archive ON (SELECT id FROM performance_archive WHERE name = (SELECT name FROM performance WHERE id = OLD.id)) = performance_archive.id;


DELETE FROM ticket WHERE id_performance = OLD.id;


INSERT INTO advertising_campaign_archive (id_performance, name, phone_number, cost)
SELECT performance_archive.id, marketing_firm.name, marketing_firm.phone_number, advertising_campaign.cost
FROM advertising_campaign
INNER JOIN performance_archive ON (SELECT id FROM performance_archive WHERE name = (SELECT name FROM performance WHERE id = OLD.id)) = performance_archive.id
INNER JOIN marketing_firm ON advertising_campaign.id_marketing_firm = marketing_firm.id;

DELETE FROM advertising_campaign WHERE id_performance = OLD.id;



END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `performance_archive`
--

CREATE TABLE `performance_archive` (
  `id` int(11) NOT NULL,
  `id_hall` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `genre` varchar(20) NOT NULL,
  `day` date NOT NULL,
  `age_limit` int(11) NOT NULL,
  `use_of_phonogram` int(11) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance_archive`
--

INSERT INTO `performance_archive` (`id`, `id_hall`, `name`, `genre`, `day`, `age_limit`, `use_of_phonogram`, `cost`) VALUES
(1, 2, 'test1', 'test1', '2020-05-01', 0, 1, 123);

--
-- Триггеры `performance_archive`
--
DELIMITER $$
CREATE TRIGGER `performance_archive_clear` BEFORE DELETE ON `performance_archive` FOR EACH ROW BEGIN
DELETE FROM `performance_guest_artist_archive`;
DELETE FROM `performance_theater_worker_archive`;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `performance_guest_artist`
--

CREATE TABLE `performance_guest_artist` (
  `id_performance` int(11) NOT NULL,
  `id_guest_artist` int(11) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance_guest_artist`
--

INSERT INTO `performance_guest_artist` (`id_performance`, `id_guest_artist`, `cost`) VALUES
(3, 1, 200),
(3, 2, 200),
(3, 3, 200),
(3, 4, 200),
(3, 5, 200),
(3, 6, 6);

-- --------------------------------------------------------

--
-- Структура таблицы `performance_guest_artist_archive`
--

CREATE TABLE `performance_guest_artist_archive` (
  `id_performance` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance_guest_artist_archive`
--

INSERT INTO `performance_guest_artist_archive` (`id_performance`, `full_name`, `phone_number`, `cost`) VALUES
(1, 'Соловьёв Пантелеймон Антонинович', '3806333333', 200),
(1, 'Рожков Илья Игоревич', '3806333332', 200),
(1, 'Шестаков Лавр Федосеевич', '3806333331', 200),
(1, 'Егоров Ефрем Миронович', '3806333330', 200),
(1, 'Тетерин Гурий Проклович', '3806333334', 200),
(1, 'test', 'test', 6);

-- --------------------------------------------------------

--
-- Структура таблицы `performance_theater_worker`
--

CREATE TABLE `performance_theater_worker` (
  `id_performance` int(11) NOT NULL,
  `id_theater_worker` int(11) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance_theater_worker`
--

INSERT INTO `performance_theater_worker` (`id_performance`, `id_theater_worker`, `cost`) VALUES
(3, 1, 150),
(3, 2, 150),
(3, 3, 150),
(3, 4, 150),
(3, 5, 150),
(3, 6, 152.5);

-- --------------------------------------------------------

--
-- Структура таблицы `performance_theater_worker_archive`
--

CREATE TABLE `performance_theater_worker_archive` (
  `id_performance` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone_number` varchar(25) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance_theater_worker_archive`
--

INSERT INTO `performance_theater_worker_archive` (`id_performance`, `full_name`, `phone_number`, `cost`) VALUES
(1, 'Лихачёв Гордий Робертович', '3806555555', 150),
(1, 'Фадеев Федор Денисович', '3806555554', 150),
(1, 'Кулагин Борис Глебович', '3806555553', 150),
(1, 'Иванков Панкратий Митрофанович', '3806555552', 150),
(1, 'Шубин Адриан Даниилович', '3806555551', 150),
(1, 'test', 'test', 152.5);

-- --------------------------------------------------------

--
-- Структура таблицы `place`
--

CREATE TABLE `place` (
  `id` int(11) NOT NULL,
  `id_row` int(11) NOT NULL,
  `cost` float NOT NULL,
  `number` int(11) NOT NULL,
  `the_condition` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `place`
--

INSERT INTO `place` (`id`, `id_row`, `cost`, `number`, `the_condition`) VALUES
(1, 1, 100, 1, 0),
(2, 1, 100, 2, 0),
(3, 1, 110, 3, 0),
(4, 1, 120, 4, 0),
(5, 4, 130, 1, 0),
(6, 5, 140, 1, 0),
(7, 6, 150, 1, 0),
(8, 7, 160, 1, 0),
(9, 8, 170, 1, 0),
(10, 9, 180, 1, 0),
(11, 10, 190, 1, 1),
(12, 11, 200, 1, 0),
(13, 12, 210, 1, 1),
(14, 13, 220, 1, 1),
(15, 14, 230, 1, 1),
(16, 15, 240, 1, 1),
(17, 16, 250, 1, 0),
(18, 17, 260, 1, 1),
(19, 18, 270, 1, 1),
(20, 19, 280, 1, 1),
(21, 20, 290, 1, 1),
(22, 21, 300, 1, 0),
(23, 22, 310, 1, 1),
(24, 23, 320, 1, 1),
(25, 24, 330, 1, 1),
(26, 25, 340, 1, 1),
(27, 1, 200, 5, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `row`
--

CREATE TABLE `row` (
  `id` int(11) NOT NULL,
  `id_sector` int(11) NOT NULL,
  `number` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `row`
--

INSERT INTO `row` (`id`, `id_sector`, `number`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 1, 3),
(4, 1, 4),
(5, 1, 5),
(6, 2, 1),
(7, 2, 2),
(8, 2, 3),
(9, 2, 4),
(10, 2, 5),
(11, 3, 1),
(12, 3, 2),
(13, 3, 3),
(14, 3, 4),
(15, 3, 5),
(16, 4, 1),
(17, 4, 2),
(18, 4, 3),
(19, 4, 4),
(20, 4, 5),
(21, 5, 1),
(22, 5, 2),
(23, 5, 3),
(24, 5, 4),
(25, 5, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `sector`
--

CREATE TABLE `sector` (
  `id` int(11) NOT NULL,
  `id_hall` int(11) NOT NULL,
  `name` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sector`
--

INSERT INTO `sector` (`id`, `id_hall`, `name`) VALUES
(1, 1, 'Балкон'),
(2, 1, 'Амфитеатр'),
(3, 1, 'Ложа 1 яруса'),
(4, 1, 'Ложа 2 яруса'),
(5, 1, 'Партер'),
(6, 2, 'Балкон'),
(7, 2, 'Амфитеатр'),
(8, 2, 'Ложа 1 яруса'),
(9, 2, 'Ложа 2 яруса'),
(10, 2, 'Партер'),
(11, 3, 'Балкон'),
(12, 3, 'Амфитеатр'),
(13, 3, 'Ложа 1 яруса'),
(14, 3, 'Ложа 2 яруса'),
(15, 3, 'Партер'),
(16, 4, 'Балкон'),
(17, 4, 'Амфитеатр'),
(18, 4, 'Ложа 1 яруса'),
(19, 4, 'Ложа 2 яруса'),
(20, 4, 'Партер'),
(21, 5, 'Балкон'),
(22, 5, 'Амфитеатр'),
(23, 5, 'Ложа 1 яруса'),
(24, 5, 'Ложа 2 яруса'),
(25, 5, 'Партер');

-- --------------------------------------------------------

--
-- Структура таблицы `theater_worker`
--

CREATE TABLE `theater_worker` (
  `id` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `position` varchar(25) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `address` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `theater_worker`
--

INSERT INTO `theater_worker` (`id`, `full_name`, `position`, `phone_number`, `address`) VALUES
(1, 'Лихачёв Гордий Робертович', 'Сопрано', '3806555555', '10-го Апреля улица'),
(2, 'Фадеев Федор Денисович', 'Дирежер', '3806555554', '2-й Амундсена переулок'),
(3, 'Кулагин Борис Глебович', 'Сопрано', '3806555553', '2-й Липинский переулок'),
(4, 'Иванков Панкратий Митрофанович', 'Басы', '3806555552', '2-й Пролетарский переулок'),
(5, 'Шубин Адриан Даниилович', 'Баритон', '3806555551', '2-я Вертолётная улица'),
(6, 'test', 'test', 'test', 'test');

--
-- Триггеры `theater_worker`
--
DELIMITER $$
CREATE TRIGGER `add_archive_theater_worker` BEFORE DELETE ON `theater_worker` FOR EACH ROW BEGIN
INSERT INTO theater_worker_archive SET
full_name = OLD.full_name,
position = OLD.position,
phone_number = OLD.phone_number,
address = OLD.address;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `theater_worker_archive`
--

CREATE TABLE `theater_worker_archive` (
  `full_name` varchar(50) NOT NULL,
  `position` varchar(25) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `address` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `id_performance` int(11) NOT NULL,
  `id_place` int(11) NOT NULL,
  `buyer_full_name` varchar(50) NOT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ticket`
--

INSERT INTO `ticket` (`id`, `id_performance`, `id_place`, `buyer_full_name`, `cost`) VALUES
(11, 3, 2, 'test2', 400),
(12, 3, 3, 'test3', 410),
(13, 3, 4, 'test4', 420),
(14, 3, 27, 'test5', 500),
(15, 6, 7, 'test1', 12313),
(16, 7, 4, 'test2', 1123),
(17, 8, 5, 'test3', 2444),
(18, 9, 6, 'test12', 244),
(19, 3, 1, 'Ярош Егор Олегович', 400),
(20, 3, 8, 'Иван Иванов Иванович', 460),
(21, 3, 9, 'Василий Кузнецов', 470),
(22, 3, 12, 'Кирилл Кульянов', 500),
(23, 3, 17, 'Мифодий и Кирилл', 550),
(24, 3, 22, 'Владимир Мудрый', 600),
(25, 3, 10, 'Ярош Егор Олегович', 480);

--
-- Триггеры `ticket`
--
DELIMITER $$
CREATE TRIGGER `check_place` AFTER INSERT ON `ticket` FOR EACH ROW BEGIN 
UPDATE place SET
the_condition = false WHERE id = NEW.id_place;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `clear_place` AFTER DELETE ON `ticket` FOR EACH ROW BEGIN 
UPDATE `place` SET the_condition = 1 WHERE id = OLD.id_place;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `ticket_archive`
--

CREATE TABLE `ticket_archive` (
  `id` int(11) NOT NULL,
  `id_performance` int(11) NOT NULL,
  `id_place` int(11) NOT NULL,
  `buyer_full_name` varchar(50) DEFAULT NULL,
  `cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ticket_archive`
--

INSERT INTO `ticket_archive` (`id`, `id_performance`, `id_place`, `buyer_full_name`, `cost`) VALUES
(1, 1, 1, 'test', 400),
(2, 1, 2, 'test2', 400),
(3, 1, 3, 'test3', 410),
(4, 1, 4, 'test4', 420),
(5, 1, 27, 'test5', 500);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `advertising_campaign`
--
ALTER TABLE `advertising_campaign`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_performance` (`id_performance`),
  ADD KEY `id_marketing_firm` (`id_marketing_firm`);

--
-- Индексы таблицы `advertising_campaign_archive`
--
ALTER TABLE `advertising_campaign_archive`
  ADD KEY `id_performance` (`id_performance`);

--
-- Индексы таблицы `guest_artist`
--
ALTER TABLE `guest_artist`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `hall`
--
ALTER TABLE `hall`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `marketing_firm`
--
ALTER TABLE `marketing_firm`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `marketing_firm_archive`
--
ALTER TABLE `marketing_firm_archive`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `performance`
--
ALTER TABLE `performance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_hall` (`id_hall`);

--
-- Индексы таблицы `performance_archive`
--
ALTER TABLE `performance_archive`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_hall` (`id_hall`);

--
-- Индексы таблицы `performance_guest_artist`
--
ALTER TABLE `performance_guest_artist`
  ADD KEY `id_performance` (`id_performance`),
  ADD KEY `id_guest_artist` (`id_guest_artist`);

--
-- Индексы таблицы `performance_guest_artist_archive`
--
ALTER TABLE `performance_guest_artist_archive`
  ADD KEY `id_performance` (`id_performance`);

--
-- Индексы таблицы `performance_theater_worker`
--
ALTER TABLE `performance_theater_worker`
  ADD KEY `id_performance` (`id_performance`),
  ADD KEY `id_theater_worker` (`id_theater_worker`);

--
-- Индексы таблицы `performance_theater_worker_archive`
--
ALTER TABLE `performance_theater_worker_archive`
  ADD KEY `id_performance` (`id_performance`);

--
-- Индексы таблицы `place`
--
ALTER TABLE `place`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_row` (`id_row`);

--
-- Индексы таблицы `row`
--
ALTER TABLE `row`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_sector` (`id_sector`);

--
-- Индексы таблицы `sector`
--
ALTER TABLE `sector`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_hall` (`id_hall`);

--
-- Индексы таблицы `theater_worker`
--
ALTER TABLE `theater_worker`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_performance` (`id_performance`),
  ADD KEY `id_place` (`id_place`);

--
-- Индексы таблицы `ticket_archive`
--
ALTER TABLE `ticket_archive`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_performance` (`id_performance`),
  ADD KEY `id_place` (`id_place`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `advertising_campaign`
--
ALTER TABLE `advertising_campaign`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `guest_artist`
--
ALTER TABLE `guest_artist`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `hall`
--
ALTER TABLE `hall`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `marketing_firm`
--
ALTER TABLE `marketing_firm`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `marketing_firm_archive`
--
ALTER TABLE `marketing_firm_archive`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `performance`
--
ALTER TABLE `performance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `performance_archive`
--
ALTER TABLE `performance_archive`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `place`
--
ALTER TABLE `place`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT для таблицы `row`
--
ALTER TABLE `row`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `sector`
--
ALTER TABLE `sector`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `theater_worker`
--
ALTER TABLE `theater_worker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `ticket_archive`
--
ALTER TABLE `ticket_archive`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `advertising_campaign`
--
ALTER TABLE `advertising_campaign`
  ADD CONSTRAINT `advertising_campaign_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance` (`id`),
  ADD CONSTRAINT `advertising_campaign_ibfk_2` FOREIGN KEY (`id_marketing_firm`) REFERENCES `marketing_firm` (`id`);

--
-- Ограничения внешнего ключа таблицы `advertising_campaign_archive`
--
ALTER TABLE `advertising_campaign_archive`
  ADD CONSTRAINT `advertising_campaign_archive_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance_archive` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance`
--
ALTER TABLE `performance`
  ADD CONSTRAINT `performance_ibfk_1` FOREIGN KEY (`id_hall`) REFERENCES `hall` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance_archive`
--
ALTER TABLE `performance_archive`
  ADD CONSTRAINT `performance_archive_ibfk_1` FOREIGN KEY (`id_hall`) REFERENCES `hall` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance_guest_artist`
--
ALTER TABLE `performance_guest_artist`
  ADD CONSTRAINT `performance_guest_artist_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance` (`id`),
  ADD CONSTRAINT `performance_guest_artist_ibfk_2` FOREIGN KEY (`id_guest_artist`) REFERENCES `guest_artist` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance_guest_artist_archive`
--
ALTER TABLE `performance_guest_artist_archive`
  ADD CONSTRAINT `performance_guest_artist_archive_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance_archive` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance_theater_worker`
--
ALTER TABLE `performance_theater_worker`
  ADD CONSTRAINT `performance_theater_worker_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance` (`id`),
  ADD CONSTRAINT `performance_theater_worker_ibfk_2` FOREIGN KEY (`id_theater_worker`) REFERENCES `theater_worker` (`id`);

--
-- Ограничения внешнего ключа таблицы `performance_theater_worker_archive`
--
ALTER TABLE `performance_theater_worker_archive`
  ADD CONSTRAINT `performance_theater_worker_archive_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance_archive` (`id`);

--
-- Ограничения внешнего ключа таблицы `place`
--
ALTER TABLE `place`
  ADD CONSTRAINT `place_ibfk_1` FOREIGN KEY (`id_row`) REFERENCES `row` (`id`);

--
-- Ограничения внешнего ключа таблицы `row`
--
ALTER TABLE `row`
  ADD CONSTRAINT `row_ibfk_1` FOREIGN KEY (`id_sector`) REFERENCES `sector` (`id`);

--
-- Ограничения внешнего ключа таблицы `sector`
--
ALTER TABLE `sector`
  ADD CONSTRAINT `sector_ibfk_1` FOREIGN KEY (`id_hall`) REFERENCES `hall` (`id`);

--
-- Ограничения внешнего ключа таблицы `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance` (`id`),
  ADD CONSTRAINT `ticket_ibfk_2` FOREIGN KEY (`id_place`) REFERENCES `place` (`id`);

--
-- Ограничения внешнего ключа таблицы `ticket_archive`
--
ALTER TABLE `ticket_archive`
  ADD CONSTRAINT `ticket_archive_ibfk_1` FOREIGN KEY (`id_performance`) REFERENCES `performance_archive` (`id`),
  ADD CONSTRAINT `ticket_archive_ibfk_2` FOREIGN KEY (`id_place`) REFERENCES `place` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
