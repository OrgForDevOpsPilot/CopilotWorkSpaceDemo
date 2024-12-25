# API Design for Account Creation

## Endpoint
- **URL**: `/api/users`
- **Method**: `POST`
- **Description**: Creates a new user account.

## Request
- **Content-Type**: `application/json`
- **Body**:
  ```json
  {
    "username": "string",
    "email": "string",
    "password": "string"
  }
  ```

## Response
- **Status Code**: `201 Created`
- **Body**:
  ```json
  {
    "id": "integer",
    "username": "string",
    "email": "string",
    "created_at": "string"
  }
  ```

## Input Data Format and Validation Rules
- **Username**:
  - Type: `string`
  - Constraints: Required, Minimum length: 3, Maximum length: 32
- **Email**:
  - Type: `string`
  - Constraints: Required, Valid email format
- **Password**:
  - Type: `string`
  - Constraints: Required
