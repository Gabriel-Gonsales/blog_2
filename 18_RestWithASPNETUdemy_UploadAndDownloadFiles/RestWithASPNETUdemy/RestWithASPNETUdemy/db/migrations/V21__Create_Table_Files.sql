CREATE TABLE `files` (
  `arq` longblob NOT NULL,
  `posts_id` INT(10) NOT NULL,
  CONSTRAINT `fk_Fpost_id` FOREIGN KEY (`posts_id`)
  REFERENCES `posts`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
