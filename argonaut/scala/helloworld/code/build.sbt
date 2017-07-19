lazy val root = (project in file("."))
  .settings(
    name         := "hello",
    organization := "com.example",
    scalaVersion := "2.12.1",
    version      := "0.1.0-SNAPSHOT"
  )
