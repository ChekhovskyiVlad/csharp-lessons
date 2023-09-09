namespace project {
    interface IRun {


        // в интерфеская мы описываем какие поля, аксесоры, какие методы нам понадобятся для определенного действия
        float speed { get; set;}
        void RobotRun();
    }
}