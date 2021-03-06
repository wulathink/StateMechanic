﻿namespace StateMechanic
{
    /// <summary>
    /// Contains information on a dynamic transition, passed to the transition's state selector
    /// </summary>
    /// <typeparam name="TState">Type of state</typeparam>
    public struct DynamicSelectorInfo<TState>
    {
        /// <summary>
        /// Gets the state this transition is from
        /// </summary>
        public TState From { get; }

        /// <summary>
        /// Gets the event which triggered this transition
        /// </summary>
        public Event Event { get; }


        internal DynamicSelectorInfo(TState from, Event @event)
        {
            this.From = from;
            this.Event = @event;
        }
        
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns> A string that represents the current object.</returns>
        [ExcludeFromCoverage]
        public override string ToString()
        {
            return $"<DynamicSelectorInfo From={this.From} Event={this.Event}>";
        }
    }

    /// <summary>
    /// Contains information on a dynamic transition, passed to the transition's state selector
    /// </summary>
    /// <typeparam name="TState">Type of state</typeparam>
    /// <typeparam name="TEventData">Type of event data</typeparam>
    public struct DynamicSelectorInfo<TState, TEventData>
    {
        /// <summary>
        /// Gets the state this transition is from
        /// </summary>
        public TState From { get; }

        /// <summary>
        /// Gets the event which triggered this transition
        /// </summary>
        public Event<TEventData> Event { get; }

        /// <summary>
        /// Gets the event data which was passed when the event was fired
        /// </summary>
        public TEventData EventData { get; }

        internal DynamicSelectorInfo(TState from, Event<TEventData> @event, TEventData eventData)
        {
            this.From = from;
            this.Event = @event;
            this.EventData = eventData;
        }
        
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns> A string that represents the current object.</returns>
        [ExcludeFromCoverage]
        public override string ToString()
        {
            return $"<DynamicSelectorInfo From={this.From} Event={this.Event} EventData={this.EventData}>";
        }
    }
}

