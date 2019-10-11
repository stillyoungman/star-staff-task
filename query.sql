SELECT productName, categoryName
FROM products
LEFT JOIN productcategory ON products.productId = productcategory.productId
LEFT JOIN categories ON productcategory.categoryId = categories.categoryId