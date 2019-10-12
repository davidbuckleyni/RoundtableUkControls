﻿
using RoundTable.Controls.Shared;
using System;

namespace Plugin.DialogKit
{
    /// <summary>
    /// Cross DiaglogKit
    /// </summary>
    public static class RoundTableDialogKit
    {
        static Lazy<IDialogKit> implementation = new Lazy<IDialogKit>(() => CreateRoundTableDialogKit(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => implementation.Value == null ? false : true;

        static IDialogKit _current;
        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IDialogKit Current
        {
            get
            {
                if (_current == null)
                    _current = new RoundTable.Controls.Shared.DialogKit();
                return _current;
            }
        }
           static IDialogKit CreateRoundTableDialogKit()
        {
#if NETSTANDARD1_0 || NETSTANDARD2_0
            return null;
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return new DiaglogKitImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    }
}
