package models

import (
	"time"
	"golang.org/x/crypto/bcrypt"
	"gopkg.in/go-playground/validator.v9"
)

type User struct {
	Username     string    `json:"username" validate:"required,min=3,max=32"`
	Email        string    `json:"email" validate:"required,email"`
	PasswordHash string    `json:"-" validate:"required"`
	CreatedAt    time.Time `json:"created_at"`
}

func (u *User) HashPassword(password string) error {
	hashedPassword, err := bcrypt.GenerateFromPassword([]byte(password), bcrypt.DefaultCost)
	if err != nil {
		return err
	}
	u.PasswordHash = string(hashedPassword)
	return nil
}

func (u *User) Validate() error {
	validate := validator.New()
	return validate.Struct(u)
}
