using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B426 - .
/// </summary>
public class F03B426 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKCO.
        /// </summary>
        public const string TKCO = "TKCO";

        /// <summary>
        /// TKLNID.
        /// </summary>
        public const string TKLNID = "TKLNID";

        /// <summary>
        /// TKDCT.
        /// </summary>
        public const string TKDCT = "TKDCT";

        /// <summary>
        /// TKMCU.
        /// </summary>
        public const string TKMCU = "TKMCU";

        /// <summary>
        /// TKAN8.
        /// </summary>
        public const string TKAN8 = "TKAN8";

        /// <summary>
        /// TKCTR.
        /// </summary>
        public const string TKCTR = "TKCTR";

        /// <summary>
        /// TKACV1.
        /// </summary>
        public const string TKACV1 = "TKACV1";

        /// <summary>
        /// TKRRF.
        /// </summary>
        public const string TKRRF = "TKRRF";

        /// <summary>
        /// TKCONFD.
        /// </summary>
        public const string TKCONFD = "TKCONFD";

        /// <summary>
        /// TKRDF.
        /// </summary>
        public const string TKRDF = "TKRDF";

        /// <summary>
        /// TKVALFJ.
        /// </summary>
        public const string TKVALFJ = "TKVALFJ";

        /// <summary>
        /// TKVALTJ.
        /// </summary>
        public const string TKVALTJ = "TKVALTJ";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B426";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKCO", "TKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKLNID", "TKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TKDCT", "TKDCT", JdeDataType.String, 4),
        new JdeField("TKMCU", "TKMCU", JdeDataType.String, 24),
        new JdeField("TKAN8", "TKAN8", JdeDataType.Numeric),
        new JdeField("TKCTR", "TKCTR", JdeDataType.String, 6),
        new JdeField("TKACV1", "TKACV1", JdeDataType.String, 6),
        new JdeField("TKRRF", "TKRRF", JdeDataType.String, 2),
        new JdeField("TKCONFD", "TKCONFD", JdeDataType.Numeric),
        new JdeField("TKRDF", "TKRDF", JdeDataType.String, 2),
        new JdeField("TKVALFJ", "TKVALFJ", JdeDataType.Numeric),
        new JdeField("TKVALTJ", "TKVALTJ", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B426_0", "Primary Key on TKCO, TKLNID", new[] { "TKCO", "TKLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
