namespace ParkingLot.Core.ApiHelpers
{
    using System;

    public static class ObjectNullChecker
    {
        /// <summary>
        /// Si <paramref name="value"/> es nulo arroja una ArgumentNullException con <paramref name="parameterName"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parameterName"></param>
        /// <exception cref ="System.ArgumentNullException"> Arrojada cuando <paramref name="value"/> es null</exception>
        public static void Check(object value, string parameterName)
        {
            if (value == null || (value is string && string.IsNullOrWhiteSpace(value as string)))
                throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Si <paramref name="value"/> es nulo arroja una ArgumentNullException con <paramref name="parameterName"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parameterName"></param>
        /// <exception cref ="System.ArgumentNullException"> Arrojada cuando <paramref name="value"/> es null</exception>
        /// <returns>Retorna el <paramref name="value"/> si no es null</returns>
        public static T Check<T>(T value, string parameterName)
        {
            if (value == null || (value is string && string.IsNullOrWhiteSpace(value as string)))
                throw new ArgumentNullException(parameterName);
            else
                return value;
        }
    }
}
