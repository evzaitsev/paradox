﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System.Windows;

namespace SiliconStudio.Presentation.Behaviors
{
    /// <summary>
    /// An implementation of the <see cref="OnEventBehavior"/> class that allows to set the value of a dependency property
    /// on the control hosting this behavior when a specific event is raised.
    /// </summary>
    public class OnEventSetPropertyBehavior : OnEventBehavior
    {
        /// <summary>
        /// Identifies the <see cref="Property"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty PropertyProperty = DependencyProperty.Register("Property", typeof(DependencyProperty), typeof(OnEventSetPropertyBehavior));

        /// <summary>
        /// Identifies the <see cref="Value"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(object), typeof(OnEventSetPropertyBehavior));

        /// <summary>
        /// Gets or sets the <see cref="DependencyProperty"/> to set when the event is raised.
        /// </summary>
        public DependencyProperty Property { get { return (DependencyProperty)GetValue(PropertyProperty); } set { SetValue(PropertyProperty, value); } }

        /// <summary>
        /// Gets or sets the value to set when the event is raised.
        /// </summary>
        public object Value { get { return GetValue(ValueProperty); } set { SetValue(ValueProperty, value); } }

        /// <inheritdoc/>
        protected override void OnEvent()
        {
            AssociatedObject.SetCurrentValue(Property, Value);
        }
    }
}