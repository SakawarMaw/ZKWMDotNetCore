﻿namespace ZKWMDotNetCore.RestApiWithNLayer
{
    public static class ConnectionString
    {
        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "ZAKAWARMAW\\SQL2022",
            InitialCatalog = "DotNetTrainingBatch4",
            UserID = "sa",
            Password = "sa@123",
           // TrustServerCertificate = true,
        };
    }
}
