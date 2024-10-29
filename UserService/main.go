package main

import (
	"UserService/controllers"
	"UserService/database"
	"UserService/middlewares"

	"github.com/gin-gonic/gin"
)

func main() {
	
	r := gin.Default()

	database.ConnectDatabase()

	r.GET("/ping", func(c *gin.Context) {
		c.JSON(200, gin.H{
			"message": "pong",
		})
	})



	r.POST("/register", controllers.RegisterUser)
	r.POST("/login", controllers.LoginUser)

	r.GET("/profile", middlewares.AuthMiddleware(), func(c *gin.Context) {
		username, _ := c.Get("username")
		c.JSON(200, gin.H{
			"message":  "Welcome to your profile",
			"username": username,
		})
	})

	r.Run(":5001")
}
