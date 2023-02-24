ALTER TABLE `comments`
	ADD COLUMN `person_name` longtext NOT NULL AFTER `post_date`;