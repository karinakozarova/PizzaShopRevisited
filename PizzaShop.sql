CREATE TABLE `Pizza` (
  `id` int PRIMARY KEY,
  `name` varchar(100),
  `filled_price` int(11),
  `thickness_price` int(11)
);

CREATE TABLE `Drink` (
  `id` int PRIMARY KEY,
  `name` varchar(100),
  `price` int(11)
);

CREATE TABLE `OrderedPizza` (
  `order_id` int,
  `pizza_id` int,
  `quantity` int(11),
  `is_thick` boolean,
  `is_filled` boolean
);

CREATE TABLE `OrderedDrink` (
  `order_id` int,
  `drink_id` int,
  `quantity` int(11),
  `price` int(11)
);

CREATE TABLE `Order` (
  `id` int PRIMARY KEY,
  `customer_id` int,
  `created_at` datetime,
  `is_active` bool
);

CREATE TABLE `Customer` (
  `id` int PRIMARY KEY,
  `name` varchar(300),
  `email` varchar(300)
);

ALTER TABLE `Order` ADD FOREIGN KEY (`id`) REFERENCES `OrderedPizza` (`order_id`);

ALTER TABLE `Pizza` ADD FOREIGN KEY (`id`) REFERENCES `OrderedPizza` (`pizza_id`);

ALTER TABLE `Order` ADD FOREIGN KEY (`id`) REFERENCES `OrderedDrink` (`order_id`);

ALTER TABLE `Drink` ADD FOREIGN KEY (`id`) REFERENCES `OrderedDrink` (`drink_id`);

ALTER TABLE `Customer` ADD FOREIGN KEY (`id`) REFERENCES `Order` (`customer_id`);
