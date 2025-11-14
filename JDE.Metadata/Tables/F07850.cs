using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07850 - .
/// </summary>
public class F07850 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FGFNDT.
        /// </summary>
        public const string FGFNDT = "FGFNDT";

        /// <summary>
        /// FGFNDB.
        /// </summary>
        public const string FGFNDB = "FGFNDB";

        /// <summary>
        /// FGFNDA.
        /// </summary>
        public const string FGFNDA = "FGFNDA";

        /// <summary>
        /// FGHMCU.
        /// </summary>
        public const string FGHMCU = "FGHMCU";

        /// <summary>
        /// FGUN.
        /// </summary>
        public const string FGUN = "FGUN";

        /// <summary>
        /// FGJCOD.
        /// </summary>
        public const string FGJCOD = "FGJCOD";

        /// <summary>
        /// FGJBST.
        /// </summary>
        public const string FGJBST = "FGJBST";

        /// <summary>
        /// FGFNDR.
        /// </summary>
        public const string FGFNDR = "FGFNDR";

        /// <summary>
        /// FGFNDK.
        /// </summary>
        public const string FGFNDK = "FGFNDK";

        /// <summary>
        /// FGFDSA.
        /// </summary>
        public const string FGFDSA = "FGFDSA";

        /// <summary>
        /// FGFDSP.
        /// </summary>
        public const string FGFDSP = "FGFDSP";

        /// <summary>
        /// FGUSER.
        /// </summary>
        public const string FGUSER = "FGUSER";

        /// <summary>
        /// FGJOBN.
        /// </summary>
        public const string FGJOBN = "FGJOBN";

        /// <summary>
        /// FGPID.
        /// </summary>
        public const string FGPID = "FGPID";

        /// <summary>
        /// FGUPMJ.
        /// </summary>
        public const string FGUPMJ = "FGUPMJ";

        /// <summary>
        /// FGUPMT.
        /// </summary>
        public const string FGUPMT = "FGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07850";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FGFNDT", "FGFNDT", JdeDataType.String, 2, true, true),
        new JdeField("FGFNDB", "FGFNDB", JdeDataType.String, 30, true, true),
        new JdeField("FGFNDA", "FGFNDA", JdeDataType.String, 2, true, true),
        new JdeField("FGHMCU", "FGHMCU", JdeDataType.String, 24, true, true),
        new JdeField("FGUN", "FGUN", JdeDataType.String, 12, true, true),
        new JdeField("FGJCOD", "FGJCOD", JdeDataType.String, 20, true, true),
        new JdeField("FGJBST", "FGJBST", JdeDataType.String, 8, true, true),
        new JdeField("FGFNDR", "FGFNDR", JdeDataType.String, 2),
        new JdeField("FGFNDK", "FGFNDK", JdeDataType.Numeric),
        new JdeField("FGFDSA", "FGFDSA", JdeDataType.Numeric, null, true, true),
        new JdeField("FGFDSP", "FGFDSP", JdeDataType.Numeric),
        new JdeField("FGUSER", "FGUSER", JdeDataType.String, 20),
        new JdeField("FGJOBN", "FGJOBN", JdeDataType.String, 20),
        new JdeField("FGPID", "FGPID", JdeDataType.String, 20),
        new JdeField("FGUPMJ", "FGUPMJ", JdeDataType.Numeric),
        new JdeField("FGUPMT", "FGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07850_0", "Primary Key on FGFNDT, FGFNDB, FGFNDA, FGHMCU, FGUN, FGJCOD, FGJBST, FGFDSA", new[] { "FGFNDT", "FGFNDB", "FGFNDA", "FGHMCU", "FGUN", "FGJCOD", "FGJBST", "FGFDSA" }, isUnique: true, isPrimaryKey: true)
    };
}
