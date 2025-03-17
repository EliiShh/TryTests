pipeline {
    agent any

    environment {
        DOTNET_VERSION = '7.0'
    }

    stages {
        stage('Checkout') {
            steps {
                // שלב זה מוודא שאנו שולפים את הקוד מתוך Git
                git 'https://github.com/EliiShh/TryTests.git'
            }
        }
        stage('Build') {
            steps {
                // שלב זה בונה את הפרויקט
                script {
                    sh 'dotnet build TryTests/TryTests.csproj'
                }
                script {
                    sh 'dotnet build TryTests.Test/TryTests.Test.csproj'
                }
            }
        }

        stage('Test') {
            steps {
                // שלב זה רץ את המבחנים אם ישנם
                script {
                    sh 'dotnet test TryTests.Test/TryTests.Test.csproj'
                }
            }
        }

        stage('Run Application') {
            steps {
                // שלב זה רץ את התוכנית ומדפיס את הפלט לקונסול
                script {
                    sh 'dotnet run --project TryTests/TryTests.csproj'
                }
            }
        }
    }

    post {
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}
