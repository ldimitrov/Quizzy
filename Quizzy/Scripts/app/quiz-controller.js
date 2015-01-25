/*
 * The constructor function of the QuizController expects an injectable parameter named $scope. 
 * The initial state of the scope should be set up in the constructor function by attaching 
 * properties to the $scope object. The properties contain the view model, and will be accessible
 * to the template when the controller is registered.
 */

angular.module('QuizzyApp', [])
    .controller('QuizController', function ($scope, $http) {
        $scope.answered = false;
        $scope.title = "loading next question...";
        $scope.options = [];
        $scope.correctAnswer = false;
        $scope.working = false;

        $scope.answer = function() {
            return $scope.correctAnswer ? 'correct' : 'incorrect';
        };
        
        /*
         * This function retrieves the next question from the Quizzy Web API and attaches 
         * the question data to the $scope object.
         */
        $scope.nextQuestion = function () {
            $scope.working = true;
            $scope.answered = false;
            $scope.title = "loading next question...";
            $scope.options = [];

            $http.get("/api/quizzy").success(function (data, status, headers, config) {
                $scope.options = data.options;
                $scope.title = data.title;
                $scope.answered = false;
                $scope.working = false;
            }).error(function (data, status, headers, config) {
                $scope.title = "Something went wrong";
                $scope.working = false;
            });
        };
    });
