CREATE TABLE `posts` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `descricao` longtext,
  `titulo` longtext,
  `imagem` longtext,
  `enabled` BIT(1) NOT NULL DEFAULT b'1',
  `arq` longblob
) ENGINE=InnoDB DEFAULT CHARSET=latin1;