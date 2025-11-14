using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0403 - .
/// </summary>
public class F76B0403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STISTE.
        /// </summary>
        public const string STISTE = "STISTE";

        /// <summary>
        /// STINDK.
        /// </summary>
        public const string STINDK = "STINDK";

        /// <summary>
        /// STDGJ.
        /// </summary>
        public const string STDGJ = "STDGJ";

        /// <summary>
        /// STINAA.
        /// </summary>
        public const string STINAA = "STINAA";

        /// <summary>
        /// STINBA.
        /// </summary>
        public const string STINBA = "STINBA";

        /// <summary>
        /// STBRIINS.
        /// </summary>
        public const string STBRIINS = "STBRIINS";

        /// <summary>
        /// STTAX.
        /// </summary>
        public const string STTAX = "STTAX";

        /// <summary>
        /// STGPS.
        /// </summary>
        public const string STGPS = "STGPS";

        /// <summary>
        /// STTORG.
        /// </summary>
        public const string STTORG = "STTORG";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STISTE", "STISTE", JdeDataType.String, 60, true, true),
        new JdeField("STINDK", "STINDK", JdeDataType.String, 60),
        new JdeField("STDGJ", "STDGJ", JdeDataType.Numeric),
        new JdeField("STINAA", "STINAA", JdeDataType.Numeric),
        new JdeField("STINBA", "STINBA", JdeDataType.Numeric),
        new JdeField("STBRIINS", "STBRIINS", JdeDataType.String, 40),
        new JdeField("STTAX", "STTAX", JdeDataType.String, 40),
        new JdeField("STGPS", "STGPS", JdeDataType.Numeric),
        new JdeField("STTORG", "STTORG", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0403_0", "Primary Key on STAN8, STISTE", new[] { "STAN8", "STISTE" }, isUnique: true, isPrimaryKey: true)
    };
}
