﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Squidex.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Squidex.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Introduction
        ///
        ///The API provides two specifications. The Content API usually returns one object per schema field where the keys are the languages (or `iv` for non-localized) fields and the values are the actual field values.
        ///
        ///You can use the `X-Flatten` header to return a flat structure when you query content items. This is more performant and easier for code generation. Unfortunantely it cannot be modelled with OpenAPI. Therefore we provide two different documents for your API.
        ///
        ///Read more about this  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OpenApiContentDescription {
            get {
                return ResourceManager.GetString("OpenApiContentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data of the content.
        ///            
        ///Please note that each field is an object with one entry per language. 
        ///If the field is not localizable you must use `iv` (invariant language) as a key.
        ///
        ///Read more about it at: https://docs.squidex.io/04-guides/02-api.html.
        /// </summary>
        internal static string OpenApiSchemaBody {
            get {
                return ResourceManager.GetString("OpenApiSchemaBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How to make queries?
        ///
        ///Read more about it at: https://docs.squidex.io/04-guides/02-api.html
        ///
        ///The query endpoints support three options:
        ///
        ///### Query with OData
        ///
        ///Squidex supports a subset of the OData (https://www.odata.org/) syntax with with the following query options:
        ///
        ///* **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. You can change the maximum in the app settings, when [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OpenApiSchemaQuery {
            get {
                return ResourceManager.GetString("OpenApiSchemaQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Squidex uses oauth2 client authentication. Read more about it at: https://oauth.net/2/ and https://tools.ietf.org/html/rfc6750.
        ///
        ///To retrieve an access token, the client id must make a request to the token url. For example:
        ///
        ///    $ curl
        ///        -X POST &apos;&lt;TOKEN_URL&gt;&apos; 
        ///        -H &apos;Content-Type: application/x-www-form-urlencoded&apos; 
        ///        -d &apos;grant_type=client_credentials&amp;
        ///            client_id=[CLIENT_ID]&amp;
        ///            client_secret=[CLIENT_SECRET]&amp;
        ///			scope=squidex-api&apos;
        ///
        ///You must send this token in  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OpenApiSecurity {
            get {
                return ResourceManager.GetString("OpenApiSecurity", resourceCulture);
            }
        }
    }
}