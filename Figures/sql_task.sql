SELECT product.name as product_name, category.name as category_name 
FROM product LEFT JOIN category ON product.category_id = category.id