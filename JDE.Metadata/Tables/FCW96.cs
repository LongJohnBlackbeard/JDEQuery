using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW96 - .
/// </summary>
public class FCW96 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WOJOBS.
        /// </summary>
        public const string WOJOBS = "WOJOBS";

        /// <summary>
        /// WOUKID.
        /// </summary>
        public const string WOUKID = "WOUKID";

        /// <summary>
        /// WOC9LANC.
        /// </summary>
        public const string WOC9LANC = "WOC9LANC";

        /// <summary>
        /// WODCTO.
        /// </summary>
        public const string WODCTO = "WODCTO";

        /// <summary>
        /// WOITM.
        /// </summary>
        public const string WOITM = "WOITM";

        /// <summary>
        /// WOMCU.
        /// </summary>
        public const string WOMCU = "WOMCU";

        /// <summary>
        /// WOTRQT.
        /// </summary>
        public const string WOTRQT = "WOTRQT";

        /// <summary>
        /// WOUORG.
        /// </summary>
        public const string WOUORG = "WOUORG";

        /// <summary>
        /// WOSTRT.
        /// </summary>
        public const string WOSTRT = "WOSTRT";

        /// <summary>
        /// WODRQJ.
        /// </summary>
        public const string WODRQJ = "WODRQJ";

        /// <summary>
        /// WOLITM.
        /// </summary>
        public const string WOLITM = "WOLITM";

        /// <summary>
        /// WOAITM.
        /// </summary>
        public const string WOAITM = "WOAITM";

        /// <summary>
        /// WODSC1.
        /// </summary>
        public const string WODSC1 = "WODSC1";

        /// <summary>
        /// WOUOM8.
        /// </summary>
        public const string WOUOM8 = "WOUOM8";

        /// <summary>
        /// WOSRP1.
        /// </summary>
        public const string WOSRP1 = "WOSRP1";

        /// <summary>
        /// WOSRP2.
        /// </summary>
        public const string WOSRP2 = "WOSRP2";

        /// <summary>
        /// WOSRP3.
        /// </summary>
        public const string WOSRP3 = "WOSRP3";

        /// <summary>
        /// WOSRP4.
        /// </summary>
        public const string WOSRP4 = "WOSRP4";

        /// <summary>
        /// WOSRP5.
        /// </summary>
        public const string WOSRP5 = "WOSRP5";

        /// <summary>
        /// WOSRP6.
        /// </summary>
        public const string WOSRP6 = "WOSRP6";

        /// <summary>
        /// WOSRP7.
        /// </summary>
        public const string WOSRP7 = "WOSRP7";

        /// <summary>
        /// WOSRP8.
        /// </summary>
        public const string WOSRP8 = "WOSRP8";

        /// <summary>
        /// WOSRP9.
        /// </summary>
        public const string WOSRP9 = "WOSRP9";

        /// <summary>
        /// WOSRP0.
        /// </summary>
        public const string WOSRP0 = "WOSRP0";

        /// <summary>
        /// WOPRP1.
        /// </summary>
        public const string WOPRP1 = "WOPRP1";

        /// <summary>
        /// WOPRP2.
        /// </summary>
        public const string WOPRP2 = "WOPRP2";

        /// <summary>
        /// WOPRP3.
        /// </summary>
        public const string WOPRP3 = "WOPRP3";

        /// <summary>
        /// WOPRP4.
        /// </summary>
        public const string WOPRP4 = "WOPRP4";

        /// <summary>
        /// WOPRP5.
        /// </summary>
        public const string WOPRP5 = "WOPRP5";

        /// <summary>
        /// WOPRP6.
        /// </summary>
        public const string WOPRP6 = "WOPRP6";

        /// <summary>
        /// WOPRP7.
        /// </summary>
        public const string WOPRP7 = "WOPRP7";

        /// <summary>
        /// WOPRP8.
        /// </summary>
        public const string WOPRP8 = "WOPRP8";

        /// <summary>
        /// WOPRP9.
        /// </summary>
        public const string WOPRP9 = "WOPRP9";

        /// <summary>
        /// WOPRP0.
        /// </summary>
        public const string WOPRP0 = "WOPRP0";

        /// <summary>
        /// WOCKAV.
        /// </summary>
        public const string WOCKAV = "WOCKAV";

        /// <summary>
        /// WOUSER.
        /// </summary>
        public const string WOUSER = "WOUSER";

        /// <summary>
        /// WOPID.
        /// </summary>
        public const string WOPID = "WOPID";

        /// <summary>
        /// WOJOBN.
        /// </summary>
        public const string WOJOBN = "WOJOBN";

        /// <summary>
        /// WOUPMJ.
        /// </summary>
        public const string WOUPMJ = "WOUPMJ";

        /// <summary>
        /// WOUPMT.
        /// </summary>
        public const string WOUPMT = "WOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW96";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WOJOBS", "WOJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WOUKID", "WOUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WOC9LANC", "WOC9LANC", JdeDataType.Numeric),
        new JdeField("WODCTO", "WODCTO", JdeDataType.String, 4),
        new JdeField("WOITM", "WOITM", JdeDataType.Numeric),
        new JdeField("WOMCU", "WOMCU", JdeDataType.String, 24),
        new JdeField("WOTRQT", "WOTRQT", JdeDataType.Numeric),
        new JdeField("WOUORG", "WOUORG", JdeDataType.Numeric),
        new JdeField("WOSTRT", "WOSTRT", JdeDataType.Numeric),
        new JdeField("WODRQJ", "WODRQJ", JdeDataType.Numeric),
        new JdeField("WOLITM", "WOLITM", JdeDataType.String, 50),
        new JdeField("WOAITM", "WOAITM", JdeDataType.String, 50),
        new JdeField("WODSC1", "WODSC1", JdeDataType.String, 60),
        new JdeField("WOUOM8", "WOUOM8", JdeDataType.String, 4),
        new JdeField("WOSRP1", "WOSRP1", JdeDataType.String, 6),
        new JdeField("WOSRP2", "WOSRP2", JdeDataType.String, 6),
        new JdeField("WOSRP3", "WOSRP3", JdeDataType.String, 6),
        new JdeField("WOSRP4", "WOSRP4", JdeDataType.String, 6),
        new JdeField("WOSRP5", "WOSRP5", JdeDataType.String, 6),
        new JdeField("WOSRP6", "WOSRP6", JdeDataType.String, 12),
        new JdeField("WOSRP7", "WOSRP7", JdeDataType.String, 12),
        new JdeField("WOSRP8", "WOSRP8", JdeDataType.String, 12),
        new JdeField("WOSRP9", "WOSRP9", JdeDataType.String, 12),
        new JdeField("WOSRP0", "WOSRP0", JdeDataType.String, 12),
        new JdeField("WOPRP1", "WOPRP1", JdeDataType.String, 6),
        new JdeField("WOPRP2", "WOPRP2", JdeDataType.String, 6),
        new JdeField("WOPRP3", "WOPRP3", JdeDataType.String, 6),
        new JdeField("WOPRP4", "WOPRP4", JdeDataType.String, 6),
        new JdeField("WOPRP5", "WOPRP5", JdeDataType.String, 6),
        new JdeField("WOPRP6", "WOPRP6", JdeDataType.String, 12),
        new JdeField("WOPRP7", "WOPRP7", JdeDataType.String, 12),
        new JdeField("WOPRP8", "WOPRP8", JdeDataType.String, 12),
        new JdeField("WOPRP9", "WOPRP9", JdeDataType.String, 12),
        new JdeField("WOPRP0", "WOPRP0", JdeDataType.String, 12),
        new JdeField("WOCKAV", "WOCKAV", JdeDataType.String, 2),
        new JdeField("WOUSER", "WOUSER", JdeDataType.String, 20),
        new JdeField("WOPID", "WOPID", JdeDataType.String, 20),
        new JdeField("WOJOBN", "WOJOBN", JdeDataType.String, 20),
        new JdeField("WOUPMJ", "WOUPMJ", JdeDataType.Numeric),
        new JdeField("WOUPMT", "WOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW96_0", "Primary Key on WOJOBS, WOUKID", new[] { "WOJOBS", "WOUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW96_2", "Index on WOJOBS, WOITM, WOMCU", new[] { "WOJOBS", "WOITM", "WOMCU" })
    };
}
