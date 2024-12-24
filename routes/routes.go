package routes

import (
	"net/http"
	"myapp/controllers"
)

func RegisterRoutes() {
	http.HandleFunc("/api/users", controllers.CreateUser)
}
