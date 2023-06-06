namespace api.Utility
{
    public class SecretUtility
    {
        public static string? SqlServer
        {
            get
            {
                return Environment.GetEnvironmentVariable("SQLSERVER");
            }
        }

        public static string? JWTIssuer
        {
            get
            {
                return Environment.GetEnvironmentVariable("JWT_ISSUER");
            }
        }

        public static string? KeycloakPublicKey
        {
            get
            {
                return Environment.GetEnvironmentVariable("KEYCLOAK_PUBLIC_KEY");
            }
        }
    }
}
