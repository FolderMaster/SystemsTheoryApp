﻿using System;
using System.Collections.Generic;

using ClassificationApp.Models.Scenes;
using ClassificationApp.Services.Classification;

namespace ClassificationApp.Services.Factories
{
    /// <summary>
    /// Класс фабрики сцен, представляющий методы для создания сцен.
    /// </summary>
    public static class SceneFactory
    {
        /// <summary>
        /// Создаёт трёхмерную сцену на основе классификатора.
        /// </summary>
        /// <param name="classifier">Классификатор.</param>
        /// <returns>Трёхмерная сцена.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static Scene3D CreateScene3DByClassifier(IClassifier classifier)
        {
            Scene3D result = new Scene3D();
            result.Graph = new Graph3D(new List<Axis>() { new Axis(new LinearScale(), 100),
                new Axis(new LinearScale(), 100), new Axis(new LinearScale(), 100) });
            result.Camera = new Camera3D(result, new Vector(new List<double>() { 0, -1, 0 }), 
                new Point(new List<double>() { 50, 50, 50 }));
            result.Shapes.Add(new LineSegment(new Point(), new Point(new List<double>() { 50, 0, 0 })));
            result.Shapes.Add(new LineSegment(new Point(), new Point(new List<double>() { 0, 50, 0 })));
            result.Shapes.Add(new LineSegment(new Point(), new Point(new List<double>() { 0, 0, 50 })));
            if (classifier is NeighborClassifier neighborClassifier)
            {
                result.Graph.Shapes.AddRange(neighborClassifier.EduccationPoints);
                result.Graph.Shapes.AddRange(neighborClassifier.ResultPoints);
            }
            else if (classifier is LinearClassifier linearClassifier)
            {
                result.Graph.Shapes.AddRange(linearClassifier.EduccationPoints);
                result.Graph.Shapes.AddRange(linearClassifier.ResultPoints);
                result.Graph.Shapes.Add(linearClassifier.DevelopedMiddlePoint);
                result.Graph.Shapes.Add(linearClassifier.DevelopingMiddlePoint);
                result.Graph.Shapes.Add(new LineSegment(linearClassifier.DevelopedMiddlePoint,
                    linearClassifier.DevelopingMiddlePoint));
                result.Graph.Shapes.Add(linearClassifier.PlanePoint);
                result.Graph.Shapes.Add(ShapeFactory.CreatePlaneByPoindAndVector(linearClassifier.
                    PlanePoint, linearClassifier.PlaneVector));
            }
            else
            {
                throw new ArgumentException();
            }
            result.Graph.DefaultDisplay();
            return result;
        }
    }
}