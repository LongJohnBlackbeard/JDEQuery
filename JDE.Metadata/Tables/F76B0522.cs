using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0522 - .
/// </summary>
public class F76B0522 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNJOBS.
        /// </summary>
        public const string TNJOBS = "TNJOBS";

        /// <summary>
        /// TNBNOP.
        /// </summary>
        public const string TNBNOP = "TNBNOP";

        /// <summary>
        /// TNBSOP.
        /// </summary>
        public const string TNBSOP = "TNBSOP";

        /// <summary>
        /// TNDESC.
        /// </summary>
        public const string TNDESC = "TNDESC";

        /// <summary>
        /// TNURRC.
        /// </summary>
        public const string TNURRC = "TNURRC";

        /// <summary>
        /// TNURRF.
        /// </summary>
        public const string TNURRF = "TNURRF";

        /// <summary>
        /// TNURAB.
        /// </summary>
        public const string TNURAB = "TNURAB";

        /// <summary>
        /// TNURDT.
        /// </summary>
        public const string TNURDT = "TNURDT";

        /// <summary>
        /// TNURAT.
        /// </summary>
        public const string TNURAT = "TNURAT";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNPID.
        /// </summary>
        public const string TNPID = "TNPID";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNUPMT.
        /// </summary>
        public const string TNUPMT = "TNUPMT";

        /// <summary>
        /// TNUPMJ.
        /// </summary>
        public const string TNUPMJ = "TNUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0522";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNJOBS", "TNJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TNBNOP", "TNBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("TNBSOP", "TNBSOP", JdeDataType.String, 4, true, true),
        new JdeField("TNDESC", "TNDESC", JdeDataType.String, 60),
        new JdeField("TNURRC", "TNURRC", JdeDataType.String, 4),
        new JdeField("TNURRF", "TNURRF", JdeDataType.String, 30),
        new JdeField("TNURAB", "TNURAB", JdeDataType.Numeric),
        new JdeField("TNURDT", "TNURDT", JdeDataType.Numeric),
        new JdeField("TNURAT", "TNURAT", JdeDataType.Numeric),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNPID", "TNPID", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNUPMT", "TNUPMT", JdeDataType.Numeric),
        new JdeField("TNUPMJ", "TNUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0522_0", "Primary Key on TNJOBS, TNBNOP, TNBSOP", new[] { "TNJOBS", "TNBNOP", "TNBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
