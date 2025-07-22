-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 18, 2025 at 08:59 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atricle`
--

-- --------------------------------------------------------

--
-- Table structure for table `article`
--

CREATE TABLE `article` (
  `Id_article` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Prix` decimal(10,0) NOT NULL,
  `Id_categorie` int(11) DEFAULT NULL,
  `img` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `article`
--

INSERT INTO `article` (`Id_article`, `Nom`, `Prix`, `Id_categorie`, `img`) VALUES
(1, 'Clavier Bureau', 30000, 1, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20250918090914.jpg'),
(2, 'Tapis', 50000, 2, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20250918090948.jpg'),
(3, 'Souris', 20000, 1, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251018091059.jpg'),
(4, 'Statut Themis', 250000, 3, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251118091138.jpg'),
(5, 'Table simple', 15000, 2, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251218091223.jpg'),
(6, 'Lamp veilleus', 10000, 2, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251418091406.jpg'),
(7, 'Epee', 40000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251418091451.jpg'),
(8, 'Bat', 12000, 5, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251518091527.jpg'),
(9, 'Cahier laur..', 3000, 6, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251618091620.jpg'),
(10, 'Siege', 35000, 1, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251718091728.jpg'),
(11, 'Clavier RGB', 30000, 1, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251818091804.jpg'),
(12, 'Tapis de chambre', 2100, 2, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251818091831.jpg'),
(13, 'hache', 9000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20251918091918.jpg'),
(14, 'Bouclier', 80000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252018092005.jpg'),
(15, 'Katana', 90000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252018092045.jpg'),
(16, 'Kan pour les vieux', 6000, 7, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252118092121.jpg'),
(17, 'Katana avec foureau', 50000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252218092214.jpg'),
(18, 'Rhodia', 5000, 6, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252318092304.jpg'),
(19, 'Masse', 45000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252418092400.jpg'),
(20, 'Chien Muscler', 2, 8, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252418092425.jpg'),
(21, 'Lance', 56500, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252518092507.jpg'),
(22, 'Why are you gay', 0, 9, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252518092539.jpg'),
(23, 'Chateu du roi Demon', 9999999, 10, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252618092622.jpg'),
(24, 'Lunette', 9000, 11, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252718092742.jpg'),
(25, 'Jack Spareau', 766767676, 12, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252818092835.jpg'),
(26, 'Chien Muscler 2', 666666, 8, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252918092912.jpg'),
(27, '5000 Ar pour acheter tous', 600, 12, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20252918092948.jpeg'),
(28, 'Made IFT', 1, 12, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253118093109.jpg'),
(29, 'Lampe', 10000, 2, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253218093214.jpg'),
(30, 'Cart', 2000, 13, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253218093249.png'),
(31, 'Lance', 70000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253318093329.jpg'),
(32, 'Vieux souriant', 3, 9, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253318093359.jpg'),
(33, 'Katana courte', 40000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253418093435.jpg'),
(34, 'IFT', 45, 14, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253518093511.png'),
(35, 'Machette', 39000, 4, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253518093545.jpg'),
(36, 'Entrepris SMIA', 6, 15, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253718093751.jpg'),
(37, 'Service avocat', 30000, 16, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20253918093907.png'),
(38, 'Entrepris TIA Infos', 3, 15, 'C:\\Users\\Wiiii\\Documents\\Visual Studio 2022\\Atricle\\Atricle\\bin\\Debug\\net8.0-windows7.0\\\\images\\img_20254018094008.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `categorie`
--

CREATE TABLE `categorie` (
  `Id_categorie` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categorie`
--

INSERT INTO `categorie` (`Id_categorie`, `Nom`) VALUES
(1, 'Materielle informatique'),
(2, 'Meuble'),
(3, 'Art'),
(4, 'arme'),
(5, 'Sporte'),
(6, 'Cahier'),
(7, 'Autre'),
(8, 'Chien'),
(9, 'meme'),
(10, 'Chateau'),
(11, 'Accessoir'),
(12, 'Humain'),
(13, 'jouais'),
(14, 'ecole'),
(15, 'Entreprise'),
(16, 'Service');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `article`
--
ALTER TABLE `article`
  ADD PRIMARY KEY (`Id_article`),
  ADD KEY `Id_categorie` (`Id_categorie`);

--
-- Indexes for table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`Id_categorie`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `article`
--
ALTER TABLE `article`
  MODIFY `Id_article` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `Id_categorie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `article`
--
ALTER TABLE `article`
  ADD CONSTRAINT `article_ibfk_1` FOREIGN KEY (`Id_categorie`) REFERENCES `categorie` (`Id_categorie`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
