-- MySQL Script generated by MySQL Workbench
-- Fri Jul 19 22:50:47 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema crudcore
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `crudcore` ;

-- -----------------------------------------------------
-- Schema crudcore
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `crudcore` DEFAULT CHARACTER SET utf8 ;
USE `crudcore` ;

-- -----------------------------------------------------
-- Table `crudcore`.`profile`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `crudcore`.`profile` ;

CREATE TABLE IF NOT EXISTS `crudcore`.`profile` (
  `idProfile` INT NOT NULL,
  `description` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idProfile`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crudcore`.`user`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `crudcore`.`user` ;

CREATE TABLE IF NOT EXISTS `crudcore`.`user` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `idProfile` INT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `password` VARCHAR(20) NOT NULL,
  `isActive` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idUser`),
  INDEX `idProfile_user_idx` (`idProfile` ASC),
  CONSTRAINT `idProfile_user`
    FOREIGN KEY (`idProfile`)
    REFERENCES `crudcore`.`profile` (`idProfile`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `crudcore`.`profile`
-- -----------------------------------------------------
START TRANSACTION;
USE `crudcore`;
INSERT INTO `crudcore`.`profile` (`idProfile`, `description`) VALUES (1, 'ADMIN');
INSERT INTO `crudcore`.`profile` (`idProfile`, `description`) VALUES (2, 'CLIENT');

COMMIT;
