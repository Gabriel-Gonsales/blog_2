CREATE TABLE `comments` (
  `id` BIGINT(19) AUTO_INCREMENT PRIMARY KEY,
  `content` longtext NOT NULL,
  `post_date` datetime(6) NOT NULL,
  `posts_id` BIGINT(19) NOT NULL,
  CONSTRAINT `fk_person_id` FOREIGN KEY (`posts_id`)
  REFERENCES `person`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
