-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-11-2020 a las 01:36:42
-- Versión del servidor: 10.4.13-MariaDB
-- Versión de PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `parcialplataformas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `claves`
--

CREATE TABLE `claves` (
  `id_clave` int(11) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `estado` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `claves`
--

INSERT INTO `claves` (`id_clave`, `clave`, `estado`) VALUES
(1, '4FSJ-V2PL-3KZQ-8JRX-JMCA', 'usada'),
(2, 'WVNN-X1X7-UEHY-8WSK-XR2J', 'usada'),
(3, '1K7Ñ-69ET-1AKM-DHUB-JRPL', 'usada'),
(4, 'B2BO-WR7B-U3UU-LDT9-OY4S', 'nueva'),
(5, 'BH02-J2ÑG-TZ1Q-RZQL-DL10', 'nueva'),
(6, '7T2K-54W4-CQWV-TPD4-666F', 'nueva'),
(7, 'Y5XJ-MGPU-YA9E-VYHQ-ÑP6O', 'nueva'),
(8, 'FTEC-CG6C-VWÑG-OWCB-5T8Z', 'nueva'),
(9, 'W38Z-ZSI8-BI41-WWRR-T6NT', 'nueva'),
(10, '6BKP-I41Q-QHCD-EYFY-0BRJ', 'nueva'),
(11, 'H5OR-4ÑTH-19BQ-J27U-SRR5', 'nueva'),
(12, '00R3-G1W8-Q30S-ÑDNA-W2U3', 'nueva'),
(13, 'LTZR-GV3M-0UGI-SWSP-ÑUMC', 'nueva'),
(14, '1VZ8-ISCG-O67Z-7XTG-B9WU', 'nueva'),
(15, '7KH6-WS90-T6WB-QRBZ-40KX', 'nueva'),
(16, 'SX74-WPL5-DMOÑ-70FQ-O2LY', 'nueva'),
(17, 'TMVS-K6JO-V4MK-Z9BJ-NNKH', 'nueva'),
(18, 'IEXI-QJDZ-NULB-OUDG-CÑTZ', 'nueva'),
(19, 'G5JJ-AFX8-Y5EB-SEPP-YNBA', 'nueva'),
(20, '2SBB-TL4E-55G8-2TAM-4ÑIM', 'nueva'),
(21, 'UFAQ-QJRL-EXRY-NT7W-4HZY', 'nueva'),
(22, 'KTC3-YFJ8-EEUK-FYPW-SUUK', 'nueva'),
(23, '2T9H-NQVJ-WNRX-YSCB-DG1L', 'nueva'),
(24, 'ATHA-DHTX-EKEK-VO60-T4PH', 'nueva'),
(25, 'SAL0-W6UW-WÑTM-2JKI-N9EG', 'nueva'),
(26, '77EM-JHBK-WLRI-ZT19-IPÑG', 'nueva'),
(27, 'W7BZ-Z1RN-FXÑT-0KKV-59RO', 'nueva'),
(28, '5L9L-6MVI-QKA6-V7SA-6OVQ', 'nueva'),
(29, 'ZYE8-77RP-KGEJ-88LL-7Z3Ñ', 'nueva'),
(30, 'GJ54-XQ83-0JZQ-NBYH-GBN8', 'nueva'),
(31, '4G7L-G08W-WIDG-UILQ-2KLQ', 'nueva'),
(32, '8XYA-QW67-KDE6-M5T9-LUX6', 'nueva'),
(33, 'SMHS-GS5F-ZIÑ6-Z69G-R74S', 'nueva'),
(34, '4AMS-EH3Z-XLFI-VO7V-QG47', 'nueva'),
(35, '11HC-YIGP-5ÑRÑ-0FCR-AXO9', 'nueva'),
(36, 'YGQO-CGKL-8ÑYM-C61D-3K35', 'nueva'),
(37, 'AÑ3J-30RQ-NPV3-14IU-K19S', 'nueva'),
(38, '75QR-ZGM3-N8XZ-4S8K-MHUM', 'nueva'),
(39, 'Y27S-15UH-YH2C-KL7F-7MTX', 'nueva'),
(40, 'OXEÑ-158I-67IC-HX3F-77Z4', 'nueva'),
(41, 'VEFG-GVPT-U3N9-X77A-YT15', 'nueva'),
(42, '6ML0-8Z4W-Q2H9-WZCL-S7HF', 'nueva'),
(43, 'POXC-UIOJ-02QN-G37J-2ÑHP', 'nueva'),
(44, '02C1-VÑN8-4VR0-MVPR-XIG0', 'nueva'),
(45, 'LV6Y-L422-12RE-01OW-M5QG', 'nueva'),
(46, '4PÑE-L0AU-ÑPVU-IQEF-6ÑQ1', 'nueva'),
(47, 'UUHC-EN9U-H2F2-1954-H2ÑU', 'nueva'),
(48, '3HÑL-H76J-WJ08-OYUK-JMA7', 'nueva'),
(49, '0PÑV-L22I-VJ8E-A58N-G55G', 'nueva'),
(50, 'P077-CHNC-ÑVV4-2P4Ñ-32AÑ', 'nueva'),
(51, 'EXXÑ-LW8T-0IDÑ-Q3R9-RPTD', 'nueva'),
(52, 'P04A-XDMU-ATTÑ-4QB2-CTWO', 'nueva'),
(53, 'J3LG-RHÑ8-845N-J68Ñ-3XZH', 'nueva'),
(54, 'LNSH-XYS9-1Y77-3E4V-OXRP', 'nueva'),
(55, 'YNWG-XGE8-RX8O-3OE5-LER3', 'nueva'),
(56, 'YÑHJ-78TF-BN9F-GJR7-0MSQ', 'nueva'),
(57, 'TURE-ZREÑ-99KK-FX1L-GNIZ', 'nueva'),
(58, 'W96F-Y3JT-7GE8-VBJD-6DSO', 'nueva'),
(59, 'NYNX-V6CQ-2EI3-84XP-NCHL', 'nueva'),
(60, 'E1WV-41ÑI-MO70-OI4Y-JL9U', 'nueva'),
(61, 'AHVQ-ÑRVR-QBSE-Z7JP-XK4H', 'nueva'),
(62, '3US2-B3KY-APQJ-I92M-IBG2', 'nueva'),
(63, 'L6L9-EJ27-N6MZ-9ETT-N8AC', 'nueva'),
(64, 'SB12-3EÑX-N9HU-CVTB-3103', 'nueva'),
(65, 'M6NÑ-05WD-G9PL-EPUO-IMEK', 'nueva'),
(70, 'TUDB-ZSYP-3FÑU-4WZ8-694Y', 'nueva'),
(71, 'QAS6-STWN-T3ZF-U800-QQX1', 'nueva'),
(72, 'H1GQ-XBTR-WYT4-691R-BYMK', 'nueva'),
(73, 'TIZ5-HTHC-6TGG-G6PZ-4BIR', 'nueva'),
(74, '9FZ4-J5JV-GIZ2-FÑH9-BLJD', 'nueva'),
(75, '4RUD-RNX9-SCX9-P3KÑ-R5WM', 'nueva'),
(76, 'LU5X-3ÑB1-YQYS-1FXR-TWN5', 'nueva'),
(77, 'HJCE-UZNL-D3QG-X72J-V6JD', 'nueva'),
(78, 'M5LC-ÑEIL-G135-R0EB-R0DE', 'nueva'),
(79, 'B0Y5-AR44-MÑ6X-NJTL-8A0P', 'nueva'),
(80, 'RCFL-9UX7-2015-3FCV-HOC5', 'nueva'),
(81, 'YBVH-UI23-6XKN-FY6U-6PDU', 'nueva'),
(82, 'RCCV-SFC9-L2Y6-Ñ8N0-MYM1', 'nueva'),
(83, 'GJ04-66H1-ÑM55-4XCW-99XP', 'nueva'),
(84, 'F3SD-8Ñ9H-LFIH-DMÑI-LHZW', 'nueva'),
(85, '7LV9-62C0-500M-B6VM-0W5S', 'nueva'),
(86, '7API-DY1S-J4L1-JBR4-ITGF', 'nueva'),
(87, 'MILU-Ñ6GH-ZCRX-MHZ6-5N5I', 'nueva'),
(88, 'BSQB-O9C9-Ñ0EG-PZHY-Z43H', 'nueva'),
(89, 'SU2H-MWOC-MV94-X8E2-1JGO', 'nueva'),
(90, '3G38-7LIW-AAHA-TYZP-0KZ1', 'nueva'),
(91, 'TAX2-1KSR-UÑ6P-XONM-13KA', 'nueva'),
(92, 'O2BL-O8K8-JXBQ-TÑ52-SBHW', 'nueva'),
(93, '2ZBV-D0MF-MNY6-AYN0-8NÑ2', 'nueva'),
(94, '9UJ6-NP6K-SU30-VWIY-0PHX', 'nueva'),
(95, 'WFW5-8EQ4-BE4G-XOXI-QFJX', 'nueva'),
(96, '4CV0-S8LÑ-QXAR-FZG4-7N7I', 'nueva'),
(97, '8BJO-ZXDH-89IV-HS3T-S5MA', 'nueva'),
(98, '3DNN-EMA7-I2KD-HAZ2-3GB5', 'nueva'),
(99, '5DOR-PÑLW-6VLC-B7O4-Y5LÑ', 'nueva'),
(100, 'XF9G-ZFOH-2A0M-4QE0-Y57Z', 'nueva'),
(101, 'ANBV-RIBJ-V4E7-5WI0-DJ2K', 'nueva'),
(102, '9E35-58HU-2XG2-8VNK-ENXQ', 'nueva'),
(103, 'DFU8-63QH-JÑWP-DWZ6-TF0T', 'nueva'),
(104, 'AQP7-XL8K-J7V0-ULH3-S58B', 'nueva'),
(105, 'QAMO-A0ZL-5Q08-VEQV-ZWKV', 'nueva');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'gian', 'gian0304'),
(4, 'ejemploConKey', 'ejemplo123'),
(5, 'christian', 'asdasdasd');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `claves`
--
ALTER TABLE `claves`
  ADD PRIMARY KEY (`id_clave`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `claves`
--
ALTER TABLE `claves`
  MODIFY `id_clave` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=106;

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
