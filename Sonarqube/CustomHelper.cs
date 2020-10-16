﻿using System.Collections.Generic;

namespace Chuck.Sonarqube
{
    public static class CustomHelper
    {
        public static List<string> MandatoryFields = new List<string>
        {
            "First name",
            "Last name"
        };
    }

    public class Math
    {
        public static double Pi = 3.14;
    }

    public class Shape
    {
        public static Shape Empty = new EmptyShape();

        private class EmptyShape : Shape
        {
        }
    }
}
