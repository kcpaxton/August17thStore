using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Data.Mapping;
using Nop.Plugin.Widgets.TimeSlots.Domain;

namespace Nop.Plugin.Widgets.TimeSlots.Data
{
    public partial class OrderTimeSlotsMap : NopEntityTypeConfiguration<OrderTimeSlots>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<OrderTimeSlots> builder)
        {
            builder.ToTable(nameof(OrderTimeSlots));
            builder.HasKey(timeSlots => timeSlots.Id);

            builder.Property(timeSlots => timeSlots.ReservationTime);
            builder.Property(timeSlots => timeSlots.FriendlyName);
            builder.Property(timeSlots => timeSlots.Available);
            builder.Property(timeSlots => timeSlots.MaxNumberOfOrders);
            builder.Property(timeSlots => timeSlots.NumberOfOrdersBooked);

            base.Configure(builder);
        }

        #endregion
    }
}
