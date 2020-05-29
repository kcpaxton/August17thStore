using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Widgets.TimeSlots.Data;
using Nop.Plugin.Widgets.TimeSlots.Domain;
using Nop.Plugin.Widgets.TimeSlots.Services;
using Nop.Web.Framework.Infrastructure.Extensions;

namespace Nop.Plugin.Widgets.TimeSlots.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<TimeSlotService>().As<ITimeSlotService>().InstancePerLifetimeScope();

            //data context
            builder.RegisterPluginDataContext<OrderTimeSlotsObjectContext>("nop_object_context_order_time_slots");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<OrderTimeSlots>>().As<IRepository<OrderTimeSlots>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_order_time_slots"))
                .InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}
