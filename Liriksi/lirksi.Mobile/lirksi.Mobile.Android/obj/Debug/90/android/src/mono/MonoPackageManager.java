package mono;

import java.io.*;
import java.lang.String;
import java.util.Locale;
import java.util.HashSet;
import java.util.zip.*;
import android.content.Context;
import android.content.Intent;
import android.content.pm.ApplicationInfo;
import android.content.res.AssetManager;
import android.util.Log;
import mono.android.Runtime;

public class MonoPackageManager {

	static Object lock = new Object ();
	static boolean initialized;

	static android.content.Context Context;

	public static void LoadApplication (Context context, ApplicationInfo runtimePackage, String[] apks)
	{
		synchronized (lock) {
			if (context instanceof android.app.Application) {
				Context = context;
			}
			if (!initialized) {
				android.content.IntentFilter timezoneChangedFilter  = new android.content.IntentFilter (
						android.content.Intent.ACTION_TIMEZONE_CHANGED
				);
				context.registerReceiver (new mono.android.app.NotifyTimeZoneChanges (), timezoneChangedFilter);
				
				System.loadLibrary("monodroid");
				Locale locale       = Locale.getDefault ();
				String language     = locale.getLanguage () + "-" + locale.getCountry ();
				String filesDir     = context.getFilesDir ().getAbsolutePath ();
				String cacheDir     = context.getCacheDir ().getAbsolutePath ();
				String dataDir      = getNativeLibraryPath (context);
				ClassLoader loader  = context.getClassLoader ();
				java.io.File external0 = android.os.Environment.getExternalStorageDirectory ();
				String externalDir = new java.io.File (
							external0,
							"Android/data/" + context.getPackageName () + "/files/.__override__").getAbsolutePath ();
				String externalLegacyDir = new java.io.File (
							external0,
							"../legacy/Android/data/" + context.getPackageName () + "/files/.__override__").getAbsolutePath ();

				Runtime.init (
						language,
						apks,
						getNativeLibraryPath (runtimePackage),
						new String[]{
							filesDir,
							cacheDir,
							dataDir,
						},
						loader,
						new String[] {
							externalDir,
							externalLegacyDir
						},
						MonoPackageManager_Resources.Assemblies,
						context.getPackageName ());
				
				mono.android.app.ApplicationRegistration.registerApplications ();
				
				initialized = true;
			}
		}
	}

	public static void setContext (Context context)
	{
		// Ignore; vestigial
	}

	static String getNativeLibraryPath (Context context)
	{
	    return getNativeLibraryPath (context.getApplicationInfo ());
	}

	static String getNativeLibraryPath (ApplicationInfo ainfo)
	{
		if (android.os.Build.VERSION.SDK_INT >= 9)
			return ainfo.nativeLibraryDir;
		return ainfo.dataDir + "/lib";
	}

	public static String[] getAssemblies ()
	{
		return MonoPackageManager_Resources.Assemblies;
	}

	public static String[] getDependencies ()
	{
		return MonoPackageManager_Resources.Dependencies;
	}

	public static String getApiPackageName ()
	{
		return MonoPackageManager_Resources.ApiPackageName;
	}
}

