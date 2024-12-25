# Security Considerations for Account Creation

## Password Hashing Method
- **Method**: bcrypt
- **Description**: Passwords are hashed using the bcrypt algorithm to ensure they are stored securely. Bcrypt is a password hashing function designed to be computationally expensive, making it resistant to brute-force attacks.

## CSRF Prevention
- **Method**: CSRF Tokens
- **Description**: Cross-Site Request Forgery (CSRF) attacks are mitigated by using CSRF tokens. These tokens are unique to each session and are included in forms and AJAX requests to ensure that the request is coming from an authenticated user.

## SQL Injection Prevention
- **Method**: Parameterized Queries
- **Description**: SQL injection attacks are prevented by using parameterized queries. This ensures that user input is treated as data and not executable code, preventing attackers from injecting malicious SQL statements.
