// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GetMovieId.
    /// </summary>
    public static partial class GetMovieIdExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            public static MovieResponse Get(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>))
            {
                return operations.GetAsync(id, includes).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MovieResponse> GetAsync(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, includes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static MovieResponse Create(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), GetMovie body = default(GetMovie))
            {
                return operations.CreateAsync(id, includes, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MovieResponse> CreateAsync(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), GetMovie body = default(GetMovie), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(id, includes, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static MovieResponse Post(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), GetMovie body = default(GetMovie))
            {
                return operations.PostAsync(id, includes, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MovieResponse> PostAsync(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), GetMovie body = default(GetMovie), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(id, includes, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            public static MovieResponse Delete(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>))
            {
                return operations.DeleteAsync(id, includes).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='includes'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MovieResponse> DeleteAsync(this IGetMovieId operations, long id, IList<string> includes = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(id, includes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}