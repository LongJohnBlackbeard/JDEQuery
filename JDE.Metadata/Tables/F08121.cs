using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08121 - .
/// </summary>
public class F08121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AJRPYR.
        /// </summary>
        public const string AJRPYR = "AJRPYR";

        /// <summary>
        /// AJAIRI.
        /// </summary>
        public const string AJAIRI = "AJAIRI";

        /// <summary>
        /// AJTAXX.
        /// </summary>
        public const string AJTAXX = "AJTAXX";

        /// <summary>
        /// AJRCK5.
        /// </summary>
        public const string AJRCK5 = "AJRCK5";

        /// <summary>
        /// AJALEM.
        /// </summary>
        public const string AJALEM = "AJALEM";

        /// <summary>
        /// AJARCC.
        /// </summary>
        public const string AJARCC = "AJARCC";

        /// <summary>
        /// AJRECP.
        /// </summary>
        public const string AJRECP = "AJRECP";

        /// <summary>
        /// AJRPCN.
        /// </summary>
        public const string AJRPCN = "AJRPCN";

        /// <summary>
        /// AJPHN1.
        /// </summary>
        public const string AJPHN1 = "AJPHN1";

        /// <summary>
        /// AJGVEN.
        /// </summary>
        public const string AJGVEN = "AJGVEN";

        /// <summary>
        /// AJDGCN.
        /// </summary>
        public const string AJDGCN = "AJDGCN";

        /// <summary>
        /// AJPHN2.
        /// </summary>
        public const string AJPHN2 = "AJPHN2";

        /// <summary>
        /// AJFRCN.
        /// </summary>
        public const string AJFRCN = "AJFRCN";

        /// <summary>
        /// AJAATR.
        /// </summary>
        public const string AJAATR = "AJAATR";

        /// <summary>
        /// AJATFC.
        /// </summary>
        public const string AJATFC = "AJATFC";

        /// <summary>
        /// AJAGGM.
        /// </summary>
        public const string AJAGGM = "AJAGGM";

        /// <summary>
        /// AJCOEA.
        /// </summary>
        public const string AJCOEA = "AJCOEA";

        /// <summary>
        /// AJCOEB.
        /// </summary>
        public const string AJCOEB = "AJCOEB";

        /// <summary>
        /// AJCOEC.
        /// </summary>
        public const string AJCOEC = "AJCOEC";

        /// <summary>
        /// AJCOED.
        /// </summary>
        public const string AJCOED = "AJCOED";

        /// <summary>
        /// AJSPASUSK1.
        /// </summary>
        public const string AJSPASUSK1 = "AJSPASUSK1";

        /// <summary>
        /// AJSPASUSK2.
        /// </summary>
        public const string AJSPASUSK2 = "AJSPASUSK2";

        /// <summary>
        /// AJSPASUSK3.
        /// </summary>
        public const string AJSPASUSK3 = "AJSPASUSK3";

        /// <summary>
        /// AJSPASUSK4.
        /// </summary>
        public const string AJSPASUSK4 = "AJSPASUSK4";

        /// <summary>
        /// AJSPASUSK5.
        /// </summary>
        public const string AJSPASUSK5 = "AJSPASUSK5";

        /// <summary>
        /// AJSPASUSK6.
        /// </summary>
        public const string AJSPASUSK6 = "AJSPASUSK6";

        /// <summary>
        /// AJSPASUSK7.
        /// </summary>
        public const string AJSPASUSK7 = "AJSPASUSK7";

        /// <summary>
        /// AJSPASUSK8.
        /// </summary>
        public const string AJSPASUSK8 = "AJSPASUSK8";

        /// <summary>
        /// AJSPANUSK1.
        /// </summary>
        public const string AJSPANUSK1 = "AJSPANUSK1";

        /// <summary>
        /// AJSPANUSK2.
        /// </summary>
        public const string AJSPANUSK2 = "AJSPANUSK2";

        /// <summary>
        /// AJSPANUSK3.
        /// </summary>
        public const string AJSPANUSK3 = "AJSPANUSK3";

        /// <summary>
        /// AJSPANUSK4.
        /// </summary>
        public const string AJSPANUSK4 = "AJSPANUSK4";

        /// <summary>
        /// AJSPADUSK1.
        /// </summary>
        public const string AJSPADUSK1 = "AJSPADUSK1";

        /// <summary>
        /// AJSPADUSK2.
        /// </summary>
        public const string AJSPADUSK2 = "AJSPADUSK2";

        /// <summary>
        /// AJSPADUSK3.
        /// </summary>
        public const string AJSPADUSK3 = "AJSPADUSK3";

        /// <summary>
        /// AJSPADUSK4.
        /// </summary>
        public const string AJSPADUSK4 = "AJSPADUSK4";

        /// <summary>
        /// AJSPACUSK1.
        /// </summary>
        public const string AJSPACUSK1 = "AJSPACUSK1";

        /// <summary>
        /// AJSPACUSK2.
        /// </summary>
        public const string AJSPACUSK2 = "AJSPACUSK2";

        /// <summary>
        /// AJSPACUSK3.
        /// </summary>
        public const string AJSPACUSK3 = "AJSPACUSK3";

        /// <summary>
        /// AJSPACUSK4.
        /// </summary>
        public const string AJSPACUSK4 = "AJSPACUSK4";

        /// <summary>
        /// AJSIGN.
        /// </summary>
        public const string AJSIGN = "AJSIGN";

        /// <summary>
        /// AJTTL.
        /// </summary>
        public const string AJTTL = "AJTTL";

        /// <summary>
        /// AJDTSN.
        /// </summary>
        public const string AJDTSN = "AJDTSN";

        /// <summary>
        /// AJUSER.
        /// </summary>
        public const string AJUSER = "AJUSER";

        /// <summary>
        /// AJPID.
        /// </summary>
        public const string AJPID = "AJPID";

        /// <summary>
        /// AJJOBN.
        /// </summary>
        public const string AJJOBN = "AJJOBN";

        /// <summary>
        /// AJUPMJ.
        /// </summary>
        public const string AJUPMJ = "AJUPMJ";

        /// <summary>
        /// AJUPMT.
        /// </summary>
        public const string AJUPMT = "AJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AJRPYR", "AJRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AJAIRI", "AJAIRI", JdeDataType.String, 20, true, true),
        new JdeField("AJTAXX", "AJTAXX", JdeDataType.String, 40, true, true),
        new JdeField("AJRCK5", "AJRCK5", JdeDataType.Numeric, null, true, true),
        new JdeField("AJALEM", "AJALEM", JdeDataType.String, 20),
        new JdeField("AJARCC", "AJARCC", JdeDataType.String, 2),
        new JdeField("AJRECP", "AJRECP", JdeDataType.String, 10),
        new JdeField("AJRPCN", "AJRPCN", JdeDataType.Numeric),
        new JdeField("AJPHN1", "AJPHN1", JdeDataType.String, 40),
        new JdeField("AJGVEN", "AJGVEN", JdeDataType.Numeric),
        new JdeField("AJDGCN", "AJDGCN", JdeDataType.Numeric),
        new JdeField("AJPHN2", "AJPHN2", JdeDataType.String, 40),
        new JdeField("AJFRCN", "AJFRCN", JdeDataType.Numeric),
        new JdeField("AJAATR", "AJAATR", JdeDataType.String, 2),
        new JdeField("AJATFC", "AJATFC", JdeDataType.Numeric),
        new JdeField("AJAGGM", "AJAGGM", JdeDataType.String, 2),
        new JdeField("AJCOEA", "AJCOEA", JdeDataType.String, 2),
        new JdeField("AJCOEB", "AJCOEB", JdeDataType.String, 2),
        new JdeField("AJCOEC", "AJCOEC", JdeDataType.String, 2),
        new JdeField("AJCOED", "AJCOED", JdeDataType.String, 2),
        new JdeField("AJSPASUSK1", "AJSPASUSK1", JdeDataType.String, 60),
        new JdeField("AJSPASUSK2", "AJSPASUSK2", JdeDataType.String, 60),
        new JdeField("AJSPASUSK3", "AJSPASUSK3", JdeDataType.String, 60),
        new JdeField("AJSPASUSK4", "AJSPASUSK4", JdeDataType.String, 60),
        new JdeField("AJSPASUSK5", "AJSPASUSK5", JdeDataType.String, 20),
        new JdeField("AJSPASUSK6", "AJSPASUSK6", JdeDataType.String, 20),
        new JdeField("AJSPASUSK7", "AJSPASUSK7", JdeDataType.String, 20),
        new JdeField("AJSPASUSK8", "AJSPASUSK8", JdeDataType.String, 20),
        new JdeField("AJSPANUSK1", "AJSPANUSK1", JdeDataType.Numeric),
        new JdeField("AJSPANUSK2", "AJSPANUSK2", JdeDataType.Numeric),
        new JdeField("AJSPANUSK3", "AJSPANUSK3", JdeDataType.Numeric),
        new JdeField("AJSPANUSK4", "AJSPANUSK4", JdeDataType.Numeric),
        new JdeField("AJSPADUSK1", "AJSPADUSK1", JdeDataType.Numeric),
        new JdeField("AJSPADUSK2", "AJSPADUSK2", JdeDataType.Numeric),
        new JdeField("AJSPADUSK3", "AJSPADUSK3", JdeDataType.Numeric),
        new JdeField("AJSPADUSK4", "AJSPADUSK4", JdeDataType.Numeric),
        new JdeField("AJSPACUSK1", "AJSPACUSK1", JdeDataType.String, 2),
        new JdeField("AJSPACUSK2", "AJSPACUSK2", JdeDataType.String, 2),
        new JdeField("AJSPACUSK3", "AJSPACUSK3", JdeDataType.String, 2),
        new JdeField("AJSPACUSK4", "AJSPACUSK4", JdeDataType.String, 2),
        new JdeField("AJSIGN", "AJSIGN", JdeDataType.String, 60),
        new JdeField("AJTTL", "AJTTL", JdeDataType.String, 60),
        new JdeField("AJDTSN", "AJDTSN", JdeDataType.Numeric),
        new JdeField("AJUSER", "AJUSER", JdeDataType.String, 20),
        new JdeField("AJPID", "AJPID", JdeDataType.String, 20),
        new JdeField("AJJOBN", "AJJOBN", JdeDataType.String, 20),
        new JdeField("AJUPMJ", "AJUPMJ", JdeDataType.Numeric),
        new JdeField("AJUPMT", "AJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08121_0", "Primary Key on AJRPYR, AJAIRI, AJTAXX, AJRCK5", new[] { "AJRPYR", "AJAIRI", "AJTAXX", "AJRCK5" }, isUnique: true, isPrimaryKey: true)
    };
}
