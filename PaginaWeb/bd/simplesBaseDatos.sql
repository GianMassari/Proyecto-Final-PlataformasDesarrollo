-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema parcialPlataformas
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `parcialPlataformas` ;

-- -----------------------------------------------------
-- Schema parcialPlataformas
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `parcialPlataformas` DEFAULT CHARACTER SET utf8 ;
USE `parcialPlataformas` ;

-- -----------------------------------------------------
-- Table `parcialPlataformas`.`user`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `parcialPlataformas`.`user` ;

CREATE TABLE IF NOT EXISTS `parcialPlataformas`.`user` (
  `id_user` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_user`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `parcialPlataformas`.`key`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `parcialPlataformas`.`claves` ;

CREATE TABLE IF NOT EXISTS `parcialPlataformas`.`claves` (
  `id_clave` INT NOT NULL AUTO_INCREMENT,
  `clave` VARCHAR(45) NOT NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`id_clave`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;



