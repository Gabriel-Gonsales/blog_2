CREATE TABLE `comments` (
  `id` BIGINT(19) AUTO_INCREMENT PRIMARY KEY,
  `content` longtext NOT NULL,
  `post_date` datetime(6) NOT NULL,
  `posts_id` INT(10) NOT NULL,
  CONSTRAINT `fk_post_id` FOREIGN KEY (`posts_id`)
  REFERENCES `posts`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