class MonoPackageManager_Resources {
	public static final String[] Assemblies = new String[]{
		/* We need to ensure that "lirksi.Mobile.Android.dll" comes first in this list. */
		"lirksi.Mobile.Android.dll",
		"AutoMapper.dll",
		"AutoMapper.Extensions.Microsoft.DependencyInjection.dll",
		"Flurl.dll",
		"Flurl.Http.dll",
		"FormsViewGroup.dll",
		"lirksi.Mobile.dll",
		"Microsoft.AspNetCore.Authentication.Abstractions.dll",
		"Microsoft.AspNetCore.Authentication.Core.dll",
		"Microsoft.AspNetCore.Authorization.dll",
		"Microsoft.AspNetCore.Authorization.Policy.dll",
		"Microsoft.AspNetCore.Hosting.Abstractions.dll",
		"Microsoft.AspNetCore.Hosting.Server.Abstractions.dll",
		"Microsoft.AspNetCore.Http.Abstractions.dll",
		"Microsoft.AspNetCore.Http.dll",
		"Microsoft.AspNetCore.Http.Extensions.dll",
		"Microsoft.AspNetCore.Http.Features.dll",
		"Microsoft.AspNetCore.JsonPatch.dll",
		"Microsoft.AspNetCore.Mvc.Abstractions.dll",
		"Microsoft.AspNetCore.Mvc.ApiExplorer.dll",
		"Microsoft.AspNetCore.Mvc.Core.dll",
		"Microsoft.AspNetCore.Mvc.DataAnnotations.dll",
		"Microsoft.AspNetCore.Mvc.Formatters.Json.dll",
		"Microsoft.AspNetCore.ResponseCaching.Abstractions.dll",
		"Microsoft.AspNetCore.Routing.Abstractions.dll",
		"Microsoft.AspNetCore.Routing.dll",
		"Microsoft.AspNetCore.StaticFiles.dll",
		"Microsoft.AspNetCore.WebUtilities.dll",
		"Microsoft.DotNet.PlatformAbstractions.dll",
		"Microsoft.Extensions.Configuration.Abstractions.dll",
		"Microsoft.Extensions.DependencyInjection.Abstractions.dll",
		"Microsoft.Extensions.DependencyModel.dll",
		"Microsoft.Extensions.FileProviders.Abstractions.dll",
		"Microsoft.Extensions.FileProviders.Embedded.dll",
		"Microsoft.Extensions.Hosting.Abstractions.dll",
		"Microsoft.Extensions.Localization.Abstractions.dll",
		"Microsoft.Extensions.Localization.dll",
		"Microsoft.Extensions.Logging.Abstractions.dll",
		"Microsoft.Extensions.ObjectPool.dll",
		"Microsoft.Extensions.Options.dll",
		"Microsoft.Extensions.Primitives.dll",
		"Microsoft.Extensions.WebEncoders.dll",
		"Microsoft.Net.Http.Headers.dll",
		"Newtonsoft.Json.dll",
		"Plugin.Media.dll",
		"Swashbuckle.AspNetCore.dll",
		"Swashbuckle.AspNetCore.Swagger.dll",
		"Swashbuckle.AspNetCore.SwaggerGen.dll",
		"Swashbuckle.AspNetCore.SwaggerUI.dll",
		"System.Buffers.dll",
		"System.Diagnostics.DiagnosticSource.dll",
		"System.Runtime.CompilerServices.Unsafe.dll",
		"System.Text.Encodings.Web.dll",
		"Xamarin.Android.Arch.Core.Common.dll",
		"Xamarin.Android.Arch.Core.Runtime.dll",
		"Xamarin.Android.Arch.Lifecycle.Common.dll",
		"Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll",
		"Xamarin.Android.Arch.Lifecycle.LiveData.dll",
		"Xamarin.Android.Arch.Lifecycle.Runtime.dll",
		"Xamarin.Android.Arch.Lifecycle.ViewModel.dll",
		"Xamarin.Android.Support.Animated.Vector.Drawable.dll",
		"Xamarin.Android.Support.Annotations.dll",
		"Xamarin.Android.Support.AsyncLayoutInflater.dll",
		"Xamarin.Android.Support.Collections.dll",
		"Xamarin.Android.Support.Compat.dll",
		"Xamarin.Android.Support.CoordinaterLayout.dll",
		"Xamarin.Android.Support.Core.UI.dll",
		"Xamarin.Android.Support.Core.Utils.dll",
		"Xamarin.Android.Support.CursorAdapter.dll",
		"Xamarin.Android.Support.CustomTabs.dll",
		"Xamarin.Android.Support.CustomView.dll",
		"Xamarin.Android.Support.Design.dll",
		"Xamarin.Android.Support.DocumentFile.dll",
		"Xamarin.Android.Support.DrawerLayout.dll",
		"Xamarin.Android.Support.Fragment.dll",
		"Xamarin.Android.Support.Interpolator.dll",
		"Xamarin.Android.Support.Loader.dll",
		"Xamarin.Android.Support.LocalBroadcastManager.dll",
		"Xamarin.Android.Support.Media.Compat.dll",
		"Xamarin.Android.Support.Print.dll",
		"Xamarin.Android.Support.SlidingPaneLayout.dll",
		"Xamarin.Android.Support.SwipeRefreshLayout.dll",
		"Xamarin.Android.Support.Transition.dll",
		"Xamarin.Android.Support.v4.dll",
		"Xamarin.Android.Support.v7.AppCompat.dll",
		"Xamarin.Android.Support.v7.CardView.dll",
		"Xamarin.Android.Support.v7.RecyclerView.dll",
		"Xamarin.Android.Support.Vector.Drawable.dll",
		"Xamarin.Android.Support.VersionedParcelable.dll",
		"Xamarin.Android.Support.ViewPager.dll",
		"Xamarin.Essentials.dll",
		"Xamarin.Forms.Core.dll",
		"Xamarin.Forms.Platform.Android.dll",
		"Xamarin.Forms.Platform.dll",
		"Xamarin.Forms.Xaml.dll",
		"liriksi.Model.dll",
	};
	public static final String[] Dependencies = new String[]{
	};
	public static final String ApiPackageName = "Mono.Android.Platform.ApiLevel_28";
}
